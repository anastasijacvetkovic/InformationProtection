
namespace WindowsFormsApp1
{
    partial class A51Page
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
            this.sHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOFA51 = new System.Windows.Forms.Button();
            this.btnCryptA51 = new System.Windows.Forms.Button();
            this.tbKeyA51 = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbResultA51 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(566, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // btnOFA51
            // 
            this.btnOFA51.Location = new System.Drawing.Point(39, 73);
            this.btnOFA51.Name = "btnOFA51";
            this.btnOFA51.Size = new System.Drawing.Size(112, 52);
            this.btnOFA51.TabIndex = 2;
            this.btnOFA51.Text = "Upload file";
            this.btnOFA51.UseVisualStyleBackColor = true;
            this.btnOFA51.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCryptA51
            // 
            this.btnCryptA51.Location = new System.Drawing.Point(288, 73);
            this.btnCryptA51.Name = "btnCryptA51";
            this.btnCryptA51.Size = new System.Drawing.Size(115, 52);
            this.btnCryptA51.TabIndex = 3;
            this.btnCryptA51.Text = "Encrypt";
            this.btnCryptA51.UseVisualStyleBackColor = true;
            this.btnCryptA51.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbKeyA51
            // 
            this.tbKeyA51.Location = new System.Drawing.Point(122, 151);
            this.tbKeyA51.Name = "tbKeyA51";
            this.tbKeyA51.Size = new System.Drawing.Size(406, 22);
            this.tbKeyA51.TabIndex = 4;
            this.tbKeyA51.Text = "0011110010101110101100010101110101111110010110101111011110110100";
            this.tbKeyA51.TextChanged += new System.EventHandler(this.tbKeyA51_TextChanged);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(122, 200);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(406, 92);
            this.tbMessage.TabIndex = 5;
            // 
            // tbResultA51
            // 
            this.tbResultA51.Location = new System.Drawing.Point(122, 318);
            this.tbResultA51.Multiline = true;
            this.tbResultA51.Name = "tbResultA51";
            this.tbResultA51.Size = new System.Drawing.Size(406, 92);
            this.tbResultA51.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(60, 154);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 17);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // A51Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tbResultA51);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbKeyA51);
            this.Controls.Add(this.btnCryptA51);
            this.Controls.Add(this.btnOFA51);
            this.Controls.Add(this.menuStrip1);
            this.Name = "A51Page";
            this.Text = "A51Page";
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
        private System.Windows.Forms.Button btnOFA51;
        private System.Windows.Forms.Button btnCryptA51;
        private System.Windows.Forms.TextBox tbKeyA51;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbResultA51;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem sHA256ToolStripMenuItem;
    }
}