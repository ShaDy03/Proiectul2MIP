namespace Proiectul2MIP.UI
{
    partial class ShowAllUsers
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
            this.AllUsers = new System.Windows.Forms.ListBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SendProfile = new System.Windows.Forms.Button();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AllUsers
            // 
            this.AllUsers.BackColor = System.Drawing.Color.YellowGreen;
            this.AllUsers.FormattingEnabled = true;
            this.AllUsers.ItemHeight = 20;
            this.AllUsers.Location = new System.Drawing.Point(12, 12);
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.Size = new System.Drawing.Size(576, 424);
            this.AllUsers.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HomeBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HomeBtn.Location = new System.Drawing.Point(609, 117);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(170, 44);
            this.HomeBtn.TabIndex = 8;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(629, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index Profile";
            // 
            // SendProfile
            // 
            this.SendProfile.BackColor = System.Drawing.Color.Chocolate;
            this.SendProfile.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SendProfile.Location = new System.Drawing.Point(609, 279);
            this.SendProfile.Name = "SendProfile";
            this.SendProfile.Size = new System.Drawing.Size(170, 53);
            this.SendProfile.TabIndex = 6;
            this.SendProfile.Text = "Profile";
            this.SendProfile.UseVisualStyleBackColor = false;
            this.SendProfile.Click += new System.EventHandler(this.SendProfile_Click);
            // 
            // IndexBox
            // 
            this.IndexBox.BackColor = System.Drawing.Color.Wheat;
            this.IndexBox.Location = new System.Drawing.Point(609, 216);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(170, 26);
            this.IndexBox.TabIndex = 5;
            // 
            // ShowAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendProfile);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.AllUsers);
            this.Name = "ShowAllUsers";
            this.Text = "ShowAllUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AllUsers;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendProfile;
        private System.Windows.Forms.TextBox IndexBox;
    }
}