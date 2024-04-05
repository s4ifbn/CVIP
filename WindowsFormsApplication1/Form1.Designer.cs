namespace WindowsFormsApplication1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeroOrderHoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstOrderHoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convulutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionOnImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageAlgebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageAdditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSubtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(594, 193);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original RGB Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result Image";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(546, 885);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 56);
            this.button6.TabIndex = 9;
            this.button6.Text = "Change";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(546, 843);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 32);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 847);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(502, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Brighness enter value between -255 and +255";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(786, 847);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = -255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(370, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.sizeChangeToolStripMenuItem,
            this.imageAlgebraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveResultImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveResultImageToolStripMenuItem
            // 
            this.saveResultImageToolStripMenuItem.Name = "saveResultImageToolStripMenuItem";
            this.saveResultImageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveResultImageToolStripMenuItem.Text = "Save Result Image";
            this.saveResultImageToolStripMenuItem.Click += new System.EventHandler(this.saveResultImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorConversionToolStripMenuItem,
            this.toBinaryToolStripMenuItem,
            this.changeBrightnessToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.editToolStripMenuItem.Text = "Color Chnage";
            // 
            // colorConversionToolStripMenuItem
            // 
            this.colorConversionToolStripMenuItem.Name = "colorConversionToolStripMenuItem";
            this.colorConversionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.colorConversionToolStripMenuItem.Text = "To Gray Level";
            this.colorConversionToolStripMenuItem.Click += new System.EventHandler(this.colorConversionToolStripMenuItem_Click);
            // 
            // toBinaryToolStripMenuItem
            // 
            this.toBinaryToolStripMenuItem.Name = "toBinaryToolStripMenuItem";
            this.toBinaryToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.toBinaryToolStripMenuItem.Text = "To Binary";
            this.toBinaryToolStripMenuItem.Click += new System.EventHandler(this.toBinaryToolStripMenuItem_Click);
            // 
            // changeBrightnessToolStripMenuItem
            // 
            this.changeBrightnessToolStripMenuItem.Name = "changeBrightnessToolStripMenuItem";
            this.changeBrightnessToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.changeBrightnessToolStripMenuItem.Text = "Change Brightness";
            // 
            // sizeChangeToolStripMenuItem
            // 
            this.sizeChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zeroOrderHoldToolStripMenuItem,
            this.firstOrderHoldToolStripMenuItem,
            this.convulutionToolStripMenuItem,
            this.convolutionOnImageToolStripMenuItem});
            this.sizeChangeToolStripMenuItem.Name = "sizeChangeToolStripMenuItem";
            this.sizeChangeToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.sizeChangeToolStripMenuItem.Text = "Size Change";
            // 
            // zeroOrderHoldToolStripMenuItem
            // 
            this.zeroOrderHoldToolStripMenuItem.Name = "zeroOrderHoldToolStripMenuItem";
            this.zeroOrderHoldToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.zeroOrderHoldToolStripMenuItem.Text = "Zero Order Hold";
            this.zeroOrderHoldToolStripMenuItem.Click += new System.EventHandler(this.zeroOrderHoldToolStripMenuItem_Click);
            // 
            // firstOrderHoldToolStripMenuItem
            // 
            this.firstOrderHoldToolStripMenuItem.Name = "firstOrderHoldToolStripMenuItem";
            this.firstOrderHoldToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.firstOrderHoldToolStripMenuItem.Text = "First Order Hold";
            this.firstOrderHoldToolStripMenuItem.Click += new System.EventHandler(this.firstOrderHoldToolStripMenuItem_Click);
            // 
            // convulutionToolStripMenuItem
            // 
            this.convulutionToolStripMenuItem.Name = "convulutionToolStripMenuItem";
            this.convulutionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.convulutionToolStripMenuItem.Text = "Convolution";
            this.convulutionToolStripMenuItem.Click += new System.EventHandler(this.convulutionToolStripMenuItem_Click);
            // 
            // convolutionOnImageToolStripMenuItem
            // 
            this.convolutionOnImageToolStripMenuItem.Name = "convolutionOnImageToolStripMenuItem";
            this.convolutionOnImageToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.convolutionOnImageToolStripMenuItem.Text = "Convolution On Image";
            this.convolutionOnImageToolStripMenuItem.Click += new System.EventHandler(this.convolutionOnImageToolStripMenuItem_Click);
            // 
            // imageAlgebraToolStripMenuItem
            // 
            this.imageAlgebraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageAdditionToolStripMenuItem,
            this.imageSubtractionToolStripMenuItem});
            this.imageAlgebraToolStripMenuItem.Name = "imageAlgebraToolStripMenuItem";
            this.imageAlgebraToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.imageAlgebraToolStripMenuItem.Text = "Image Algebra";
            // 
            // imageAdditionToolStripMenuItem
            // 
            this.imageAdditionToolStripMenuItem.Name = "imageAdditionToolStripMenuItem";
            this.imageAdditionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.imageAdditionToolStripMenuItem.Text = "Image Addition";
            this.imageAdditionToolStripMenuItem.Click += new System.EventHandler(this.imageAdditionToolStripMenuItem_Click);
            // 
            // imageSubtractionToolStripMenuItem
            // 
            this.imageSubtractionToolStripMenuItem.Name = "imageSubtractionToolStripMenuItem";
            this.imageSubtractionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.imageSubtractionToolStripMenuItem.Text = "Image Subtraction";
            this.imageSubtractionToolStripMenuItem.Click += new System.EventHandler(this.imageSubtractionToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 614);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 128);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 614);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(256, 128);
            this.textBox3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1130, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Image Algebra Result";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1136, 193);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 531);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing System 2024";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBrightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeroOrderHoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstOrderHoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convulutionToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem convolutionOnImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAlgebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAdditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSubtractionToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

