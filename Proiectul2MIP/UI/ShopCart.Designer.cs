namespace Proiectul2MIP.UI
{
    partial class ShopCart
    {
        private Common Data = Common.Instance;
        private MyCart MyCartO = MyCart.Instance;
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
            this.CartBox = new System.Windows.Forms.ListBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.DeleteProdus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.TotalLBL = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CartBox
            // 
            this.CartBox.BackColor = System.Drawing.Color.YellowGreen;
            this.CartBox.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CartBox.FormattingEnabled = true;
            this.CartBox.ItemHeight = 32;
            this.CartBox.Location = new System.Drawing.Point(12, 15);
            this.CartBox.Name = "CartBox";
            this.CartBox.Size = new System.Drawing.Size(454, 420);
            this.CartBox.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HomeBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HomeBtn.Location = new System.Drawing.Point(472, 15);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(316, 44);
            this.HomeBtn.TabIndex = 4;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // DeleteProdus
            // 
            this.DeleteProdus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DeleteProdus.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DeleteProdus.Location = new System.Drawing.Point(472, 380);
            this.DeleteProdus.Name = "DeleteProdus";
            this.DeleteProdus.Size = new System.Drawing.Size(316, 44);
            this.DeleteProdus.TabIndex = 5;
            this.DeleteProdus.Text = "Delete Prdus";
            this.DeleteProdus.UseVisualStyleBackColor = false;
            this.DeleteProdus.Click += new System.EventHandler(this.DeleteProdus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index Profile";
            // 
            // IndexBox
            // 
            this.IndexBox.BackColor = System.Drawing.Color.Wheat;
            this.IndexBox.Location = new System.Drawing.Point(472, 348);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(316, 26);
            this.IndexBox.TabIndex = 6;
            // 
            // TotalLBL
            // 
            this.TotalLBL.AutoSize = true;
            this.TotalLBL.Font = new System.Drawing.Font("Pristina", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLBL.Location = new System.Drawing.Point(472, 172);
            this.TotalLBL.Name = "TotalLBL";
            this.TotalLBL.Size = new System.Drawing.Size(153, 48);
            this.TotalLBL.TabIndex = 8;
            this.TotalLBL.Text = "Total: 0 lei";
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.OrderButton.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.OrderButton.Location = new System.Drawing.Point(472, 223);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(316, 44);
            this.OrderButton.TabIndex = 9;
            this.OrderButton.Text = "Send Order";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ShopCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.TotalLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.DeleteProdus);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.CartBox);
            this.Name = "ShopCart";
            this.Text = "ShopCart";
            this.Load += new System.EventHandler(this.ShopCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CartBox;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button DeleteProdus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Label TotalLBL;
        private System.Windows.Forms.Button OrderButton;
    }
}