using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEnterprDataBase
{
    public partial class PassForm : Form
    {
        /*public async static void dbConnect()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\Users\Андрій\source\repos\ITEnterprDataBase\ITEnterprDataBase\TestDB.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }*/
        public static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Work\Projects\CSharp\ITEnterprDataBase\ITEnterprDataBase\TestDB.mdf;Integrated Security=True;Connect Timeout=30";

        private static Boolean chekCconnection()
        {
            Boolean isConnectionExist = false;
            //Boolean isSysWorksExist = false;
            //SqlDataReader reader = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    isConnectionExist = true;
                    MessageBox.Show("З'єднання успішне");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка з'єднання: " + ex.ToString());
                    isConnectionExist = false;
                }
                if (isConnectionExist)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public PassForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //dbConnect();
            //SqlCommand command = new SqlCommand("SELECT n_kdk FROM [sppm]");

            this.Hide();
            MainForms mainForms = new MainForms();
            mainForms.Show();
            //ShowDialog(passInputText.Text);
            //this.Close();
        }

        private void ChekDBConnect_Click(object sender, EventArgs e)
        {
            chekCconnection();
        }

        private void PassForm_Load(object sender, EventArgs e)
        {

        }
    }   
}
