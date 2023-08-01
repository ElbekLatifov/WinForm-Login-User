namespace Auth
{
    partial class Form3
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
            panel_menu = new Panel();
            update_btn = new Button();
            delete_btn = new Button();
            read_btn = new Button();
            create_btn = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel_lists = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel_menu.SuspendLayout();
            panel_lists.SuspendLayout();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.Controls.Add(update_btn);
            panel_menu.Controls.Add(delete_btn);
            panel_menu.Controls.Add(read_btn);
            panel_menu.Controls.Add(create_btn);
            panel_menu.Controls.Add(button6);
            panel_menu.Controls.Add(button5);
            panel_menu.Controls.Add(button4);
            panel_menu.Controls.Add(button3);
            panel_menu.Controls.Add(button2);
            panel_menu.Controls.Add(button1);
            panel_menu.Location = new Point(0, 0);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(326, 662);
            panel_menu.TabIndex = 0;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(94, 200);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(112, 34);
            update_btn.TabIndex = 9;
            update_btn.Text = "update";
            update_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(94, 142);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(112, 34);
            delete_btn.TabIndex = 8;
            delete_btn.Text = "delete";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // read_btn
            // 
            read_btn.Location = new Point(94, 84);
            read_btn.Name = "read_btn";
            read_btn.Size = new Size(112, 34);
            read_btn.TabIndex = 7;
            read_btn.Text = "read";
            read_btn.UseVisualStyleBackColor = true;
            read_btn.Click += read_btn_Click;
            // 
            // create_btn
            // 
            create_btn.Location = new Point(94, 28);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(112, 34);
            create_btn.TabIndex = 6;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 599);
            button6.Name = "button6";
            button6.Size = new Size(308, 55);
            button6.TabIndex = 5;
            button6.Text = "Nashriyot_Magazin";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 538);
            button5.Name = "button5";
            button5.Size = new Size(308, 55);
            button5.TabIndex = 4;
            button5.Text = "Technicals_Magazin";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 474);
            button4.Name = "button4";
            button4.Size = new Size(308, 58);
            button4.TabIndex = 3;
            button4.Text = "Natural_Magazin";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 411);
            button3.Name = "button3";
            button3.Size = new Size(308, 57);
            button3.TabIndex = 2;
            button3.Text = "Clothes_Magazin";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 347);
            button2.Name = "button2";
            button2.Size = new Size(308, 58);
            button2.TabIndex = 1;
            button2.Text = "XozMag";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 280);
            button1.Name = "button1";
            button1.Size = new Size(308, 61);
            button1.TabIndex = 0;
            button1.Text = "Food_Magazin";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel_lists
            // 
            panel_lists.AutoScroll = true;
            panel_lists.BackColor = SystemColors.ActiveCaption;
            panel_lists.Controls.Add(textBox1);
            panel_lists.Location = new Point(326, 65);
            panel_lists.Name = "panel_lists";
            panel_lists.Size = new Size(903, 597);
            panel_lists.TabIndex = 1;
            panel_lists.Paint += panel_lists_Paint;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(18, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(872, 536);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(510, 0);
            label1.Name = "label1";
            label1.Size = new Size(492, 62);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 662);
            Controls.Add(label1);
            Controls.Add(panel_lists);
            Controls.Add(panel_menu);
            Name = "Form3";
            Text = "Form3";
            panel_menu.ResumeLayout(false);
            panel_lists.ResumeLayout(false);
            panel_lists.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_menu;
        private Panel panel_lists;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button create_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button read_btn;
        private TextBox textBox1;
    }
}