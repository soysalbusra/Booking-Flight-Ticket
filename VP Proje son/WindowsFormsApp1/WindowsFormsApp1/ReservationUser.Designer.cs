namespace WindowsFormsApp1
{
    partial class ReservationUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationUser));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flyingDateText = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.isOneWayText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passangerCountText = new System.Windows.Forms.Label();
            this.companyNamePanel = new System.Windows.Forms.Panel();
            this.companyNameText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.travelInfoPanel = new System.Windows.Forms.Panel();
            this.FromToLabel = new System.Windows.Forms.Label();
            this.flayingHourPanel = new System.Windows.Forms.Panel();
            this.flayingHourText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priceText = new System.Windows.Forms.Label();
            this.pnrPanel = new System.Windows.Forms.Panel();
            this.PNRNumber = new System.Windows.Forms.Label();
            this.PNR = new System.Windows.Forms.Label();
            this.isComplatedPanel = new System.Windows.Forms.Panel();
            this.IsComplatedText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.companyIcon = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkinButton = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.companyNamePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.travelInfoPanel.SuspendLayout();
            this.flayingHourPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnrPanel.SuspendLayout();
            this.isComplatedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.checkinButton);
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.companyNamePanel);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pnrPanel);
            this.panel4.Controls.Add(this.isComplatedPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 245);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 128);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 58);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.flyingDateText);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 50);
            this.panel3.TabIndex = 1;
            // 
            // flyingDateText
            // 
            this.flyingDateText.AutoSize = true;
            this.flyingDateText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flyingDateText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flyingDateText.Location = new System.Drawing.Point(4, 14);
            this.flyingDateText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flyingDateText.Name = "flyingDateText";
            this.flyingDateText.Size = new System.Drawing.Size(128, 27);
            this.flyingDateText.TabIndex = 0;
            this.flyingDateText.Text = "2 May 2024";
            this.flyingDateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.isOneWayText);
            this.panel5.Location = new System.Drawing.Point(173, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 50);
            this.panel5.TabIndex = 3;
            // 
            // isOneWayText
            // 
            this.isOneWayText.BackColor = System.Drawing.Color.White;
            this.isOneWayText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isOneWayText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isOneWayText.Location = new System.Drawing.Point(4, 6);
            this.isOneWayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isOneWayText.Name = "isOneWayText";
            this.isOneWayText.Size = new System.Drawing.Size(108, 39);
            this.isOneWayText.TabIndex = 7;
            this.isOneWayText.Text = "One Way";
            this.isOneWayText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passangerCountText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(299, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 51);
            this.panel1.TabIndex = 4;
            // 
            // passangerCountText
            // 
            this.passangerCountText.BackColor = System.Drawing.Color.White;
            this.passangerCountText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passangerCountText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passangerCountText.Location = new System.Drawing.Point(50, 10);
            this.passangerCountText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passangerCountText.Name = "passangerCountText";
            this.passangerCountText.Size = new System.Drawing.Size(28, 32);
            this.passangerCountText.TabIndex = 0;
            this.passangerCountText.Text = "1";
            this.passangerCountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passangerCountText.Click += new System.EventHandler(this.passangerCountText_Click);
            // 
            // companyNamePanel
            // 
            this.companyNamePanel.AutoSize = true;
            this.companyNamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.companyNamePanel.BackColor = System.Drawing.Color.White;
            this.companyNamePanel.Controls.Add(this.companyIcon);
            this.companyNamePanel.Controls.Add(this.companyNameText);
            this.companyNamePanel.Location = new System.Drawing.Point(18, 9);
            this.companyNamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.companyNamePanel.Name = "companyNamePanel";
            this.companyNamePanel.Size = new System.Drawing.Size(221, 41);
            this.companyNamePanel.TabIndex = 0;
            // 
            // companyNameText
            // 
            this.companyNameText.AutoSize = true;
            this.companyNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyNameText.Location = new System.Drawing.Point(48, 9);
            this.companyNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyNameText.Name = "companyNameText";
            this.companyNameText.Size = new System.Drawing.Size(169, 25);
            this.companyNameText.TabIndex = 0;
            this.companyNameText.Text = "Turkish Airlanes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.travelInfoPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flayingHourPanel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 54);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 66);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // travelInfoPanel
            // 
            this.travelInfoPanel.AutoSize = true;
            this.travelInfoPanel.BackColor = System.Drawing.Color.White;
            this.travelInfoPanel.Controls.Add(this.FromToLabel);
            this.travelInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.travelInfoPanel.Location = new System.Drawing.Point(4, 4);
            this.travelInfoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.travelInfoPanel.Name = "travelInfoPanel";
            this.travelInfoPanel.Size = new System.Drawing.Size(128, 58);
            this.travelInfoPanel.TabIndex = 1;
            // 
            // FromToLabel
            // 
            this.FromToLabel.AutoSize = true;
            this.FromToLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FromToLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FromToLabel.Location = new System.Drawing.Point(4, 16);
            this.FromToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromToLabel.Name = "FromToLabel";
            this.FromToLabel.Size = new System.Drawing.Size(94, 27);
            this.FromToLabel.TabIndex = 0;
            this.FromToLabel.Text = "İstanbul";
            this.FromToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flayingHourPanel
            // 
            this.flayingHourPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flayingHourPanel.Controls.Add(this.flayingHourText);
            this.flayingHourPanel.Location = new System.Drawing.Point(140, 4);
            this.flayingHourPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flayingHourPanel.Name = "flayingHourPanel";
            this.flayingHourPanel.Size = new System.Drawing.Size(128, 58);
            this.flayingHourPanel.TabIndex = 3;
            // 
            // flayingHourText
            // 
            this.flayingHourText.BackColor = System.Drawing.Color.White;
            this.flayingHourText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flayingHourText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flayingHourText.Location = new System.Drawing.Point(11, 10);
            this.flayingHourText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flayingHourText.Name = "flayingHourText";
            this.flayingHourText.Size = new System.Drawing.Size(103, 39);
            this.flayingHourText.TabIndex = 0;
            this.flayingHourText.Text = "09:00";
            this.flayingHourText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.priceText);
            this.panel2.Location = new System.Drawing.Point(713, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 57);
            this.panel2.TabIndex = 2;
            // 
            // priceText
            // 
            this.priceText.BackColor = System.Drawing.Color.White;
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceText.Location = new System.Drawing.Point(8, 10);
            this.priceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(199, 38);
            this.priceText.TabIndex = 0;
            this.priceText.Text = "894,99 TL";
            this.priceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnrPanel
            // 
            this.pnrPanel.BackColor = System.Drawing.Color.White;
            this.pnrPanel.Controls.Add(this.PNRNumber);
            this.pnrPanel.Controls.Add(this.PNR);
            this.pnrPanel.Location = new System.Drawing.Point(18, 194);
            this.pnrPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnrPanel.Name = "pnrPanel";
            this.pnrPanel.Size = new System.Drawing.Size(235, 47);
            this.pnrPanel.TabIndex = 1;
            // 
            // PNRNumber
            // 
            this.PNRNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNRNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PNRNumber.Location = new System.Drawing.Point(70, 8);
            this.PNRNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PNRNumber.Name = "PNRNumber";
            this.PNRNumber.Size = new System.Drawing.Size(161, 31);
            this.PNRNumber.TabIndex = 1;
            this.PNRNumber.Text = "RE7DRS";
            this.PNRNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PNR
            // 
            this.PNR.AutoSize = true;
            this.PNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PNR.Location = new System.Drawing.Point(4, 11);
            this.PNR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PNR.Name = "PNR";
            this.PNR.Size = new System.Drawing.Size(68, 25);
            this.PNR.TabIndex = 0;
            this.PNR.Text = "PNR :";
            // 
            // isComplatedPanel
            // 
            this.isComplatedPanel.BackColor = System.Drawing.Color.White;
            this.isComplatedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isComplatedPanel.Controls.Add(this.IsComplatedText);
            this.isComplatedPanel.Location = new System.Drawing.Point(713, 18);
            this.isComplatedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.isComplatedPanel.Name = "isComplatedPanel";
            this.isComplatedPanel.Size = new System.Drawing.Size(216, 55);
            this.isComplatedPanel.TabIndex = 1;
            // 
            // IsComplatedText
            // 
            this.IsComplatedText.BackColor = System.Drawing.Color.White;
            this.IsComplatedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsComplatedText.Location = new System.Drawing.Point(4, 9);
            this.IsComplatedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IsComplatedText.Name = "IsComplatedText";
            this.IsComplatedText.Size = new System.Drawing.Size(206, 34);
            this.IsComplatedText.TabIndex = 0;
            this.IsComplatedText.Text = "Complated";
            this.IsComplatedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // companyIcon
            // 
            this.companyIcon.BackColor = System.Drawing.Color.IndianRed;
            this.companyIcon.Image = global::WindowsFormsApp1.Properties.Resources.turkish_airlines_logo_1E368810A4_seeklogo_com;
            this.companyIcon.Location = new System.Drawing.Point(7, 6);
            this.companyIcon.Margin = new System.Windows.Forms.Padding(4);
            this.companyIcon.Name = "companyIcon";
            this.companyIcon.Size = new System.Drawing.Size(33, 31);
            this.companyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyIcon.TabIndex = 1;
            this.companyIcon.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelButton.Location = new System.Drawing.Point(770, 178);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 52);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // checkinButton
            // 
            this.checkinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkinButton.ForeColor = System.Drawing.Color.Black;
            this.checkinButton.Location = new System.Drawing.Point(583, 178);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(154, 52);
            this.checkinButton.TabIndex = 8;
            this.checkinButton.Text = "Check-in";
            this.checkinButton.UseVisualStyleBackColor = false;
            this.checkinButton.Visible = false;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // ReservationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "ReservationUser";
            this.Size = new System.Drawing.Size(950, 245);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.companyNamePanel.ResumeLayout(false);
            this.companyNamePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.travelInfoPanel.ResumeLayout(false);
            this.travelInfoPanel.PerformLayout();
            this.flayingHourPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnrPanel.ResumeLayout(false);
            this.pnrPanel.PerformLayout();
            this.isComplatedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel companyNamePanel;
        private System.Windows.Forms.PictureBox companyIcon;
        private System.Windows.Forms.Label companyNameText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel travelInfoPanel;
        private System.Windows.Forms.Label FromToLabel;
        private System.Windows.Forms.Panel flayingHourPanel;
        private System.Windows.Forms.Label flayingHourText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Panel pnrPanel;
        private System.Windows.Forms.Label PNRNumber;
        private System.Windows.Forms.Label PNR;
        private System.Windows.Forms.Panel isComplatedPanel;
        private System.Windows.Forms.Label IsComplatedText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label flyingDateText;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label isOneWayText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passangerCountText;
        private System.Windows.Forms.Button checkinButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
