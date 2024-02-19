
namespace WindowsFormsApp1
{
    partial class CFBPage
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
            this.tbCFBKey = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCFBUploadFile = new System.Windows.Forms.Button();
            this.btnCFBSaveFile = new System.Windows.Forms.Button();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCFBDecrypt = new System.Windows.Forms.Button();
            this.btnCFBEncrypt = new System.Windows.Forms.Button();
            this.tbCFBResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.sHA256ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 28);
            this.menuStrip1.TabIndex = 1;
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
            // tbCFBKey
            // 
            this.tbCFBKey.Location = new System.Drawing.Point(115, 55);
            this.tbCFBKey.Name = "tbCFBKey";
            this.tbCFBKey.Size = new System.Drawing.Size(518, 22);
            this.tbCFBKey.TabIndex = 2;
            this.tbCFBKey.Text = "1110011011101100110110100001001001000000011000001100001011100111";
            this.tbCFBKey.TextChanged += new System.EventHandler(this.tbCFBKey_TextChanged);
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(55, 58);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(36, 17);
            this.lbKey.TabIndex = 3;
            this.lbKey.Text = "Key:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 94);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message:";
            // 
            // btnCFBUploadFile
            // 
            this.btnCFBUploadFile.Location = new System.Drawing.Point(115, 396);
            this.btnCFBUploadFile.Name = "btnCFBUploadFile";
            this.btnCFBUploadFile.Size = new System.Drawing.Size(112, 43);
            this.btnCFBUploadFile.TabIndex = 6;
            this.btnCFBUploadFile.Text = "Upload file";
            this.btnCFBUploadFile.UseVisualStyleBackColor = true;
            this.btnCFBUploadFile.Click += new System.EventHandler(this.btnCFBUploadFile_Click);
            // 
            // btnCFBSaveFile
            // 
            this.btnCFBSaveFile.Location = new System.Drawing.Point(250, 396);
            this.btnCFBSaveFile.Name = "btnCFBSaveFile";
            this.btnCFBSaveFile.Size = new System.Drawing.Size(112, 43);
            this.btnCFBSaveFile.TabIndex = 7;
            this.btnCFBSaveFile.Text = "Save file";
            this.btnCFBSaveFile.UseVisualStyleBackColor = true;
            this.btnCFBSaveFile.Click += new System.EventHandler(this.btnCFBSaveFile_Click);
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(115, 106);
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(518, 22);
            this.tbIV.TabIndex = 8;
            this.tbIV.TextChanged += new System.EventHandler(this.tbIV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "IV:";
            // 
            // btnCFBDecrypt
            // 
            this.btnCFBDecrypt.Location = new System.Drawing.Point(521, 396);
            this.btnCFBDecrypt.Name = "btnCFBDecrypt";
            this.btnCFBDecrypt.Size = new System.Drawing.Size(112, 43);
            this.btnCFBDecrypt.TabIndex = 10;
            this.btnCFBDecrypt.Text = "Decrypt";
            this.btnCFBDecrypt.UseVisualStyleBackColor = true;
            this.btnCFBDecrypt.Click += new System.EventHandler(this.btnCFBDecrypt_Click);
            // 
            // btnCFBEncrypt
            // 
            this.btnCFBEncrypt.Location = new System.Drawing.Point(383, 396);
            this.btnCFBEncrypt.Name = "btnCFBEncrypt";
            this.btnCFBEncrypt.Size = new System.Drawing.Size(112, 43);
            this.btnCFBEncrypt.TabIndex = 11;
            this.btnCFBEncrypt.Text = "Encrypt";
            this.btnCFBEncrypt.UseVisualStyleBackColor = true;
            this.btnCFBEncrypt.Click += new System.EventHandler(this.btnCFBEncrypt_Click);
            // 
            // tbCFBResult
            // 
            this.tbCFBResult.Location = new System.Drawing.Point(115, 279);
            this.tbCFBResult.Multiline = true;
            this.tbCFBResult.Name = "tbCFBResult";
            this.tbCFBResult.Size = new System.Drawing.Size(518, 94);
            this.tbCFBResult.TabIndex = 12;
            this.tbCFBResult.TextChanged += new System.EventHandler(this.tbCFBResult_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Using A5/1 algorithm";
            // 
            // sHA256ToolStripMenuItem
            // 
            this.sHA256ToolStripMenuItem.Name = "sHA256ToolStripMenuItem";
            this.sHA256ToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sHA256ToolStripMenuItem.Text = "SHA256";
            this.sHA256ToolStripMenuItem.Click += new System.EventHandler(this.sHA256ToolStripMenuItem_Click);
            // 
            // CFBPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCFBResult);
            this.Controls.Add(this.btnCFBEncrypt);
            this.Controls.Add(this.btnCFBDecrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIV);
            this.Controls.Add(this.btnCFBSaveFile);
            this.Controls.Add(this.btnCFBUploadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.tbCFBKey);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CFBPage";
            this.Text = "CFB";
            this.Load += new System.EventHandler(this.CFBPage_Load);
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
        private System.Windows.Forms.TextBox tbCFBKey;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCFBUploadFile;
        private System.Windows.Forms.Button btnCFBSaveFile;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCFBDecrypt;
        private System.Windows.Forms.Button btnCFBEncrypt;
        private System.Windows.Forms.TextBox tbCFBResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem sHA256ToolStripMenuItem;
    }
}