using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbLibrary;

namespace Fender_Lamp
{
    enum Command : byte
    {
        HID_C_GET_NUM_OF_SETS = 0x10,
        HID_C_SET_NUM_OF_SETS = 0x11,
        HID_C_GET_SET = 0x20,
        HID_C_SET_SET = 0x21,
        HID_C_GET_EIGHT_SETS = 0x30,
        HID_C_SET_EIGHT_SETS = 0x31,
        HID_C_UPDATE_FLASH = 0x90
    }

    public partial class Form1 : Form
    {

        UsbHidPort usb = new UsbHidPort();
        
        private UInt16 USBDevProductID = 0x0303;
        private UInt16 USBDevVendorID = 0x29A4;
        private string USBDevProduct = "";
        private string USBDevVendor = "";

        private const byte USB_ReportLength = 38;

        private List<byte[]> Sets;

        private bool connected = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            usb.OnSpecifiedDeviceArrived += usb_OnSpecifiedDeviceArrived;
            usb.OnSpecifiedDeviceRemoved += usb_OnSpecifiedDeviceRemoved;
            usb.OnDataRecieved += usb_OnDataRecieved;

            if (usb.Ready())
            {
                usb.Close();
            }

            usb.ProductId = USBDevProductID;
            usb.VendorId = USBDevVendorID;

            usb.Open(true);

            
            
        }

