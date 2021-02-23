using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        int count = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты, содержит ряд небольших программ которые могут пригодиться в жизни. \nАвтор: Тюлегенов А.К.", "О программе");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;

            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;

            lblCount.Text = count.ToString();
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            count = 0;

            lblCount.Text = Convert.ToString(count);
        }
    }
}
