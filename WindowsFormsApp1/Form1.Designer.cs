
namespace WindowsFormsApp1
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
            this.a51ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playfairCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a51ToolStripMenuItem,
            this.playfairCipherToolStripMenuItem,
            this.rSAToolStripMenuItem,
            this.cFBToolStripMenuItem,
            this.sHA256ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // a51ToolStripMenuItem
            // 
            this.a51ToolStripMenuItem.Name = "a51ToolStripMenuItem";
            this.a51ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.a51ToolStripMenuItem.Text = "A5/1";
            this.a51ToolStripMenuItem.Click += new System.EventHandler(this.a51ToolStripMenuItem_Click);
            // 
            // playfairCipherToolStripMenuItem
            // 
            this.playfairCipherToolStripMenuItem.Name = "playfairCipherToolStripMenuItem";
            this.playfairCipherToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.playfairCipherToolStripMenuItem.Text = "Playfair Cipher";
            this.playfairCipherToolStripMenuItem.Click += new System.EventHandler(this.playfairCipherToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // cFBToolStripMenuItem
            // 
            this.cFBToolStripMenuItem.Name = "cFBToolStripMenuItem";
            this.cFBToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.cFBToolStripMenuItem.Text = "CFB";
            this.cFBToolStripMenuItem.Click += new System.EventHandler(this.cFBToolStripMenuItem_Click);
            // 
            // sHA256ToolStripMenuItem
            // 
            this.sHA256ToolStripMenuItem.Name = "sHA256ToolStripMenuItem";
            this.sHA256ToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sHA256ToolStripMenuItem.Text = "SHA256";
            this.sHA256ToolStripMenuItem.Click += new System.EventHandler(this.sHA256ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 451);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem a51ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playfairCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA256ToolStripMenuItem;
    }
}

