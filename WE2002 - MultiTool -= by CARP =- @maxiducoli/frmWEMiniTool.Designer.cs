namespace WE2002___MultiTool____by_CARP_____maxiducoli
{
    partial class frmWEMiniTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(99, 43);
            button1.TabIndex = 0;
            button1.Text = "Creador de estadios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(13, 110);
            button2.Name = "button2";
            button2.Size = new Size(98, 43);
            button2.TabIndex = 1;
            button2.Text = "Creador de RA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(116, 12);
            button3.Name = "button3";
            button3.Size = new Size(99, 43);
            button3.TabIndex = 2;
            button3.Text = "Creador de BIN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(65, 246);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(270, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ayúdame con un cafecito - Help me with a coffee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cafecito;
            pictureBox1.Location = new Point(18, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(12, 61);
            button4.Name = "button4";
            button4.Size = new Size(99, 43);
            button4.TabIndex = 5;
            button4.Text = "Extractor de estadios";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(221, 61);
            button5.Name = "button5";
            button5.Size = new Size(99, 43);
            button5.TabIndex = 6;
            button5.Text = "La Pinta";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(221, 12);
            button6.Name = "button6";
            button6.Size = new Size(99, 43);
            button6.TabIndex = 7;
            button6.Text = "Creador de T_Name";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(116, 61);
            button7.Name = "button7";
            button7.Size = new Size(99, 43);
            button7.TabIndex = 8;
            button7.Text = "Extraer e insertar BIN";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Location = new Point(116, 110);
            button8.Name = "button8";
            button8.Size = new Size(98, 43);
            button8.TabIndex = 9;
            button8.Text = "Extractor de VAGs";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Location = new Point(220, 110);
            button9.Name = "button9";
            button9.Size = new Size(98, 43);
            button9.TabIndex = 10;
            button9.Text = "Compresor de imágenes";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.Location = new Point(12, 159);
            button10.Name = "button10";
            button10.Size = new Size(98, 43);
            button10.TabIndex = 11;
            button10.Text = "Creador nombres largos";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // frmWEMiniTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 270);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmWEMiniTool";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Winning Eleven 2002 - MultiTool -= by CARP =-";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
