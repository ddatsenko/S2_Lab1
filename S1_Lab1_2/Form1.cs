using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_Lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Label> lbls = new List<Label>();
            foreach (Control obj in this.Controls)
            {
                if (obj is Label)
                {
                    lbls.Add((Label)obj);
                }

            }
            foreach (Label uc in lbls)
            {
                this.Controls.Remove(uc);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
