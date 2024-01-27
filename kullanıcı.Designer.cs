// 210229027 Abdullah_Yilmaz

namespace _6012024
{
    partial class kullanıcı
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doğrulamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hesabıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Araç ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 384);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem1
            // 
            this.ayarlarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doğrulamaToolStripMenuItem1,
            this.hesabıSilToolStripMenuItem});
            this.ayarlarToolStripMenuItem1.Name = "ayarlarToolStripMenuItem1";
            this.ayarlarToolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.ayarlarToolStripMenuItem1.Text = "ayarlar";
            // 
            // doğrulamaToolStripMenuItem1
            // 
            this.doğrulamaToolStripMenuItem1.Name = "doğrulamaToolStripMenuItem1";
            this.doğrulamaToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.doğrulamaToolStripMenuItem1.Text = "doğrulama";
            this.doğrulamaToolStripMenuItem1.Click += new System.EventHandler(this.doğrulamaToolStripMenuItem1_Click);
            // 
            // hesabıSilToolStripMenuItem
            // 
            this.hesabıSilToolStripMenuItem.Name = "hesabıSilToolStripMenuItem";
            this.hesabıSilToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.hesabıSilToolStripMenuItem.Text = "Hesabı sil";
            this.hesabıSilToolStripMenuItem.Click += new System.EventHandler(this.hesabıSilToolStripMenuItem_Click);
            // 
            // kullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 523);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kullanıcı";
            this.Text = "kullanıcı";
            this.Load += new System.EventHandler(this.kullanıcı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doğrulamaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hesabıSilToolStripMenuItem;
    }
}