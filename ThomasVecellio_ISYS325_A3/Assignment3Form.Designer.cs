namespace ThomasVecellio_ISYS325_A3
{
    partial class Assignment3Form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment3Form));
            dealBtn = new Button();
            saveBtn = new Button();
            loadBtn = new Button();
            keep5CheckBox = new CheckBox();
            keep4CheckBox = new CheckBox();
            keep3CheckBox = new CheckBox();
            keep2CheckBox = new CheckBox();
            keep1CheckBox = new CheckBox();
            card1PictureBox = new PictureBox();
            card2PictureBox = new PictureBox();
            card3PictureBox = new PictureBox();
            card4PictureBox = new PictureBox();
            card5PictureBox = new PictureBox();
            cardImageList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)card1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card4PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card5PictureBox).BeginInit();
            SuspendLayout();
            // 
            // dealBtn
            // 
            dealBtn.Location = new Point(34, 43);
            dealBtn.Name = "dealBtn";
            dealBtn.Size = new Size(94, 29);
            dealBtn.TabIndex = 0;
            dealBtn.Text = "&Deal";
            dealBtn.UseVisualStyleBackColor = true;
            dealBtn.Click += dealBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(525, 43);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "&Save hand";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(640, 43);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(94, 29);
            loadBtn.TabIndex = 2;
            loadBtn.Text = "&Load hand";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // keep5CheckBox
            // 
            keep5CheckBox.AutoSize = true;
            keep5CheckBox.Location = new Point(582, 112);
            keep5CheckBox.Name = "keep5CheckBox";
            keep5CheckBox.Size = new Size(77, 24);
            keep5CheckBox.TabIndex = 7;
            keep5CheckBox.Text = "Keep &5";
            keep5CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep4CheckBox
            // 
            keep4CheckBox.AutoSize = true;
            keep4CheckBox.Location = new Point(445, 112);
            keep4CheckBox.Name = "keep4CheckBox";
            keep4CheckBox.Size = new Size(77, 24);
            keep4CheckBox.TabIndex = 6;
            keep4CheckBox.Text = "Keep &4";
            keep4CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep3CheckBox
            // 
            keep3CheckBox.AutoSize = true;
            keep3CheckBox.Location = new Point(308, 112);
            keep3CheckBox.Name = "keep3CheckBox";
            keep3CheckBox.Size = new Size(77, 24);
            keep3CheckBox.TabIndex = 5;
            keep3CheckBox.Text = "Keep &3";
            keep3CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep2CheckBox
            // 
            keep2CheckBox.AutoSize = true;
            keep2CheckBox.Location = new Point(171, 112);
            keep2CheckBox.Name = "keep2CheckBox";
            keep2CheckBox.Size = new Size(77, 24);
            keep2CheckBox.TabIndex = 4;
            keep2CheckBox.Text = "Keep &2";
            keep2CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep1CheckBox
            // 
            keep1CheckBox.AutoSize = true;
            keep1CheckBox.Location = new Point(34, 112);
            keep1CheckBox.Name = "keep1CheckBox";
            keep1CheckBox.Size = new Size(77, 24);
            keep1CheckBox.TabIndex = 3;
            keep1CheckBox.Text = "Keep &1";
            keep1CheckBox.UseVisualStyleBackColor = true;
            // 
            // card1PictureBox
            // 
            card1PictureBox.Location = new Point(34, 151);
            card1PictureBox.Name = "card1PictureBox";
            card1PictureBox.Size = new Size(100, 145);
            card1PictureBox.TabIndex = 8;
            card1PictureBox.TabStop = false;
            // 
            // card2PictureBox
            // 
            card2PictureBox.Location = new Point(171, 151);
            card2PictureBox.Name = "card2PictureBox";
            card2PictureBox.Size = new Size(100, 145);
            card2PictureBox.TabIndex = 9;
            card2PictureBox.TabStop = false;
            // 
            // card3PictureBox
            // 
            card3PictureBox.Location = new Point(308, 151);
            card3PictureBox.Name = "card3PictureBox";
            card3PictureBox.Size = new Size(100, 145);
            card3PictureBox.TabIndex = 10;
            card3PictureBox.TabStop = false;
            // 
            // card4PictureBox
            // 
            card4PictureBox.Location = new Point(445, 151);
            card4PictureBox.Name = "card4PictureBox";
            card4PictureBox.Size = new Size(100, 145);
            card4PictureBox.TabIndex = 11;
            card4PictureBox.TabStop = false;
            // 
            // card5PictureBox
            // 
            card5PictureBox.Location = new Point(582, 151);
            card5PictureBox.Name = "card5PictureBox";
            card5PictureBox.Size = new Size(100, 145);
            card5PictureBox.TabIndex = 12;
            card5PictureBox.TabStop = false;
            // 
            // cardImageList
            // 
            cardImageList.ColorDepth = ColorDepth.Depth32Bit;
            cardImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardImageList.ImageStream");
            cardImageList.TransparentColor = Color.Transparent;
            cardImageList.Images.SetKeyName(0, "p0.png");
            cardImageList.Images.SetKeyName(1, "p1.png");
            cardImageList.Images.SetKeyName(2, "p2.png");
            cardImageList.Images.SetKeyName(3, "p3.png");
            cardImageList.Images.SetKeyName(4, "p4.png");
            cardImageList.Images.SetKeyName(5, "p5.png");
            cardImageList.Images.SetKeyName(6, "p6.png");
            cardImageList.Images.SetKeyName(7, "p8.png");
            cardImageList.Images.SetKeyName(8, "p9.png");
            cardImageList.Images.SetKeyName(9, "p10.png");
            cardImageList.Images.SetKeyName(10, "p11.png");
            cardImageList.Images.SetKeyName(11, "p12.png");
            cardImageList.Images.SetKeyName(12, "p7.png");
            cardImageList.Images.SetKeyName(13, "p13.png");
            cardImageList.Images.SetKeyName(14, "p14.png");
            cardImageList.Images.SetKeyName(15, "p15.png");
            cardImageList.Images.SetKeyName(16, "p16.png");
            cardImageList.Images.SetKeyName(17, "p17.png");
            cardImageList.Images.SetKeyName(18, "p18.png");
            cardImageList.Images.SetKeyName(19, "p19.png");
            cardImageList.Images.SetKeyName(20, "p20.png");
            cardImageList.Images.SetKeyName(21, "p21.png");
            cardImageList.Images.SetKeyName(22, "p22.png");
            cardImageList.Images.SetKeyName(23, "p23.png");
            cardImageList.Images.SetKeyName(24, "p24.png");
            cardImageList.Images.SetKeyName(25, "p25.png");
            cardImageList.Images.SetKeyName(26, "p26.png");
            cardImageList.Images.SetKeyName(27, "p27.png");
            cardImageList.Images.SetKeyName(28, "p28.png");
            cardImageList.Images.SetKeyName(29, "p29.png");
            cardImageList.Images.SetKeyName(30, "p30.png");
            cardImageList.Images.SetKeyName(31, "p31.png");
            cardImageList.Images.SetKeyName(32, "p32.png");
            cardImageList.Images.SetKeyName(33, "p33.png");
            cardImageList.Images.SetKeyName(34, "p34.png");
            cardImageList.Images.SetKeyName(35, "p35.png");
            cardImageList.Images.SetKeyName(36, "p36.png");
            cardImageList.Images.SetKeyName(37, "p37.png");
            cardImageList.Images.SetKeyName(38, "p38.png");
            cardImageList.Images.SetKeyName(39, "p39.png");
            cardImageList.Images.SetKeyName(40, "p40.png");
            cardImageList.Images.SetKeyName(41, "p41.png");
            cardImageList.Images.SetKeyName(42, "p42.png");
            cardImageList.Images.SetKeyName(43, "p43.png");
            cardImageList.Images.SetKeyName(44, "p44.png");
            cardImageList.Images.SetKeyName(45, "p45.png");
            cardImageList.Images.SetKeyName(46, "p46.png");
            cardImageList.Images.SetKeyName(47, "p47.png");
            cardImageList.Images.SetKeyName(48, "p48.png");
            cardImageList.Images.SetKeyName(49, "p49.png");
            cardImageList.Images.SetKeyName(50, "p50.png");
            cardImageList.Images.SetKeyName(51, "p51.png");
            // 
            // Assignment3Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(card5PictureBox);
            Controls.Add(card4PictureBox);
            Controls.Add(card3PictureBox);
            Controls.Add(card2PictureBox);
            Controls.Add(card1PictureBox);
            Controls.Add(keep1CheckBox);
            Controls.Add(keep2CheckBox);
            Controls.Add(keep3CheckBox);
            Controls.Add(keep4CheckBox);
            Controls.Add(keep5CheckBox);
            Controls.Add(loadBtn);
            Controls.Add(saveBtn);
            Controls.Add(dealBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Assignment3Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)card1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card4PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card5PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dealBtn;
        private Button saveBtn;
        private Button loadBtn;
        private CheckBox keep5CheckBox;
        private CheckBox keep4CheckBox;
        private CheckBox keep3CheckBox;
        private CheckBox keep2CheckBox;
        private CheckBox keep1CheckBox;
        private PictureBox card1PictureBox;
        private PictureBox card2PictureBox;
        private PictureBox card3PictureBox;
        private PictureBox card4PictureBox;
        private PictureBox card5PictureBox;
        private ImageList cardImageList;
    }
}
