
namespace WindowsFormsApp1
{
    partial class RSAPage
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
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.btnUploadFileRSA = new System.Windows.Forms.Button();
            this.btnSaveFileRSA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.a51ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playfairCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(63, 38);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(62, 22);
            this.tbP.TabIndex = 0;
            this.tbP.Text = "23";
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(196, 38);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(62, 22);
            this.tbQ.TabIndex = 1;
            this.tbQ.Text = "13";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(302, 38);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(62, 22);
            this.tbE.TabIndex = 2;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(396, 38);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(62, 22);
            this.tbD.TabIndex = 3;
            // 
            // btnUploadFileRSA
            // 
            this.btnUploadFileRSA.Location = new System.Drawing.Point(150, 344);
            this.btnUploadFileRSA.Name = "btnUploadFileRSA";
            this.btnUploadFileRSA.Size = new System.Drawing.Size(96, 44);
            this.btnUploadFileRSA.TabIndex = 4;
            this.btnUploadFileRSA.Text = "Upload file";
            this.btnUploadFileRSA.UseVisualStyleBackColor = true;
            this.btnUploadFileRSA.Click += new System.EventHandler(this.btnUploadFileRSA_Click);
            // 
            // btnSaveFileRSA
            // 
            this.btnSaveFileRSA.Location = new System.Drawing.Point(252, 344);
            this.btnSaveFileRSA.Name = "btnSaveFileRSA";
            this.btnSaveFileRSA.Size = new System.Drawing.Size(96, 44);
            this.btnSaveFileRSA.TabIndex = 5;
            this.btnSaveFileRSA.Text = "Save file";
            this.btnSaveFileRSA.UseVisualStyleBackColor = true;
            this.btnSaveFileRSA.Click += new System.EventHandler(this.btnSaveFileRSA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "e:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "d:";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(131, 68);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(421, 112);
            this.tbMessage.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "n:";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(490, 40);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(62, 22);
            this.tbN.TabIndex = 12;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(131, 199);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(421, 111);
            this.tbResult.TabIndex = 13;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(16, 344);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(96, 44);
            this.btnGenerateKey.TabIndex = 14;
            this.btnGenerateKey.Text = "Generate key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Encrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a51ToolStripMenuItem,
            this.playfairCipherToolStripMenuItem,
            this.cFBToolStripMenuItem,
            this.sHA256ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 28);
            this.menuStrip1.TabIndex = 17;
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
            // cFBToolStripMenuItem
            // 
            this.cFBToolStripMenuItem.Name = "cFBToolStripMenuItem";
            this.cFBToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.cFBToolStripMenuItem.Text = "CFB";
            this.cFBToolStripMenuItem.Click += new System.EventHandler(this.cFBToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Message:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Result:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(629, 68);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 112);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(641, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "uplodaded picture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(854, 160);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 131);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(866, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "encrypted picture";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(645, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "decrypted picture";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(629, 257);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 131);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(868, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 41);
            this.button3.TabIndex = 26;
            this.button3.Text = "Encrypt bmp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(869, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 41);
            this.button4.TabIndex = 27;
            this.button4.Text = "Decrypt bmp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sHA256ToolStripMenuItem
            // 
            this.sHA256ToolStripMenuItem.Name = "sHA256ToolStripMenuItem";
            this.sHA256ToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sHA256ToolStripMenuItem.Text = "SHA256";
            this.sHA256ToolStripMenuItem.Click += new System.EventHandler(this.sHA256ToolStripMenuItem_Click);
            // 
            // RSAPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 422);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveFileRSA);
            this.Controls.Add(this.btnUploadFileRSA);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.tbP);
            this.Name = "RSAPage";
            this.Text = "RSA + BMP";
            this.Load += new System.EventHandler(this.RSAPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Button btnUploadFileRSA;
        private System.Windows.Forms.Button btnSaveFileRSA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem a51ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playfairCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFBToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem sHA256ToolStripMenuItem;
    }
}