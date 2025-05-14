namespace WindowsFormsApp1
{
    partial class PayItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoOutput = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.payButton = new System.Windows.Forms.Button();
            this.cardPaswordText = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.infoOutput);
            this.panel2.Controls.Add(this.cardNumber);
            this.panel2.Controls.Add(this.payButton);
            this.panel2.Controls.Add(this.cardPaswordText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 600);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // infoOutput
            // 
            this.infoOutput.AutoSize = true;
            this.infoOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoOutput.Location = new System.Drawing.Point(252, 115);
            this.infoOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoOutput.Name = "infoOutput";
            this.infoOutput.Size = new System.Drawing.Size(274, 29);
            this.infoOutput.TabIndex = 3;
            this.infoOutput.Text = "Check your card number";
            // 
            // cardNumber
            // 
            this.cardNumber.CausesValidation = false;
            this.cardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardNumber.ForeColor = System.Drawing.Color.Silver;
            this.cardNumber.Location = new System.Drawing.Point(257, 222);
            this.cardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(620, 34);
            this.cardNumber.TabIndex = 0;
            this.cardNumber.Text = "Card Number";
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payButton.Location = new System.Drawing.Point(257, 391);
            this.payButton.Margin = new System.Windows.Forms.Padding(4);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(248, 100);
            this.payButton.TabIndex = 2;
            this.payButton.Text = "PAY";
            this.payButton.UseVisualStyleBackColor = true;
            // 
            // cardPaswordText
            // 
            this.cardPaswordText.CausesValidation = false;
            this.cardPaswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardPaswordText.ForeColor = System.Drawing.Color.Silver;
            this.cardPaswordText.Location = new System.Drawing.Point(257, 300);
            this.cardPaswordText.Margin = new System.Windows.Forms.Padding(4);
            this.cardPaswordText.Name = "cardPaswordText";
            this.cardPaswordText.Size = new System.Drawing.Size(620, 34);
            this.cardPaswordText.TabIndex = 1;
            this.cardPaswordText.Text = "Password";
            // 
            // PayItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "PayItem";
            this.Size = new System.Drawing.Size(1024, 600);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label infoOutput;
        private System.Windows.Forms.TextBox cardNumber;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.TextBox cardPaswordText;
    }
}
