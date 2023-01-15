namespace Proiectul2MIP.UI
{
    partial class Profile
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
            this.UserAccount = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.RoleLBL = new System.Windows.Forms.Label();
            this.UserNameLBL = new System.Windows.Forms.Label();
            this.DeleteAccount = new System.Windows.Forms.Button();
            this.BlockedAccount = new System.Windows.Forms.Button();
            this.UserNameProfileLBL = new System.Windows.Forms.Label();
            this.RoleProfileLBL = new System.Windows.Forms.Label();
            this.ProfileDeletedLBL = new System.Windows.Forms.Label();
            this.ProfileBlockedLBL = new System.Windows.Forms.Label();
            this.UPgradeRole = new System.Windows.Forms.Button();
            this.DOWNgradeRole = new System.Windows.Forms.Button();
            this.UserAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserAccount
            // 
            this.UserAccount.BackColor = System.Drawing.Color.Cornsilk;
            this.UserAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserAccount.Controls.Add(this.HomeBtn);
            this.UserAccount.Controls.Add(this.LogOutBtn);
            this.UserAccount.Controls.Add(this.RoleLBL);
            this.UserAccount.Controls.Add(this.UserNameLBL);
            this.UserAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserAccount.Location = new System.Drawing.Point(482, 12);
            this.UserAccount.Name = "UserAccount";
            this.UserAccount.Size = new System.Drawing.Size(306, 141);
            this.UserAccount.TabIndex = 1;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HomeBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HomeBtn.Location = new System.Drawing.Point(3, 46);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(296, 44);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Coral;
            this.LogOutBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LogOutBtn.Location = new System.Drawing.Point(3, 90);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(296, 44);
            this.LogOutBtn.TabIndex = 2;
            this.LogOutBtn.Text = "Logout";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            // 
            // RoleLBL
            // 
            this.RoleLBL.AutoSize = true;
            this.RoleLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLBL.Location = new System.Drawing.Point(160, 14);
            this.RoleLBL.Name = "RoleLBL";
            this.RoleLBL.Size = new System.Drawing.Size(139, 32);
            this.RoleLBL.TabIndex = 1;
            this.RoleLBL.Text = "Administrator";
            // 
            // UserNameLBL
            // 
            this.UserNameLBL.AutoSize = true;
            this.UserNameLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLBL.Location = new System.Drawing.Point(3, 14);
            this.UserNameLBL.Name = "UserNameLBL";
            this.UserNameLBL.Size = new System.Drawing.Size(77, 32);
            this.UserNameLBL.TabIndex = 0;
            this.UserNameLBL.Text = "ShaDy";
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.BackColor = System.Drawing.Color.Chartreuse;
            this.DeleteAccount.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DeleteAccount.Location = new System.Drawing.Point(441, 205);
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Size = new System.Drawing.Size(342, 93);
            this.DeleteAccount.TabIndex = 2;
            this.DeleteAccount.Text = "Delete Account";
            this.DeleteAccount.UseVisualStyleBackColor = false;
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // BlockedAccount
            // 
            this.BlockedAccount.BackColor = System.Drawing.Color.Brown;
            this.BlockedAccount.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BlockedAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BlockedAccount.Location = new System.Drawing.Point(319, 345);
            this.BlockedAccount.Name = "BlockedAccount";
            this.BlockedAccount.Size = new System.Drawing.Size(178, 93);
            this.BlockedAccount.TabIndex = 3;
            this.BlockedAccount.Text = "Blocked Account (Admin)";
            this.BlockedAccount.UseVisualStyleBackColor = false;
            this.BlockedAccount.Click += new System.EventHandler(this.BlockedAccount_Click);
            // 
            // UserNameProfileLBL
            // 
            this.UserNameProfileLBL.AutoSize = true;
            this.UserNameProfileLBL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UserNameProfileLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UserNameProfileLBL.Location = new System.Drawing.Point(101, 83);
            this.UserNameProfileLBL.Name = "UserNameProfileLBL";
            this.UserNameProfileLBL.Size = new System.Drawing.Size(170, 32);
            this.UserNameProfileLBL.TabIndex = 4;
            this.UserNameProfileLBL.Text = "UserName Profile";
            // 
            // RoleProfileLBL
            // 
            this.RoleProfileLBL.AutoSize = true;
            this.RoleProfileLBL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.RoleProfileLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RoleProfileLBL.Location = new System.Drawing.Point(101, 147);
            this.RoleProfileLBL.Name = "RoleProfileLBL";
            this.RoleProfileLBL.Size = new System.Drawing.Size(116, 32);
            this.RoleProfileLBL.TabIndex = 5;
            this.RoleProfileLBL.Text = "Role Profile";
            // 
            // ProfileDeletedLBL
            // 
            this.ProfileDeletedLBL.AutoSize = true;
            this.ProfileDeletedLBL.BackColor = System.Drawing.Color.Chartreuse;
            this.ProfileDeletedLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ProfileDeletedLBL.Location = new System.Drawing.Point(101, 205);
            this.ProfileDeletedLBL.Name = "ProfileDeletedLBL";
            this.ProfileDeletedLBL.Size = new System.Drawing.Size(194, 32);
            this.ProfileDeletedLBL.TabIndex = 6;
            this.ProfileDeletedLBL.Text = "Account Deleted: NO";
            // 
            // ProfileBlockedLBL
            // 
            this.ProfileBlockedLBL.AutoSize = true;
            this.ProfileBlockedLBL.BackColor = System.Drawing.Color.Chartreuse;
            this.ProfileBlockedLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ProfileBlockedLBL.Location = new System.Drawing.Point(101, 264);
            this.ProfileBlockedLBL.Name = "ProfileBlockedLBL";
            this.ProfileBlockedLBL.Size = new System.Drawing.Size(201, 32);
            this.ProfileBlockedLBL.TabIndex = 7;
            this.ProfileBlockedLBL.Text = "Account Blocked: NO";
            // 
            // UPgradeRole
            // 
            this.UPgradeRole.BackColor = System.Drawing.Color.Brown;
            this.UPgradeRole.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UPgradeRole.Location = new System.Drawing.Point(12, 345);
            this.UPgradeRole.Name = "UPgradeRole";
            this.UPgradeRole.Size = new System.Drawing.Size(172, 93);
            this.UPgradeRole.TabIndex = 8;
            this.UPgradeRole.Text = "Upgrade Role (Admin)";
            this.UPgradeRole.UseVisualStyleBackColor = false;
            this.UPgradeRole.Click += new System.EventHandler(this.UPgradeRole_Click);
            // 
            // DOWNgradeRole
            // 
            this.DOWNgradeRole.BackColor = System.Drawing.Color.Brown;
            this.DOWNgradeRole.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DOWNgradeRole.Location = new System.Drawing.Point(616, 345);
            this.DOWNgradeRole.Name = "DOWNgradeRole";
            this.DOWNgradeRole.Size = new System.Drawing.Size(172, 93);
            this.DOWNgradeRole.TabIndex = 9;
            this.DOWNgradeRole.Text = "DownGrade Role (Admin)";
            this.DOWNgradeRole.UseVisualStyleBackColor = false;
            this.DOWNgradeRole.Click += new System.EventHandler(this.DOWNgradeRole_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DOWNgradeRole);
            this.Controls.Add(this.UPgradeRole);
            this.Controls.Add(this.ProfileBlockedLBL);
            this.Controls.Add(this.ProfileDeletedLBL);
            this.Controls.Add(this.RoleProfileLBL);
            this.Controls.Add(this.UserNameProfileLBL);
            this.Controls.Add(this.BlockedAccount);
            this.Controls.Add(this.DeleteAccount);
            this.Controls.Add(this.UserAccount);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.UserAccount.ResumeLayout(false);
            this.UserAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserAccount;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label RoleLBL;
        private System.Windows.Forms.Label UserNameLBL;
        private System.Windows.Forms.Button DeleteAccount;
        private System.Windows.Forms.Button BlockedAccount;
        private System.Windows.Forms.Label UserNameProfileLBL;
        private System.Windows.Forms.Label RoleProfileLBL;
        private System.Windows.Forms.Label ProfileDeletedLBL;
        private System.Windows.Forms.Label ProfileBlockedLBL;
        private System.Windows.Forms.Button UPgradeRole;
        private System.Windows.Forms.Button DOWNgradeRole;
    }
}