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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openPall_Click(object sender, EventArgs e)
        {
            
        }

        private void numberPallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputNum checkInputNum = new CheckInputNum();
            checkInputNum.checkInputNumber(e);
        }

        private void MainForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void numberPalletPogruz_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputNum checkInputNum = new CheckInputNum();
            checkInputNum.checkInputNumber(e);
        }

        private void numberPalletStorno_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputNum checkInputNum = new CheckInputNum();
            checkInputNum.checkInputNumber(e);
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttTestMPK14_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBackPassForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassForm passForm = new PassForm();
            passForm.Show();
        }
    }
}
