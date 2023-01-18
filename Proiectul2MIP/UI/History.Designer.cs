namespace Proiectul2MIP.UI
{
    partial class History
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
            this.MyHistoryOrder = new System.Windows.Forms.ListBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyHistoryOrder
            // 
            this.MyHistoryOrder.BackColor = System.Drawing.Color.YellowGreen;
            this.MyHistoryOrder.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MyHistoryOrder.FormattingEnabled = true;
            this.MyHistoryOrder.ItemHeight = 32;
            this.MyHistoryOrder.Location = new System.Drawing.Point(13, 13);
            this.MyHistoryOrder.Name = "MyHistoryOrder";
            this.MyHistoryOrder.Size = new System.Drawing.Size(507, 420);
            this.MyHistoryOrder.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HomeBtn.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HomeBtn.Location = new System.Drawing.Point(526, 199);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(267, 44);
            this.HomeBtn.TabIndex = 5;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.MyHistoryOrder);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MyHistoryOrder;
        private System.Windows.Forms.Button HomeBtn;
    }
}