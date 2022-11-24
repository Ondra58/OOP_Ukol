using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clovek jedna = new Clovek(textBox1.Text, maskedTextBox1.Text);
                Clovek dva = new Clovek(textBox2.Text, maskedTextBox2.Text);
                MessageBox.Show(jedna.ToString());
                MessageBox.Show(dva.ToString());
                MessageBox.Show(jedna.Starsi(dva));
            }
            catch
            {
                MessageBox.Show("Chyba");
            }
            }
    }
}
