
namespace WindowsFormsApp1
{
    partial class PlayfairCipherPage
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
            this.playfairCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPCUpload = new System.Windows.Forms.Button();
            this.btnPCSave = new System.Windows.Forms.Button();
            this.btnPCEncrypt = new System.Windows.Forms.Button();
            this.btnPCDecrpyt = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playfairCipherToolStripMenuItem,
            this.rSAToolStripMenuItem,
            this.cFBToolStripMenuItem,
            this.sHA256ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playfairCipherToolStripMenuItem
            // 
            this.playfairCipherToolStripMenuItem.Name = "playfairCipherToolStripMenuItem";
            this.playfairCipherToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.playfairCipherToolStripMenuItem.Text = "A5/1";
            this.playfairCipherToolStripMenuItem.Click += new System.EventHandler(this.playfairCipherToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.rSAToolStripMenuItem.Text = "RSA";
            // 
            // cFBToolStripMenuItem
            // 
            this.cFBToolStripMenuItem.Name = "cFBToolStripMenuItem";
            this.cFBToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.cFBToolStripMenuItem.Text = "CFB";
            this.cFBToolStripMenuItem.Click += new System.EventHandler(this.cFBToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 165);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(324, 99);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Plain text";
            // 
            // btnPCUpload
            // 
            this.btnPCUpload.Location = new System.Drawing.Point(134, 49);
            this.btnPCUpload.Name = "btnPCUpload";
            this.btnPCUpload.Size = new System.Drawing.Size(137, 33);
            this.btnPCUpload.TabIndex = 7;
            this.btnPCUpload.Text = "Upload from file";
            this.btnPCUpload.UseVisualStyleBackColor = true;
            // 
            // btnPCSave
            // 
            this.btnPCSave.Location = new System.Drawing.Point(316, 49);
            this.btnPCSave.Name = "btnPCSave";
            this.btnPCSave.Size = new System.Drawing.Size(142, 33);
            this.btnPCSave.TabIndex = 8;
            this.btnPCSave.Text = "Save file";
            this.btnPCSave.UseVisualStyleBackColor = true;
            // 
            // btnPCEncrypt
            // 
            this.btnPCEncrypt.Location = new System.Drawing.Point(134, 297);
            this.btnPCEncrypt.Name = "btnPCEncrypt";
            this.btnPCEncrypt.Size = new System.Drawing.Size(137, 33);
            this.btnPCEncrypt.TabIndex = 9;
            this.btnPCEncrypt.Text = "Encrypt";
            this.btnPCEncrypt.UseVisualStyleBackColor = true;
            this.btnPCEncrypt.Click += new System.EventHandler(this.btnPCEncrypt_Click);
            // 
            // btnPCDecrpyt
            // 
            this.btnPCDecrpyt.Location = new System.Drawing.Point(321, 297);
            this.btnPCDecrpyt.Name = "btnPCDecrpyt";
            this.btnPCDecrpyt.Size = new System.Drawing.Size(137, 33);
            this.btnPCDecrpyt.TabIndex = 10;
            this.btnPCDecrpyt.Text = "Decrypt";
            this.btnPCDecrpyt.UseVisualStyleBackColor = true;
            this.btnPCDecrpyt.Click += new System.EventHandler(this.btnPCDecrpyt_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 366);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(324, 83);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Result";
            // 
            // sHA256ToolStripMenuItem
            // 
            this.sHA256ToolStripMenuItem.Name = "sHA256ToolStripMenuItem";
            this.sHA256ToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sHA256ToolStripMenuItem.Text = "SHA256";
            this.sHA256ToolStripMenuItem.Click += new System.EventHandler(this.sHA256ToolStripMenuItem_Click);
            // 
            // PlayfairCipherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnPCDecrpyt);
            this.Controls.Add(this.btnPCEncrypt);
            this.Controls.Add(this.btnPCSave);
            this.Controls.Add(this.btnPCUpload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PlayfairCipherPage";
            this.Text = "PlayfairCipherPage";
            this.Load += new System.EventHandler(this.PlayfairCipherPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playfairCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFBToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPCUpload;
        private System.Windows.Forms.Button btnPCSave;
        private System.Windows.Forms.Button btnPCEncrypt;
        private System.Windows.Forms.Button btnPCDecrpyt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem sHA256ToolStripMenuItem;
    }
}