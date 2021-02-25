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
        Random rnd = new Random();

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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRandom.Text = Convert.ToString(n);

            if (cbRandom.Checked)
            {
                int i = 0;

                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    i++;

                    if(i > 1000)
                    {
                        break;
                    }
                }

                if (i <= 1000)
                {
                    tbRandom.AppendText(n + "\r\n");
                }
            }
            else
            {
                tbRandom.AppendText(Convert.ToString(n) + "\r\n");
            }


        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\r\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\r\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении");
            }
                
        }

        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }
    }
}
