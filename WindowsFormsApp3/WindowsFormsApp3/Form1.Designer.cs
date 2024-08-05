namespace WindowsFormsApp3
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.bnLogin = new System.Windows.Forms.Button();
            this.bnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(344, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Usename";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(343, 175);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 16);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(434, 116);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(168, 22);
            this.tBName.TabIndex = 2;
            // 
            // tBPass
            // 
            this.tBPass.Location = new System.Drawing.Point(434, 169);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(168, 22);
            this.tBPass.TabIndex = 3;
            // 
            // bnLogin
            // 
            this.bnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLogin.Location = new System.Drawing.Point(335, 229);
            this.bnLogin.Name = "bnLogin";
            this.bnLogin.Size = new System.Drawing.Size(100, 37);
            this.bnLogin.TabIndex = 4;
            this.bnLogin.Text = "Login";
            this.bnLogin.UseVisualStyleBackColor = true;
            this.bnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnExit
            // 
            this.bnExit.Location = new System.Drawing.Point(502, 229);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(100, 37);
            this.bnExit.TabIndex = 5;
            this.bnExit.Text = "Exit";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 541);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.bnLogin);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Button bnLogin;
        private System.Windows.Forms.Button bnExit;
    }
}

