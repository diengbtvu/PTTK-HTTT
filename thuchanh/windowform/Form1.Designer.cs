namespace windowform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuTrữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhToánThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hDSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hộKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.quậnHuyệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phườngXãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.lưuTrữToolStripMenuItem,
            this.traCứuToolStripMenuItem,
            this.tínhToánThốngKêToolStripMenuItem,
            this.kếtXuấtToolStripMenuItem,
            this.hDSDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // lưuTrữToolStripMenuItem
            // 
            this.lưuTrữToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hộKhẩuToolStripMenuItem,
            this.nhânKhẩuToolStripMenuItem,
            this.danhMụcToolStripMenuItem});
            this.lưuTrữToolStripMenuItem.Name = "lưuTrữToolStripMenuItem";
            this.lưuTrữToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.lưuTrữToolStripMenuItem.Text = "&Lưu trữ";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.traCứuToolStripMenuItem.Text = "&Tra Cứu";
            // 
            // tínhToánThốngKêToolStripMenuItem
            // 
            this.tínhToánThốngKêToolStripMenuItem.Name = "tínhToánThốngKêToolStripMenuItem";
            this.tínhToánThốngKêToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.tínhToánThốngKêToolStripMenuItem.Text = "Tính t&oán - thống kê";
            // 
            // kếtXuấtToolStripMenuItem
            // 
            this.kếtXuấtToolStripMenuItem.Name = "kếtXuấtToolStripMenuItem";
            this.kếtXuấtToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kếtXuấtToolStripMenuItem.Text = "&Kết xuất";
            // 
            // hDSDToolStripMenuItem
            // 
            this.hDSDToolStripMenuItem.Name = "hDSDToolStripMenuItem";
            this.hDSDToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hDSDToolStripMenuItem.Text = "H&DSD";
            // 
            // hộKhẩuToolStripMenuItem
            // 
            this.hộKhẩuToolStripMenuItem.Name = "hộKhẩuToolStripMenuItem";
            this.hộKhẩuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hộKhẩuToolStripMenuItem.Text = "Hộ khẩu";
            // 
            // nhânKhẩuToolStripMenuItem
            // 
            this.nhânKhẩuToolStripMenuItem.Name = "nhânKhẩuToolStripMenuItem";
            this.nhânKhẩuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhânKhẩuToolStripMenuItem.Text = "Nhân khẩu";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quậnHuyệnToolStripMenuItem,
            this.phườngXãToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // quậnHuyệnToolStripMenuItem
            // 
            this.quậnHuyệnToolStripMenuItem.Name = "quậnHuyệnToolStripMenuItem";
            this.quậnHuyệnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quậnHuyệnToolStripMenuItem.Text = "Quận huyện";
            this.quậnHuyệnToolStripMenuItem.Click += new System.EventHandler(this.quậnHuyệnToolStripMenuItem_Click);
            // 
            // phườngXãToolStripMenuItem
            // 
            this.phườngXãToolStripMenuItem.Name = "phườngXãToolStripMenuItem";
            this.phườngXãToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phườngXãToolStripMenuItem.Text = "Phường xã";
            this.phườngXãToolStripMenuItem.Click += new System.EventHandler(this.phườngXãToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý hộ tịch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuTrữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhToánThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hDSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hộKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quậnHuyệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phườngXãToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

