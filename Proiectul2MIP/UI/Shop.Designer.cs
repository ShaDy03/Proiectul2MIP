namespace Proiectul2MIP.UI
{
    partial class Shop
    {
        private Common Data = Common.Instance;
        private MyCart Cart = MyCart.Instance;
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
            this.MyProfileBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.RoleLBL = new System.Windows.Forms.Label();
            this.UserNameLBL = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.UserOnlineBtn = new System.Windows.Forms.Button();
            this.AddProdusToShopBtn = new System.Windows.Forms.Button();
            this.ShowUsersBtn = new System.Windows.Forms.Button();
            this.HistoryShoppingBtn = new System.Windows.Forms.Button();
            this.ShowShoppingBtn = new System.Windows.Forms.Button();
            this.AddProdusBtn = new System.Windows.Forms.Button();
            this.ProdusListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.AddProdusMyOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.TotalLBL = new System.Windows.Forms.Label();
            this.UserAccount.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserAccount
            // 
            this.UserAccount.BackColor = System.Drawing.Color.Cornsilk;
            this.UserAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserAccount.Controls.Add(this.MyProfileBtn);
            this.UserAccount.Controls.Add(this.LogOutBtn);
            this.UserAccount.Controls.Add(this.RoleLBL);
            this.UserAccount.Controls.Add(this.UserNameLBL);
            this.UserAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserAccount.Location = new System.Drawing.Point(741, 12);
            this.UserAccount.Name = "UserAccount";
            this.UserAccount.Size = new System.Drawing.Size(306, 141);
            this.UserAccount.TabIndex = 0;
            // 
            // MyProfileBtn
            // 
            this.MyProfileBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MyProfileBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MyProfileBtn.Location = new System.Drawing.Point(3, 46);
            this.MyProfileBtn.Name = "MyProfileBtn";
            this.MyProfileBtn.Size = new System.Drawing.Size(296, 44);
            this.MyProfileBtn.TabIndex = 3;
            this.MyProfileBtn.Text = "Profile";
            this.MyProfileBtn.UseVisualStyleBackColor = false;
            this.MyProfileBtn.Click += new System.EventHandler(this.MyProfileBtn_Click);
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
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_ClickAsync);
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
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.MenuPanel.Controls.Add(this.UserOnlineBtn);
            this.MenuPanel.Controls.Add(this.AddProdusToShopBtn);
            this.MenuPanel.Controls.Add(this.ShowUsersBtn);
            this.MenuPanel.Controls.Add(this.HistoryShoppingBtn);
            this.MenuPanel.Controls.Add(this.ShowShoppingBtn);
            this.MenuPanel.Controls.Add(this.AddProdusBtn);
            this.MenuPanel.Location = new System.Drawing.Point(23, 12);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(717, 141);
            this.MenuPanel.TabIndex = 1;
            // 
            // UserOnlineBtn
            // 
            this.UserOnlineBtn.BackColor = System.Drawing.Color.HotPink;
            this.UserOnlineBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UserOnlineBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserOnlineBtn.Location = new System.Drawing.Point(628, 1);
            this.UserOnlineBtn.Name = "UserOnlineBtn";
            this.UserOnlineBtn.Size = new System.Drawing.Size(84, 135);
            this.UserOnlineBtn.TabIndex = 5;
            this.UserOnlineBtn.Text = "User Online (Admin)";
            this.UserOnlineBtn.UseVisualStyleBackColor = false;
            this.UserOnlineBtn.Click += new System.EventHandler(this.UserOnlineBtn_Click);
            // 
            // AddProdusToShopBtn
            // 
            this.AddProdusToShopBtn.BackColor = System.Drawing.Color.HotPink;
            this.AddProdusToShopBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AddProdusToShopBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddProdusToShopBtn.Location = new System.Drawing.Point(378, 0);
            this.AddProdusToShopBtn.Name = "AddProdusToShopBtn";
            this.AddProdusToShopBtn.Size = new System.Drawing.Size(119, 135);
            this.AddProdusToShopBtn.TabIndex = 4;
            this.AddProdusToShopBtn.Text = "Add Produs (Admin)";
            this.AddProdusToShopBtn.UseVisualStyleBackColor = false;
            this.AddProdusToShopBtn.Click += new System.EventHandler(this.AddProdusToShopBtn_Click);
            // 
            // ShowUsersBtn
            // 
            this.ShowUsersBtn.BackColor = System.Drawing.Color.HotPink;
            this.ShowUsersBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ShowUsersBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowUsersBtn.Location = new System.Drawing.Point(128, 3);
            this.ShowUsersBtn.Name = "ShowUsersBtn";
            this.ShowUsersBtn.Size = new System.Drawing.Size(119, 135);
            this.ShowUsersBtn.TabIndex = 3;
            this.ShowUsersBtn.Text = "Show Users (Admin)";
            this.ShowUsersBtn.UseVisualStyleBackColor = false;
            this.ShowUsersBtn.Click += new System.EventHandler(this.ShowUsersBtn_Click);
            // 
            // HistoryShoppingBtn
            // 
            this.HistoryShoppingBtn.BackColor = System.Drawing.Color.Gold;
            this.HistoryShoppingBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HistoryShoppingBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HistoryShoppingBtn.Location = new System.Drawing.Point(503, 0);
            this.HistoryShoppingBtn.Name = "HistoryShoppingBtn";
            this.HistoryShoppingBtn.Size = new System.Drawing.Size(119, 135);
            this.HistoryShoppingBtn.TabIndex = 2;
            this.HistoryShoppingBtn.Text = "History shopping";
            this.HistoryShoppingBtn.UseVisualStyleBackColor = false;
            this.HistoryShoppingBtn.Click += new System.EventHandler(this.HistoryShoppingBtn_Click);
            // 
            // ShowShoppingBtn
            // 
            this.ShowShoppingBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.ShowShoppingBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ShowShoppingBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowShoppingBtn.Location = new System.Drawing.Point(253, 1);
            this.ShowShoppingBtn.Name = "ShowShoppingBtn";
            this.ShowShoppingBtn.Size = new System.Drawing.Size(119, 135);
            this.ShowShoppingBtn.TabIndex = 1;
            this.ShowShoppingBtn.Text = "Show my cart";
            this.ShowShoppingBtn.UseVisualStyleBackColor = false;
            this.ShowShoppingBtn.Click += new System.EventHandler(this.ShowShoppingBtn_Click);
            // 
            // AddProdusBtn
            // 
            this.AddProdusBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AddProdusBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AddProdusBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddProdusBtn.Location = new System.Drawing.Point(3, 3);
            this.AddProdusBtn.Name = "AddProdusBtn";
            this.AddProdusBtn.Size = new System.Drawing.Size(119, 135);
            this.AddProdusBtn.TabIndex = 0;
            this.AddProdusBtn.Text = "Add Produs in Order";
            this.AddProdusBtn.UseVisualStyleBackColor = false;
            // 
            // ProdusListBox
            // 
            this.ProdusListBox.BackColor = System.Drawing.Color.YellowGreen;
            this.ProdusListBox.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ProdusListBox.FormattingEnabled = true;
            this.ProdusListBox.ItemHeight = 32;
            this.ProdusListBox.Location = new System.Drawing.Point(26, 166);
            this.ProdusListBox.Name = "ProdusListBox";
            this.ProdusListBox.Size = new System.Drawing.Size(301, 356);
            this.ProdusListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Index Produs";
            // 
            // IndexBox
            // 
            this.IndexBox.BackColor = System.Drawing.Color.Wheat;
            this.IndexBox.Location = new System.Drawing.Point(371, 249);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(256, 26);
            this.IndexBox.TabIndex = 9;
            this.IndexBox.TextChanged += new System.EventHandler(this.IndexBox_TextChanged);
            // 
            // AddProdusMyOrder
            // 
            this.AddProdusMyOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddProdusMyOrder.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AddProdusMyOrder.Location = new System.Drawing.Point(464, 413);
            this.AddProdusMyOrder.Name = "AddProdusMyOrder";
            this.AddProdusMyOrder.Size = new System.Drawing.Size(316, 44);
            this.AddProdusMyOrder.TabIndex = 8;
            this.AddProdusMyOrder.Text = "Add Produs In My Order";
            this.AddProdusMyOrder.UseVisualStyleBackColor = false;
            this.AddProdusMyOrder.Click += new System.EventHandler(this.AddProdusMyOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(714, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantity";
            // 
            // QuantityBox
            // 
            this.QuantityBox.BackColor = System.Drawing.Color.Wheat;
            this.QuantityBox.Location = new System.Drawing.Point(633, 249);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(256, 26);
            this.QuantityBox.TabIndex = 11;
            this.QuantityBox.TextChanged += new System.EventHandler(this.QuantityBox_TextChanged);
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Pristina", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(506, 302);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(245, 37);
            this.TotalPrice.TabIndex = 14;
            this.TotalPrice.Text = "Total For This Produs";
            // 
            // TotalLBL
            // 
            this.TotalLBL.AutoSize = true;
            this.TotalLBL.BackColor = System.Drawing.Color.DarkKhaki;
            this.TotalLBL.Font = new System.Drawing.Font("Pristina", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLBL.Location = new System.Drawing.Point(588, 339);
            this.TotalLBL.Name = "TotalLBL";
            this.TotalLBL.Size = new System.Drawing.Size(67, 37);
            this.TotalLBL.TabIndex = 15;
            this.TotalLBL.Text = "0 Lei";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1059, 535);
            this.Controls.Add(this.TotalLBL);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.AddProdusMyOrder);
            this.Controls.Add(this.ProdusListBox);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.UserAccount);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.UserAccount.ResumeLayout(false);
            this.UserAccount.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserAccount;
        private System.Windows.Forms.Button MyProfileBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label RoleLBL;
        private System.Windows.Forms.Label UserNameLBL;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button AddProdusToShopBtn;
        private System.Windows.Forms.Button ShowUsersBtn;
        private System.Windows.Forms.Button HistoryShoppingBtn;
        private System.Windows.Forms.Button ShowShoppingBtn;
        private System.Windows.Forms.Button AddProdusBtn;
        private System.Windows.Forms.Button UserOnlineBtn;
        private System.Windows.Forms.ListBox ProdusListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Button AddProdusMyOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label TotalLBL;
    }
}