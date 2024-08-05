namespace WindowsFormsApp3
{
    partial class Form2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bnAdd = new System.Windows.Forms.Button();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnPrint = new System.Windows.Forms.Button();
            this.tBID = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBPhone = new System.Windows.Forms.TextBox();
            this.tBNumber = new System.Windows.Forms.TextBox();
            this.tBWaterLast = new System.Windows.Forms.TextBox();
            this.tBWaterThis = new System.Windows.Forms.TextBox();
            this.tBAmount = new System.Windows.Forms.TextBox();
            this.tBTotal = new System.Windows.Forms.TextBox();
            this.cBType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 274);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1553, 284);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type of customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Water last month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Water this month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Amount of water";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total price (with tax)";
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(111, 225);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(100, 39);
            this.bnAdd.TabIndex = 10;
            this.bnAdd.Text = "Add";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnEdit
            // 
            this.bnEdit.Location = new System.Drawing.Point(237, 225);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(100, 39);
            this.bnEdit.TabIndex = 11;
            this.bnEdit.Text = "Edit";
            this.bnEdit.UseVisualStyleBackColor = true;
            this.bnEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(369, 225);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(100, 39);
            this.bnDelete.TabIndex = 12;
            this.bnDelete.Text = "Delete";
            this.bnDelete.UseVisualStyleBackColor = true;
            this.bnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.Location = new System.Drawing.Point(503, 225);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(100, 39);
            this.bnCancel.TabIndex = 13;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // bnPrint
            // 
            this.bnPrint.Location = new System.Drawing.Point(649, 225);
            this.bnPrint.Name = "bnPrint";
            this.bnPrint.Size = new System.Drawing.Size(100, 39);
            this.bnPrint.TabIndex = 14;
            this.bnPrint.Text = "Print bill";
            this.bnPrint.UseVisualStyleBackColor = true;
            this.bnPrint.Click += new System.EventHandler(this.button5_Click);
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(111, 63);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(100, 22);
            this.tBID.TabIndex = 15;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(111, 111);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 22);
            this.tBName.TabIndex = 16;
            // 
            // tBPhone
            // 
            this.tBPhone.Location = new System.Drawing.Point(111, 160);
            this.tBPhone.Name = "tBPhone";
            this.tBPhone.Size = new System.Drawing.Size(100, 22);
            this.tBPhone.TabIndex = 17;
            // 
            // tBNumber
            // 
            this.tBNumber.Location = new System.Drawing.Point(278, 159);
            this.tBNumber.Name = "tBNumber";
            this.tBNumber.ReadOnly = true;
            this.tBNumber.Size = new System.Drawing.Size(119, 22);
            this.tBNumber.TabIndex = 18;
            // 
            // tBWaterLast
            // 
            this.tBWaterLast.Location = new System.Drawing.Point(570, 66);
            this.tBWaterLast.Name = "tBWaterLast";
            this.tBWaterLast.Size = new System.Drawing.Size(100, 22);
            this.tBWaterLast.TabIndex = 19;
            // 
            // tBWaterThis
            // 
            this.tBWaterThis.Location = new System.Drawing.Point(570, 105);
            this.tBWaterThis.Name = "tBWaterThis";
            this.tBWaterThis.Size = new System.Drawing.Size(100, 22);
            this.tBWaterThis.TabIndex = 20;
            // 
            // tBAmount
            // 
            this.tBAmount.Location = new System.Drawing.Point(570, 163);
            this.tBAmount.Name = "tBAmount";
            this.tBAmount.ReadOnly = true;
            this.tBAmount.Size = new System.Drawing.Size(100, 22);
            this.tBAmount.TabIndex = 21;
            // 
            // tBTotal
            // 
            this.tBTotal.Location = new System.Drawing.Point(720, 90);
            this.tBTotal.Name = "tBTotal";
            this.tBTotal.ReadOnly = true;
            this.tBTotal.Size = new System.Drawing.Size(121, 22);
            this.tBTotal.TabIndex = 22;
            // 
            // cBType
            // 
            this.cBType.FormattingEnabled = true;
            this.cBType.Items.AddRange(new object[] {
            "Household",
            "Administrative agency",
            "Production units",
            "Business services"});
            this.cBType.Location = new System.Drawing.Point(276, 88);
            this.cBType.Name = "cBType";
            this.cBType.Size = new System.Drawing.Size(121, 24);
            this.cBType.TabIndex = 23;
            this.cBType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(726, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Description";
            // 
            // tBDescription
            // 
            this.tBDescription.Location = new System.Drawing.Point(807, 147);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(191, 88);
            this.tBDescription.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 570);
            this.Controls.Add(this.tBDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cBType);
            this.Controls.Add(this.tBTotal);
            this.Controls.Add(this.tBAmount);
            this.Controls.Add(this.tBWaterThis);
            this.Controls.Add(this.tBWaterLast);
            this.Controls.Add(this.tBNumber);
            this.Controls.Add(this.tBPhone);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.bnPrint);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnPrint;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBPhone;
        private System.Windows.Forms.TextBox tBNumber;
        private System.Windows.Forms.TextBox tBWaterLast;
        private System.Windows.Forms.TextBox tBWaterThis;
        private System.Windows.Forms.TextBox tBAmount;
        private System.Windows.Forms.TextBox tBTotal;
        private System.Windows.Forms.ComboBox cBType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBDescription;
    }
}