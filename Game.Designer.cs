namespace Mahjongg
{
    partial class Mahjongg
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
            button1 = new Button();
            points1 = new TextBox();
            points2 = new TextBox();
            points3 = new TextBox();
            points4 = new TextBox();
            win1 = new RadioButton();
            win2 = new RadioButton();
            win3 = new RadioButton();
            win4 = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            sum4 = new Label();
            sum3 = new Label();
            sum2 = new Label();
            sum1 = new Label();
            textBox = new RichTextBox();
            x21 = new Button();
            x22 = new Button();
            x24 = new Button();
            x23 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            name4 = new Label();
            name3 = new Label();
            name2 = new Label();
            name1 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(756, 70);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.Name = "button1";
            button1.Size = new Size(50, 38);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // points1
            // 
            points1.BackColor = SystemColors.InactiveCaption;
            points1.Location = new Point(104, 18);
            points1.Margin = new Padding(4, 6, 4, 6);
            points1.Name = "points1";
            points1.Size = new Size(114, 31);
            points1.TabIndex = 1;
            // 
            // points2
            // 
            points2.Location = new Point(282, 18);
            points2.Margin = new Padding(4, 6, 4, 6);
            points2.Name = "points2";
            points2.Size = new Size(114, 31);
            points2.TabIndex = 2;
            // 
            // points3
            // 
            points3.Location = new Point(458, 18);
            points3.Margin = new Padding(4, 6, 4, 6);
            points3.Name = "points3";
            points3.Size = new Size(114, 31);
            points3.TabIndex = 3;
            // 
            // points4
            // 
            points4.Location = new Point(636, 18);
            points4.Margin = new Padding(4, 6, 4, 6);
            points4.Name = "points4";
            points4.Size = new Size(114, 31);
            points4.TabIndex = 4;
            // 
            // win1
            // 
            win1.AutoSize = true;
            win1.Location = new Point(109, 77);
            win1.Margin = new Padding(4, 6, 4, 6);
            win1.Name = "win1";
            win1.Size = new Size(21, 20);
            win1.TabIndex = 5;
            win1.TabStop = true;
            win1.UseVisualStyleBackColor = true;
            // 
            // win2
            // 
            win2.AutoSize = true;
            win2.Location = new Point(284, 77);
            win2.Margin = new Padding(4, 6, 4, 6);
            win2.Name = "win2";
            win2.Size = new Size(21, 20);
            win2.TabIndex = 6;
            win2.TabStop = true;
            win2.UseVisualStyleBackColor = true;
            // 
            // win3
            // 
            win3.AutoSize = true;
            win3.Location = new Point(464, 77);
            win3.Margin = new Padding(4, 6, 4, 6);
            win3.Name = "win3";
            win3.Size = new Size(21, 20);
            win3.TabIndex = 7;
            win3.TabStop = true;
            win3.UseVisualStyleBackColor = true;
            // 
            // win4
            // 
            win4.AutoSize = true;
            win4.Location = new Point(642, 77);
            win4.Margin = new Padding(4, 6, 4, 6);
            win4.Name = "win4";
            win4.Size = new Size(21, 20);
            win4.TabIndex = 8;
            win4.TabStop = true;
            win4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 72);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 35);
            label5.TabIndex = 13;
            label5.Text = "Winner:";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 35);
            label6.TabIndex = 14;
            label6.Text = "Points:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(sum4);
            panel1.Controls.Add(sum3);
            panel1.Controls.Add(sum2);
            panel1.Controls.Add(sum1);
            panel1.Location = new Point(20, 215);
            panel1.Margin = new Padding(4, 6, 4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 56);
            panel1.TabIndex = 21;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 11);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 35);
            label12.TabIndex = 25;
            label12.Text = "Sum:";
            // 
            // sum4
            // 
            sum4.BackColor = Color.Transparent;
            sum4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sum4.ForeColor = Color.White;
            sum4.Location = new Point(637, 11);
            sum4.Margin = new Padding(4, 0, 4, 0);
            sum4.Name = "sum4";
            sum4.Size = new Size(167, 31);
            sum4.TabIndex = 24;
            sum4.Text = "0";
            // 
            // sum3
            // 
            sum3.BackColor = Color.Transparent;
            sum3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sum3.ForeColor = Color.White;
            sum3.Location = new Point(456, 11);
            sum3.Margin = new Padding(4, 0, 4, 0);
            sum3.Name = "sum3";
            sum3.Size = new Size(167, 31);
            sum3.TabIndex = 23;
            sum3.Text = "0";
            // 
            // sum2
            // 
            sum2.BackColor = Color.Transparent;
            sum2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sum2.ForeColor = Color.White;
            sum2.Location = new Point(278, 11);
            sum2.Margin = new Padding(4, 0, 4, 0);
            sum2.Name = "sum2";
            sum2.Size = new Size(167, 31);
            sum2.TabIndex = 22;
            sum2.Text = "0";
            // 
            // sum1
            // 
            sum1.BackColor = Color.Transparent;
            sum1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sum1.ForeColor = Color.White;
            sum1.Location = new Point(107, 11);
            sum1.Margin = new Padding(4, 0, 4, 0);
            sum1.Name = "sum1";
            sum1.Size = new Size(167, 31);
            sum1.TabIndex = 21;
            sum1.Text = "0";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox.BackColor = Color.Black;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.ForeColor = Color.White;
            textBox.Location = new Point(20, 285);
            textBox.Margin = new Padding(4, 6, 4, 6);
            textBox.Name = "textBox";
            textBox.Size = new Size(824, 782);
            textBox.TabIndex = 22;
            textBox.Text = "";
            // 
            // x21
            // 
            x21.Location = new Point(224, 15);
            x21.Margin = new Padding(4, 6, 4, 6);
            x21.Name = "x21";
            x21.Size = new Size(47, 40);
            x21.TabIndex = 23;
            x21.Text = "X2";
            x21.UseVisualStyleBackColor = true;
            x21.Click += button2_Click;
            // 
            // x22
            // 
            x22.Location = new Point(402, 15);
            x22.Margin = new Padding(4, 6, 4, 6);
            x22.Name = "x22";
            x22.Size = new Size(47, 40);
            x22.TabIndex = 24;
            x22.Text = "X2";
            x22.UseVisualStyleBackColor = true;
            x22.Click += button3_Click;
            // 
            // x24
            // 
            x24.Location = new Point(756, 15);
            x24.Margin = new Padding(4, 6, 4, 6);
            x24.Name = "x24";
            x24.Size = new Size(47, 40);
            x24.TabIndex = 26;
            x24.Text = "X2";
            x24.UseVisualStyleBackColor = true;
            // 
            // x23
            // 
            x23.Location = new Point(578, 15);
            x23.Margin = new Padding(4, 6, 4, 6);
            x23.Name = "x23";
            x23.Size = new Size(47, 40);
            x23.TabIndex = 25;
            x23.Text = "X2";
            x23.UseVisualStyleBackColor = true;
            x23.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(x24);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(x23);
            panel2.Controls.Add(x22);
            panel2.Controls.Add(x21);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(win4);
            panel2.Controls.Add(win3);
            panel2.Controls.Add(win2);
            panel2.Controls.Add(win1);
            panel2.Controls.Add(points4);
            panel2.Controls.Add(points3);
            panel2.Controls.Add(points2);
            panel2.Controls.Add(points1);
            panel2.Location = new Point(20, 75);
            panel2.Margin = new Padding(4, 6, 4, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 127);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(name4);
            panel3.Controls.Add(name3);
            panel3.Controls.Add(name2);
            panel3.Controls.Add(name1);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(20, 11);
            panel3.Margin = new Padding(4, 6, 4, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(825, 50);
            panel3.TabIndex = 28;
            // 
            // name4
            // 
            name4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name4.ForeColor = Color.FromArgb(192, 192, 0);
            name4.Location = new Point(633, 11);
            name4.Margin = new Padding(4, 0, 4, 0);
            name4.Name = "name4";
            name4.Size = new Size(167, 31);
            name4.TabIndex = 24;
            name4.Text = "NN";
            // 
            // name3
            // 
            name3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name3.ForeColor = Color.Blue;
            name3.Location = new Point(451, 11);
            name3.Margin = new Padding(4, 0, 4, 0);
            name3.Name = "name3";
            name3.Size = new Size(167, 31);
            name3.TabIndex = 23;
            name3.Text = "NN";
            // 
            // name2
            // 
            name2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name2.ForeColor = Color.FromArgb(0, 192, 0);
            name2.Location = new Point(276, 11);
            name2.Margin = new Padding(4, 0, 4, 0);
            name2.Name = "name2";
            name2.Size = new Size(167, 31);
            name2.TabIndex = 22;
            name2.Text = "NN";
            // 
            // name1
            // 
            name1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name1.ForeColor = Color.Red;
            name1.Location = new Point(103, 11);
            name1.Margin = new Padding(4, 0, 4, 0);
            name1.Name = "name1";
            name1.Size = new Size(167, 31);
            name1.TabIndex = 21;
            name1.Text = "NN";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(4, 10);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 35);
            label7.TabIndex = 20;
            label7.Text = "Player:";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(857, 11);
            pictureBox2.Margin = new Padding(4, 6, 4, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1486, 1056);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Paint += pictureBox2_Paint;
            // 
            // Mahjongg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(2364, 1092);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(textBox);
            Controls.Add(panel1);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Mahjongg";
            Text = "Mahjongg";
            FormClosed += Game_FormClosed;
            Load += Mahjongg_Load;
            ClientSizeChanged += Mahjongg_ClientSizeChanged;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox points1;
        private System.Windows.Forms.TextBox points2;
        private System.Windows.Forms.TextBox points3;
        private System.Windows.Forms.TextBox points4;
        private System.Windows.Forms.RadioButton win1;
        private System.Windows.Forms.RadioButton win2;
        private System.Windows.Forms.RadioButton win3;
        private System.Windows.Forms.RadioButton win4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label sum4;
        private System.Windows.Forms.Label sum3;
        private System.Windows.Forms.Label sum2;
        private System.Windows.Forms.Label sum1;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button x21;
        private System.Windows.Forms.Button x22;
        private System.Windows.Forms.Button x24;
        private System.Windows.Forms.Button x23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label name4;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}