        private void usb_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            if (usb.Ready())
            {
                connected = true;
                usb.GetInfoStrings(ref USBDevVendor, ref USBDevProduct);

                labelConnection.Text = "Connected with " + USBDevProduct;
                labelConnection.ForeColor = Color.Green;

                GetLampSets();
            }
        }

        async void GetLampSets()
        {
            var recieve = DataRecievedOrTimeout(TimeSpan.FromMilliseconds(100));
            SendCommand(Command.HID_C_GET_NUM_OF_SETS);
            try
            {
                DataRecievedEventArgs args = await recieve;
            }
            catch (TimeoutException)
            {

            }

            int CmdNum = Sets.Capacity / 8;
            if (Sets.Capacity % 8 > 0)
                CmdNum++;

            for (byte i = 0; i < CmdNum; i ++)
            {
                recieve = DataRecievedOrTimeout(TimeSpan.FromMilliseconds(100));
                SendCommand(Command.HID_C_GET_EIGHT_SETS, (byte)(i * 8));
                try
                {
                    DataRecievedEventArgs args = await recieve;
                }
                catch (TimeoutException)
                {

                }
            }

            foreach(byte[] set in Sets)
            {
                if (Sets.IndexOf(set) != 0)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = set[0].ToString() + " " + (set[1]*6).ToString() + " " + (set[2]*5).ToString() + " " + set[3].ToString();
                    listViewSets.Items.Add(lvi);
                }
            }
        }

        async void SetLampSets()
        {
            var recieve = DataRecievedOrTimeout(TimeSpan.FromMilliseconds(100));
            SendCommand(Command.HID_C_SET_NUM_OF_SETS, (byte)Sets.Count);
            try
            {
                DataRecievedEventArgs args = await recieve;
            }
            catch (TimeoutException)
            {

            }

            int CmdNum = (byte)Sets.Count / 8;
            if ((byte)Sets.Count % 8 > 0)
                CmdNum++;

            for (int i = 0; i < CmdNum; i++)
            {
                byte[] sets = new byte[USB_ReportLength - 1];
                sets[0] = (byte)(i * 8);
                for (int j = 0; j < 8; j++)
                {
                    if (i * 8 + j < Sets.Count)
                    {
                        sets[j * 4 + 1] = Sets[i * 8 + j][0];
                        sets[j * 4 + 2] = Sets[i * 8 + j][1];
                        sets[j * 4 + 3] = Sets[i * 8 + j][2];
                        sets[j * 4 + 4] = Sets[i * 8 + j][3];
                    }
                }
                recieve = DataRecievedOrTimeout(TimeSpan.FromMilliseconds(100));
                SendCommand(Command.HID_C_SET_EIGHT_SETS, sets);
                try
                {
                    DataRecievedEventArgs args = await recieve;
                }
                catch (TimeoutException)
                {

                }
            }
        }

        private void SendCommand(Command command, byte[] args)
        {
            byte[] ReportData = new byte[USB_ReportLength];
            ReportData[1] = (byte)command;
            for (int i = 0; i < USB_ReportLength - 2; i++)
            {
                ReportData[i + 2] = args[i];
            }
            usb.WriteOutputReport(0x00, ReportData);

        }

        private void SendCommand(Command command, byte arg)
        {
            byte[] ReportData = new byte[USB_ReportLength];
            ReportData[1] = (byte)command;
            ReportData[2] = (byte)arg;
            usb.WriteOutputReport(0x00, ReportData);
        }

        private void SendCommand(Command command)
        {
            byte[] ReportData = new byte[USB_ReportLength];
            ReportData[1] = (byte)command;
            usb.WriteOutputReport(0x00, ReportData);

        }

        private void usb_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {
            labelConnection.Text = "Disconnected";
            labelConnection.ForeColor = Color.Red;
            listViewSets.Items.Clear();
            connected = false;
        }

        private void usb_OnDataRecieved(object sender, DataRecievedEventArgs args)
        {
            switch (args.data[1])
            {
                case (byte)Command.HID_C_GET_NUM_OF_SETS:
                    Sets = new List<byte[]>(args.data[2]);
                    break;
                case (byte)Command.HID_C_SET_NUM_OF_SETS:
                    
                    break;
                case (byte)Command.HID_C_GET_SET:
                    Sets[args.data[2]] = new byte[4] { args.data[3], args.data[4], args.data[5], args.data[6] };
                    break;
                case (byte)Command.HID_C_SET_SET:

                    break;
                case (byte)Command.HID_C_GET_EIGHT_SETS:
                    for (int i = 0; i < 8; i++)
                        if (args.data[2] + i < Sets.Capacity)
                            Sets.Insert(args.data[2] + i, new byte[4] { 
                                args.data[3 + i * 4], 
                                args.data[4 + i * 4], 
                                args.data[5 + i * 4], 
                                args.data[6 + i * 4] });
                    break;
                case (byte)Command.HID_C_SET_EIGHT_SETS:

                    break;
                case (byte)Command.HID_C_UPDATE_FLASH:

                    break;
                default:
                    break;
            }
        }

        async Task<DataRecievedEventArgs> DataRecievedOrTimeout(TimeSpan ts)
        {
            try
            {
                var tcs = new TaskCompletionSource<DataRecievedEventArgs>();
                var timeoutTask = Task.Delay(ts);
                var winner = await Task.WhenAny(tcs.Task, timeoutTask);
                if (winner == timeoutTask)
                    throw new TimeoutException();
                return await tcs.Task;
            }
            finally
            {

            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            usb.RegisterHandle(Handle);
        }

        protected override void WndProc(ref Message m)
        {
            usb.ParseMessages(ref m);
            base.WndProc(ref m);
        }

        private void buttonAddColorSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (connected)
                {
                    if (Byte.Parse(textBoxRed.Text) == 0 && Byte.Parse(textBoxGreen.Text) == 0 && Byte.Parse(textBoxBlue.Text) == 0 && Byte.Parse(textBoxWhite.Text) == 0)
                    {
                        MessageBox.Show("Color value should not be 0:0:0:0", "Error");
                    }
                    else
                    {
                        Sets.Add(new byte[4] { Byte.Parse(textBoxRed.Text),
                        (byte)(Byte.Parse(textBoxGreen.Text)/6),
                        (byte)(Byte.Parse(textBoxBlue.Text)/5),
                        Byte.Parse(textBoxWhite.Text) });
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = Byte.Parse(textBoxRed.Text) + " " +
                            Byte.Parse(textBoxGreen.Text) + " " +
                            Byte.Parse(textBoxBlue.Text) + " " +
                            Byte.Parse(textBoxWhite.Text);
                        listViewSets.Items.Add(lvi);
                        SetLampSets();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Color value must be in range [0:255]", "Error");
            }
            
        }

        private void buttonDeleteColorSet_Click(object sender, EventArgs e)
        {
            int selected;
            try
            {
                if (connected)
                {
                    selected = listViewSets.SelectedIndices[0];
                    Sets.RemoveAt(selected + 1);
                    listViewSets.Items.RemoveAt(selected);
                    SetLampSets();
                }
            }
            catch
            {
                
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                SendCommand(Command.HID_C_UPDATE_FLASH);
            }
        }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxRed.Text, @"^\d+$") == false)
            {
                textBoxRed.Text = "";
            }
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxGreen.Text, @"^\d+$") == false)
            {
                textBoxGreen.Text = "";
            }
        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxBlue.Text, @"^\d+$") == false)
            {
                textBoxBlue.Text = "";
            }
        }

        private void textBoxWhite_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxWhite.Text, @"^\d+$") == false)
            {
                textBoxWhite.Text = "";
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBoxWhite.Text = trackBar1.Value.ToString();
        }

        private void pictureBoxPalette_Click(object sender, EventArgs e)
        {
            Point p = pictureBoxPalette.PointToClient(Cursor.Position);
            Color c = ((Bitmap)pictureBoxPalette.Image).GetPixel(p.X*pictureBoxPalette.Image.Size.Width/pictureBoxPalette.Size.Width, p.Y * pictureBoxPalette.Image.Size.Height / pictureBoxPalette.Size.Height);
            textBoxRed.Text = c.R.ToString();
            textBoxGreen.Text = c.G.ToString();
            textBoxBlue.Text = c.B.ToString();
            if (textBoxWhite.Text == "")
            {
                textBoxWhite.Text = "0";
            }
            pictureBoxCurColor.BackColor = c;
        }
    }
}
