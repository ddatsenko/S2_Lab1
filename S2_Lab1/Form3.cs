using System;
using System.Windows.Forms;

namespace S2_Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = (Form2)Application.OpenForms["Form2"];
            f1.Hide();
            Form3 f2 = (Form3)Application.OpenForms["Form3"];
            f2.Close();
        }
    }
}
