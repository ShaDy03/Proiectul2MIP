namespace Proiectul2MIP.UI
{
    partial class OnlineUser
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
            this.OnlineUsers = new System.Windows.Forms.ListBox();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.SendProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OnlineUsers
            // 
            this.OnlineUsers.BackColor = System.Drawing.Color.Wheat;
            this.OnlineUsers.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.OnlineUsers.ForeColor = System.Drawing.Color.Teal;
            this.OnlineUsers.FormattingEnabled = true;
            this.OnlineUsers.ItemHeight = 32;
            this.OnlineUsers.Location = new System.Drawing.Point(12, 12);
            this.OnlineUsers.Name = "OnlineUsers";
            this.OnlineUsers.Size = new System.Drawing.Size(600, 420);
            this.OnlineUsers.TabIndex = 0;
            // 
            // IndexBox
            // 
            this.IndexBox.BackColor = System.Drawing.Color.Wheat;
            this.IndexBox.Location = new System.Drawing.Point(618, 125);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(170, 26);
            this.IndexBox.TabIndex = 1;
            // 
            // SendProfile
            // 
            this.SendProfile.BackColor = System.Drawing.Color.Chocolate;
            this.SendProfile.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SendProfile.Location = new System.Drawing.Point(618, 188);
            this.SendProfile.Name = "SendProfile";
            this.SendProfile.Size = new System.Drawing.Size(170, 53);
            this.SendProfile.TabIndex = 2;
            this.SendProfile.Text = "Profile";
            this.SendProfile.UseVisualStyleBackColor = false;
            this.SendProfile.Click += new System.EventHandler(this.SendProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(638, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Index Profile";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HomeBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HomeBtn.Location = new System.Drawing.Point(618, 26);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(170, 44);
            this.HomeBtn.TabIndex = 4;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // OnlineUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendProfile);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.OnlineUsers);
            this.Name = "OnlineUser";
            this.Text = "OnlineUser";
            this.Load += new System.EventHandler(this.OnlineUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OnlineUsers;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Button SendProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomeBtn;
    }
}