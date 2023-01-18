namespace Proiectul2MIP.UI
{
    partial class AddProdus
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
            this.NameProdusLBL = new System.Windows.Forms.Label();
            this.QuantityLBL = new System.Windows.Forms.Label();
            this.PriceLBL = new System.Windows.Forms.Label();
            this.DescriptionLBL = new System.Windows.Forms.Label();
            this.NameProdusBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.AddProdusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameProdusLBL
            // 
            this.NameProdusLBL.AutoSize = true;
            this.NameProdusLBL.BackColor = System.Drawing.Color.Coral;
            this.NameProdusLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NameProdusLBL.Location = new System.Drawing.Point(42, 81);
            this.NameProdusLBL.Name = "NameProdusLBL";
            this.NameProdusLBL.Size = new System.Drawing.Size(153, 32);
            this.NameProdusLBL.TabIndex = 7;
            this.NameProdusLBL.Text = "Name of Produs";
            // 
            // QuantityLBL
            // 
            this.QuantityLBL.AutoSize = true;
            this.QuantityLBL.BackColor = System.Drawing.Color.Coral;
            this.QuantityLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.QuantityLBL.Location = new System.Drawing.Point(42, 150);
            this.QuantityLBL.Name = "QuantityLBL";
            this.QuantityLBL.Size = new System.Drawing.Size(93, 32);
            this.QuantityLBL.TabIndex = 8;
            this.QuantityLBL.Text = "Quantity";
            // 
            // PriceLBL
            // 
            this.PriceLBL.AutoSize = true;
            this.PriceLBL.BackColor = System.Drawing.Color.Coral;
            this.PriceLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PriceLBL.Location = new System.Drawing.Point(42, 224);
            this.PriceLBL.Name = "PriceLBL";
            this.PriceLBL.Size = new System.Drawing.Size(57, 32);
            this.PriceLBL.TabIndex = 9;
            this.PriceLBL.Text = "Price";
            // 
            // DescriptionLBL
            // 
            this.DescriptionLBL.AutoSize = true;
            this.DescriptionLBL.BackColor = System.Drawing.Color.Chartreuse;
            this.DescriptionLBL.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DescriptionLBL.Location = new System.Drawing.Point(42, 295);
            this.DescriptionLBL.Name = "DescriptionLBL";
            this.DescriptionLBL.Size = new System.Drawing.Size(110, 32);
            this.DescriptionLBL.TabIndex = 10;
            this.DescriptionLBL.Text = "Description";
            // 
            // NameProdusBox
            // 
            this.NameProdusBox.BackColor = System.Drawing.Color.Wheat;
            this.NameProdusBox.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NameProdusBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameProdusBox.Location = new System.Drawing.Point(220, 78);
            this.NameProdusBox.Name = "NameProdusBox";
            this.NameProdusBox.Size = new System.Drawing.Size(340, 39);
            this.NameProdusBox.TabIndex = 11;
            this.NameProdusBox.TextChanged += new System.EventHandler(this.NameProdusBox_TextChanged);
            // 
            // QuantityBox
            // 
            this.QuantityBox.BackColor = System.Drawing.Color.Wheat;
            this.QuantityBox.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.QuantityBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.QuantityBox.Location = new System.Drawing.Point(220, 150);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(340, 39);
            this.QuantityBox.TabIndex = 12;
            this.QuantityBox.TextChanged += new System.EventHandler(this.QuantityBox_TextChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.BackColor = System.Drawing.Color.Wheat;
            this.PriceBox.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PriceBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PriceBox.Location = new System.Drawing.Point(220, 224);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(340, 39);
            this.PriceBox.TabIndex = 13;
            this.PriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.Wheat;
            this.DescriptionBox.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DescriptionBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DescriptionBox.Location = new System.Drawing.Point(220, 292);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(340, 39);
            this.DescriptionBox.TabIndex = 14;
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.Color.Aquamarine;
            this.HomeBTN.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBTN.Location = new System.Drawing.Point(466, 358);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(177, 80);
            this.HomeBTN.TabIndex = 16;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = false;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // AddProdusBtn
            // 
            this.AddProdusBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.AddProdusBtn.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdusBtn.Location = new System.Drawing.Point(117, 358);
            this.AddProdusBtn.Name = "AddProdusBtn";
            this.AddProdusBtn.Size = new System.Drawing.Size(175, 80);
            this.AddProdusBtn.TabIndex = 15;
            this.AddProdusBtn.Text = "Add Produs";
            this.AddProdusBtn.UseVisualStyleBackColor = false;
            this.AddProdusBtn.Click += new System.EventHandler(this.AddProdusBtn_Click);
            // 
            // AddProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeBTN);
            this.Controls.Add(this.AddProdusBtn);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.NameProdusBox);
            this.Controls.Add(this.DescriptionLBL);
            this.Controls.Add(this.PriceLBL);
            this.Controls.Add(this.QuantityLBL);
            this.Controls.Add(this.NameProdusLBL);
            this.Name = "AddProdus";
            this.Text = "AddProdus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameProdusLBL;
        private System.Windows.Forms.Label QuantityLBL;
        private System.Windows.Forms.Label PriceLBL;
        private System.Windows.Forms.Label DescriptionLBL;
        private System.Windows.Forms.TextBox NameProdusBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button AddProdusBtn;
    }
}