using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEnterprDataBase
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        public void chekNumberInput(KeyPressEventArgs e) //Использование в поле только цифр и клавиши Backspace
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openPall_Click(object sender, EventArgs e)
        {
            
        }

        private void numberPallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            chekNumberInput(e);
        }

        private void MainForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void numberPalletPogruz_KeyPress(object sender, KeyPressEventArgs e)
        {
            chekNumberInput(e);
        }

        private void numberPalletStorno_KeyPress(object sender, KeyPressEventArgs e)
        {
            chekNumberInput(e);
        }
    }
}
