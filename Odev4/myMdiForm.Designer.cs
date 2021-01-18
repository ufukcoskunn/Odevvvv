
namespace Odev4
{
    partial class myMdiForm
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
            this.ogrenciKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogretmenKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciKayıtToolStripMenuItem,
            this.ogretmenKayıtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciKayıtToolStripMenuItem
            // 
            this.ogrenciKayıtToolStripMenuItem.Name = "ogrenciKayıtToolStripMenuItem";
            this.ogrenciKayıtToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.ogrenciKayıtToolStripMenuItem.Text = "Ogrenci Kayıt";
            this.ogrenciKayıtToolStripMenuItem.Click += new System.EventHandler(this.ogrenciKayıtToolStripMenuItem_Click);
            // 
            // ogretmenKayıtToolStripMenuItem
            // 
            this.ogretmenKayıtToolStripMenuItem.Name = "ogretmenKayıtToolStripMenuItem";
            this.ogretmenKayıtToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.ogretmenKayıtToolStripMenuItem.Text = "Ogretmen Kayıt";
            this.ogretmenKayıtToolStripMenuItem.Click += new System.EventHandler(this.ogretmenKayıtToolStripMenuItem_Click);
            // 
            // myMdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myMdiForm";
            this.Text = "myMdiForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ogrenciKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogretmenKayıtToolStripMenuItem;
    }
}