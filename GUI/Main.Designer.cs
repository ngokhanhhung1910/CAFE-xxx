namespace GUI
{
    partial class Main
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.lblLogoCaFe = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pnlOrderManagement = new System.Windows.Forms.Panel();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.pnlDrinksManagement = new System.Windows.Forms.Panel();
            this.btnDrinksManagement = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlOrderManagement.SuspendLayout();
            this.pnlDrinksManagement.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlFunction);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(150, 588);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlFunction
            // 
            this.pnlFunction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFunction.Controls.Add(this.lblLogoCaFe);
            this.pnlFunction.Controls.Add(this.pnlHistory);
            this.pnlFunction.Controls.Add(this.pnlOrderManagement);
            this.pnlFunction.Controls.Add(this.pnlDrinksManagement);
            this.pnlFunction.Location = new System.Drawing.Point(0, 2);
            this.pnlFunction.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(150, 500);
            this.pnlFunction.TabIndex = 0;
            // 
            // lblLogoCaFe
            // 
            this.lblLogoCaFe.AutoSize = true;
            this.lblLogoCaFe.Font = new System.Drawing.Font("Matura MT Script Capitals", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoCaFe.Location = new System.Drawing.Point(6, 17);
            this.lblLogoCaFe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogoCaFe.Name = "lblLogoCaFe";
            this.lblLogoCaFe.Size = new System.Drawing.Size(138, 50);
            this.lblLogoCaFe.TabIndex = 0;
            this.lblLogoCaFe.Text = "CAFE\r\n  Cà Là Phê";
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.btnHistory);
            this.pnlHistory.Location = new System.Drawing.Point(0, 244);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(150, 81);
            this.pnlHistory.TabIndex = 3;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistory.Location = new System.Drawing.Point(0, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(150, 81);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // pnlOrderManagement
            // 
            this.pnlOrderManagement.Controls.Add(this.btnOrderManagement);
            this.pnlOrderManagement.Location = new System.Drawing.Point(0, 162);
            this.pnlOrderManagement.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOrderManagement.Name = "pnlOrderManagement";
            this.pnlOrderManagement.Size = new System.Drawing.Size(150, 81);
            this.pnlOrderManagement.TabIndex = 2;
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrderManagement.Location = new System.Drawing.Point(0, 0);
            this.btnOrderManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(150, 81);
            this.btnOrderManagement.TabIndex = 1;
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // pnlDrinksManagement
            // 
            this.pnlDrinksManagement.Controls.Add(this.btnDrinksManagement);
            this.pnlDrinksManagement.Location = new System.Drawing.Point(0, 81);
            this.pnlDrinksManagement.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDrinksManagement.Name = "pnlDrinksManagement";
            this.pnlDrinksManagement.Size = new System.Drawing.Size(150, 81);
            this.pnlDrinksManagement.TabIndex = 1;
            // 
            // btnDrinksManagement
            // 
            this.btnDrinksManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDrinksManagement.Location = new System.Drawing.Point(0, 0);
            this.btnDrinksManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrinksManagement.Name = "btnDrinksManagement";
            this.btnDrinksManagement.Size = new System.Drawing.Size(150, 81);
            this.btnDrinksManagement.TabIndex = 1;
            this.btnDrinksManagement.Text = "Drinks Management";
            this.btnDrinksManagement.UseVisualStyleBackColor = true;
            this.btnDrinksManagement.Click += new System.EventHandler(this.btnDrinksManagement_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(150, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1037, 588);
            this.pnlMain.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.anh_cafe_20;
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 588);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "CAFE";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlFunction.ResumeLayout(false);
            this.pnlFunction.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            this.pnlOrderManagement.ResumeLayout(false);
            this.pnlDrinksManagement.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLogoCaFe;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel pnlOrderManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Panel pnlDrinksManagement;
        private System.Windows.Forms.Button btnDrinksManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}