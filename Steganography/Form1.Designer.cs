namespace Steganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenImageFileButton = new System.Windows.Forms.Button();
            this.OpenTextFileButton = new System.Windows.Forms.Button();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ImageFilePath = new System.Windows.Forms.TextBox();
            this.TextFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OpenImageFileButton
            // 
            this.OpenImageFileButton.Location = new System.Drawing.Point(456, 41);
            this.OpenImageFileButton.Name = "OpenImageFileButton";
            this.OpenImageFileButton.Size = new System.Drawing.Size(35, 24);
            this.OpenImageFileButton.TabIndex = 1;
            this.OpenImageFileButton.Text = "...";
            this.OpenImageFileButton.UseVisualStyleBackColor = true;
            this.OpenImageFileButton.Click += new System.EventHandler(this.OpenImageFileButton_Click);
            // 
            // OpenTextFileButton
            // 
            this.OpenTextFileButton.Location = new System.Drawing.Point(456, 93);
            this.OpenTextFileButton.Name = "OpenTextFileButton";
            this.OpenTextFileButton.Size = new System.Drawing.Size(35, 24);
            this.OpenTextFileButton.TabIndex = 2;
            this.OpenTextFileButton.Text = "...";
            this.OpenTextFileButton.UseVisualStyleBackColor = true;
            this.OpenTextFileButton.Click += new System.EventHandler(this.OpenTextFileButton_Click);
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(272, 200);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(75, 23);
            this.EncodeButton.TabIndex = 3;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(353, 200);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(75, 23);
            this.DecodeButton.TabIndex = 4;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(452, 200);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ImageFilePath
            // 
            this.ImageFilePath.Location = new System.Drawing.Point(293, 44);
            this.ImageFilePath.Name = "ImageFilePath";
            this.ImageFilePath.Size = new System.Drawing.Size(157, 20);
            this.ImageFilePath.TabIndex = 6;
            // 
            // TextFilePath
            // 
            this.TextFilePath.Location = new System.Drawing.Point(293, 97);
            this.TextFilePath.Name = "TextFilePath";
            this.TextFilePath.Size = new System.Drawing.Size(157, 20);
            this.TextFilePath.TabIndex = 7;
            this.TextFilePath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Image File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Text File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Image Preview";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(269, 71);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 235);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextFilePath);
            this.Controls.Add(this.ImageFilePath);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.OpenTextFileButton);
            this.Controls.Add(this.OpenImageFileButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OpenImageFileButton;
        private System.Windows.Forms.Button OpenTextFileButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox ImageFilePath;
        private System.Windows.Forms.TextBox TextFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

