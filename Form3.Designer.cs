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
            panel_lists = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel_menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_menu
            // 
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
            // panel_lists
            // 
            panel_lists.AutoScroll = true;
            panel_lists.Location = new Point(326, 65);
            panel_lists.Name = "panel_lists";
            panel_lists.Size = new Size(903, 597);
            panel_lists.TabIndex = 1;
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
            // button1
            // 
            button1.Location = new Point(9, 144);
            button1.Name = "button1";
            button1.Size = new Size(308, 61);
            button1.TabIndex = 0;
            button1.Text = "Food_Magazin";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(9, 211);
            button2.Name = "button2";
            button2.Size = new Size(308, 58);
            button2.TabIndex = 1;
            button2.Text = "XozMag";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(9, 275);
            button3.Name = "button3";
            button3.Size = new Size(308, 57);
            button3.TabIndex = 2;
            button3.Text = "Clothes_Magazin";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(9, 338);
            button4.Name = "button4";
            button4.Size = new Size(308, 58);
            button4.TabIndex = 3;
            button4.Text = "Natural_Magazin";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(9, 402);
            button5.Name = "button5";
            button5.Size = new Size(308, 55);
            button5.TabIndex = 4;
            button5.Text = "Technicals_Magazin";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(9, 463);
            button6.Name = "button6";
            button6.Size = new Size(308, 55);
            button6.TabIndex = 5;
            button6.Text = "Nashriyot_Magazin";
            button6.UseVisualStyleBackColor = true;
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
    }
}