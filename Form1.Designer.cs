
namespace Fender_Lamp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelColorSets = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddColorSet = new System.Windows.Forms.Button();
            this.buttonDeleteColorSet = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.listViewSets = new System.Windows.Forms.ListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxWhite = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelWhite = new System.Windows.Forms.Label();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.labelConnection = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxPalette = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBoxCurColor = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurColor)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.97727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.02273F));
            this.tableLayoutPanel1.Controls.Add(this.labelColorSets, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewSets, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelColorSets
            // 
            this.labelColorSets.AutoSize = true;
            this.labelColorSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelColorSets.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelColorSets.Location = new System.Drawing.Point(3, 0);
            this.labelColorSets.Name = "labelColorSets";
            this.labelColorSets.Size = new System.Drawing.Size(163, 60);
            this.labelColorSets.TabIndex = 0;
            this.labelColorSets.Text = "Color sets";
            this.labelColorSets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAddColorSet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteColorSet, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSaveChanges, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(172, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(409, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonAddColorSet
            // 
            this.buttonAddColorSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddColorSet.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddColorSet.Location = new System.Drawing.Point(3, 3);
            this.buttonAddColorSet.Name = "buttonAddColorSet";
            this.buttonAddColorSet.Size = new System.Drawing.Size(130, 48);
            this.buttonAddColorSet.TabIndex = 0;
            this.buttonAddColorSet.Text = "+";
            this.buttonAddColorSet.UseVisualStyleBackColor = true;
            this.buttonAddColorSet.Click += new System.EventHandler(this.buttonAddColorSet_Click);
            // 
            // buttonDeleteColorSet
            // 
            this.buttonDeleteColorSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteColorSet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteColorSet.Location = new System.Drawing.Point(139, 3);
            this.buttonDeleteColorSet.Name = "buttonDeleteColorSet";
            this.buttonDeleteColorSet.Size = new System.Drawing.Size(130, 48);
            this.buttonDeleteColorSet.TabIndex = 1;
            this.buttonDeleteColorSet.Text = "Delete color set";
            this.buttonDeleteColorSet.UseVisualStyleBackColor = true;
            this.buttonDeleteColorSet.Click += new System.EventHandler(this.buttonDeleteColorSet_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveChanges.Location = new System.Drawing.Point(275, 3);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(131, 48);
            this.buttonSaveChanges.TabIndex = 2;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // listViewSets
            // 
            this.listViewSets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSets.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewSets.HideSelection = false;
            this.listViewSets.Location = new System.Drawing.Point(3, 63);
            this.listViewSets.MultiSelect = false;
            this.listViewSets.Name = "listViewSets";
            this.listViewSets.Size = new System.Drawing.Size(163, 295);
            this.listViewSets.TabIndex = 2;
            this.listViewSets.UseCompatibleStateImageBehavior = false;
            this.listViewSets.View = System.Windows.Forms.View.SmallIcon;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelConnection, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(172, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.73977F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.47929F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.78095F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(409, 295);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.Controls.Add(this.textBoxWhite, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxBlue, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxGreen, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelRed, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelGreen, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelBlue, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelWhite, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxRed, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(403, 37);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // textBoxWhite
            // 
            this.textBoxWhite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxWhite.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxWhite.Location = new System.Drawing.Point(335, 6);
            this.textBoxWhite.MaximumSize = new System.Drawing.Size(62, 25);
            this.textBoxWhite.MaxLength = 3;
            this.textBoxWhite.MinimumSize = new System.Drawing.Size(62, 25);
            this.textBoxWhite.Name = "textBoxWhite";
            this.textBoxWhite.Size = new System.Drawing.Size(62, 25);
            this.textBoxWhite.TabIndex = 7;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBlue.Location = new System.Drawing.Point(235, 6);
            this.textBoxBlue.MaximumSize = new System.Drawing.Size(62, 25);
            this.textBoxBlue.MaxLength = 3;
            this.textBoxBlue.MinimumSize = new System.Drawing.Size(62, 25);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(62, 25);
            this.textBoxBlue.TabIndex = 6;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGreen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxGreen.Location = new System.Drawing.Point(135, 6);
            this.textBoxGreen.MaximumSize = new System.Drawing.Size(62, 25);
            this.textBoxGreen.MaxLength = 3;
            this.textBoxGreen.MinimumSize = new System.Drawing.Size(62, 25);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(62, 25);
            this.textBoxGreen.TabIndex = 5;
            // 
            // labelRed
            // 
            this.labelRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRed.Location = new System.Drawing.Point(9, 0);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(20, 37);
            this.labelRed.TabIndex = 0;
            this.labelRed.Text = "R:";
            this.labelRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGreen
            // 
            this.labelGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGreen.Location = new System.Drawing.Point(108, 0);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(21, 37);
            this.labelGreen.TabIndex = 1;
            this.labelGreen.Text = "G:";
            this.labelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBlue
            // 
            this.labelBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBlue.Location = new System.Drawing.Point(209, 0);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(20, 37);
            this.labelBlue.TabIndex = 2;
            this.labelBlue.Text = "B:";
            this.labelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWhite
            // 
            this.labelWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWhite.AutoSize = true;
            this.labelWhite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWhite.Location = new System.Drawing.Point(304, 0);
            this.labelWhite.Name = "labelWhite";
            this.labelWhite.Size = new System.Drawing.Size(25, 37);
            this.labelWhite.TabIndex = 3;
            this.labelWhite.Text = "W:";
            this.labelWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxRed.Location = new System.Drawing.Point(35, 6);
            this.textBoxRed.MaximumSize = new System.Drawing.Size(62, 25);
            this.textBoxRed.MaxLength = 3;
            this.textBoxRed.MinimumSize = new System.Drawing.Size(62, 25);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(62, 25);
            this.textBoxRed.TabIndex = 4;
            // 
            // labelConnection
            // 
            this.labelConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConnection.Location = new System.Drawing.Point(3, 274);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(403, 21);
            this.labelConnection.TabIndex = 0;
            this.labelConnection.Text = "Disconnected";
            this.labelConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBoxPalette, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.trackBar1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.pictureBoxCurColor, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.12563F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87436F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(403, 210);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // pictureBoxPalette
            // 
            this.pictureBoxPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPalette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPalette.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPalette.Image")));
            this.pictureBoxPalette.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPalette.InitialImage")));
            this.pictureBoxPalette.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPalette.Name = "pictureBoxPalette";
            this.pictureBoxPalette.Size = new System.Drawing.Size(281, 162);
            this.pictureBoxPalette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPalette.TabIndex = 0;
            this.pictureBoxPalette.TabStop = false;
            this.pictureBoxPalette.WaitOnLoad = true;
            this.pictureBoxPalette.Click += new System.EventHandler(this.pictureBoxPalette_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(3, 171);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(281, 36);
            this.trackBar1.TabIndex = 1;
            // 
            // pictureBoxCurColor
            // 
            this.pictureBoxCurColor.Location = new System.Drawing.Point(290, 3);
            this.pictureBoxCurColor.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxCurColor.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxCurColor.Name = "pictureBoxCurColor";
            this.pictureBoxCurColor.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCurColor.TabIndex = 2;
            this.pictureBoxCurColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Pedalboard Light Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelColorSets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAddColorSet;
        private System.Windows.Forms.Button buttonDeleteColorSet;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.ListView listViewSets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelWhite;
        private System.Windows.Forms.TextBox textBoxWhite;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBoxPalette;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBoxCurColor;
    }
}

