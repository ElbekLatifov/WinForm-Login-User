namespace Auth
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            textBox2_password = new TextBox();
            textBox1_login = new TextBox();
            label3 = new Label();
            button1_reg_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(224, 44);
            label1.MaximumSize = new Size(300, 50);
            label1.MinimumSize = new Size(300, 50);
            label1.Name = "label1";
            label1.Size = new Size(300, 50);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 234);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // textBox2_password
            // 
            textBox2_password.Cursor = Cursors.IBeam;
            textBox2_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2_password.Location = new Point(266, 223);
            textBox2_password.Multiline = true;
            textBox2_password.Name = "textBox2_password";
            textBox2_password.PasswordChar = '*';
            textBox2_password.Size = new Size(281, 46);
            textBox2_password.TabIndex = 5;
            // 
            // textBox1_login
            // 
            textBox1_login.Cursor = Cursors.IBeam;
            textBox1_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_login.Location = new Point(266, 140);
            textBox1_login.Multiline = true;
            textBox1_login.Name = "textBox1_login";
            textBox1_login.Size = new Size(281, 47);
            textBox1_login.TabIndex = 4;
            textBox1_login.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 152);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // button1_reg_login
            // 
            button1_reg_login.Location = new Point(338, 322);
            button1_reg_login.Name = "button1_reg_login";
            button1_reg_login.Size = new Size(152, 57);
            button1_reg_login.TabIndex = 8;
            button1_reg_login.Text = "Login";
            button1_reg_login.UseVisualStyleBackColor = true;
            button1_reg_login.Click += button1_reg_login_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1_reg_login);
            Controls.Add(label2);
            Controls.Add(textBox2_password);
            Controls.Add(textBox1_login);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox2_password;
        private TextBox textBox1_login;
        private Label label3;
        private Button button1_reg_login;
    }
}