namespace WindowsFormsApp3
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblWaterLast = new System.Windows.Forms.Label();
            this.lblWaterThis = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 104);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "PHONE";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(16, 120);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(123, 32);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "\r\nCUSTOMER TYPE";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(16, 164);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(158, 16);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "NUMBER OF MEMBERS";
            // 
            // lblWaterLast
            // 
            this.lblWaterLast.AutoSize = true;
            this.lblWaterLast.Location = new System.Drawing.Point(80, 239);
            this.lblWaterLast.Name = "lblWaterLast";
            this.lblWaterLast.Size = new System.Drawing.Size(94, 16);
            this.lblWaterLast.TabIndex = 5;
            this.lblWaterLast.Text = "LAST MONTH";
            // 
            // lblWaterThis
            // 
            this.lblWaterThis.AutoSize = true;
            this.lblWaterThis.Location = new System.Drawing.Point(449, 239);
            this.lblWaterThis.Name = "lblWaterThis";
            this.lblWaterThis.Size = new System.Drawing.Size(91, 16);
            this.lblWaterThis.TabIndex = 6;
            this.lblWaterThis.Text = "THIS MONTH";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(244, 292);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(140, 16);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "AMOUNT OF WATER";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 371);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 16);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "TOTAL PRICE";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 413);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(98, 16);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "DESCRIPTION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblWaterThis);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblWaterLast);
            this.groupBox1.Location = new System.Drawing.Point(358, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 451);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WATER BILL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-3, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(639, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------------\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(639, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------------";
            // 
            // bnExit
            // 
            this.bnExit.Location = new System.Drawing.Point(605, 478);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(91, 33);
            this.bnExit.TabIndex = 11;
            this.bnExit.Text = "Exit";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 551);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Bill Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblWaterLast;
        private System.Windows.Forms.Label lblWaterThis;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bnExit;
    }
}