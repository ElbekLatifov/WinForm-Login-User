namespace Auth
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1_submit = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            checkBox1 = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Times New Roman", 26F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(151, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(644, 77);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Perpetua", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(151, 145);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(644, 73);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 84);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Matura MT Script Capitals", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 168);
            label2.Name = "label2";
            label2.Size = new Size(145, 37);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1_submit
            // 
            button1_submit.BackColor = Color.OrangeRed;
            button1_submit.Cursor = Cursors.Hand;
            button1_submit.FlatStyle = FlatStyle.Flat;
            button1_submit.Font = new Font("Showcard Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button1_submit.Location = new Point(263, 318);
            button1_submit.Name = "button1_submit";
            button1_submit.Size = new Size(425, 60);
            button1_submit.TabIndex = 4;
            button1_submit.Text = "Login";
            button1_submit.UseVisualStyleBackColor = false;
            button1_submit.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Cursor = Cursors.Cross;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 525);
            button2.Name = "button2";
            button2.Size = new Size(294, 49);
            button2.TabIndex = 5;
            button2.Text = "Registration";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = Properties.Resources.eye_open;
            pictureBox1.Location = new Point(743, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(570, 524);
            button3.Name = "button3";
            button3.Size = new Size(294, 49);
            button3.TabIndex = 7;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(151, 234);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(868, 578);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1_submit);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1_submit;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}