using Auth.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.Show();
        }

        private void panel_lists_Paint(object sender, PaintEventArgs e)
        {

        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            var magazins = MemoryService.Magazins.ToList();

            if (magazins.Count > 0)
            {
                textBox1.Text = "";
                foreach (var magaz in magazins)
                {
                    textBox1.Text += "\n" + " [Name : " + magaz.Name + " Description : " + magaz.Description + "]";
                }
            }

        }
    }
}
