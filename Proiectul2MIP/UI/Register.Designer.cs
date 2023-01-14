namespace Proiectul2MIP.UI
{
    partial class Register
    {
        private Common Data = Common.Instance;
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.CfPWBox = new System.Windows.Forms.TextBox();
            this.ShowPwCBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome! Are you new user?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please, Register now!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            // 
            // UserNameBox
            // 
            this.UserNameBox.BackColor = System.Drawing.Color.Aquamarine;
            this.UserNameBox.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox.Location = new System.Drawing.Point(307, 204);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(312, 45);
            this.UserNameBox.TabIndex = 5;
            this.UserNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PwBox
            // 
            this.PwBox.BackColor = System.Drawing.Color.Aquamarine;
            this.PwBox.Font = new System.Drawing.Font("Rockwell", 16F);
            this.PwBox.Location = new System.Drawing.Point(307, 260);
            this.PwBox.Name = "PwBox";
            this.PwBox.PasswordChar = '*';
            this.PwBox.Size = new System.Drawing.Size(312, 45);
            this.PwBox.TabIndex = 6;
            this.PwBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CfPWBox
            // 
            this.CfPWBox.BackColor = System.Drawing.Color.Aquamarine;
            this.CfPWBox.Font = new System.Drawing.Font("Rockwell", 16F);
            this.CfPWBox.Location = new System.Drawing.Point(307, 316);
            this.CfPWBox.Name = "CfPWBox";
            this.CfPWBox.PasswordChar = '*';
            this.CfPWBox.Size = new System.Drawing.Size(312, 45);
            this.CfPWBox.TabIndex = 7;
            this.CfPWBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowPwCBox
            // 
            this.ShowPwCBox.AutoSize = true;
            this.ShowPwCBox.Font = new System.Drawing.Font("Ravie", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPwCBox.Location = new System.Drawing.Point(347, 367);
            this.ShowPwCBox.Name = "ShowPwCBox";
            this.ShowPwCBox.Size = new System.Drawing.Size(199, 26);
            this.ShowPwCBox.TabIndex = 8;
            this.ShowPwCBox.Text = "Show Password";
            this.ShowPwCBox.UseVisualStyleBackColor = true;
            this.ShowPwCBox.CheckedChanged += new System.EventHandler(this.ShowPwCBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(260, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(781, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowPwCBox);
            this.Controls.Add(this.CfPWBox);
            this.Controls.Add(this.PwBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PwBox;
        private System.Windows.Forms.TextBox CfPWBox;
        private System.Windows.Forms.CheckBox ShowPwCBox;
        private System.Windows.Forms.Button button1;
    }
}