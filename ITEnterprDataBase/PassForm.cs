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
        //public static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Work\Projects\CSharp\ITEnterprDataBase\ITEnterprDataBase\TestDB.mdf;Integrated Security=True;Connect Timeout=30";
        public static String connectionString = @"Data Source=legko.database.windows.net;Initial Catalog=LegkoDB;User ID=legko;Password=mzipf2005!";

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

        public static Boolean checkConn() 
        {
            Boolean isConnectionExist = false;
            //DBConnection dBConnection = new DBConnection();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                isConnectionExist = true;
                MessageBox.Show("Успішне з'єднання з БД");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Відсутне з'єднання з БД" + ex);
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

        public PassForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //string loginPass = passInputField.Text;

            //SqlCommand command = connection.CreateCommand();
            //command.CommandText = "SELECT n_kdk FROM sppm WHERE cpassword = 'loginPass'";
            //SqlDataReader reader = command.ExecuteReader();
            //if (reader.Read())
            //{
                this.Hide();
                MainForms mainForms = new MainForms();
                mainForms.Show();
                //ShowDialog(passInputText.Text);
                //this.Close();
            //}
            //else
            //{
              //  MessageBox.Show("Невірний пароль!");
            //}
        }

        private void ChekDBConnect_Click(object sender, EventArgs e)
        {
            chekCconnection();
            //checkConn();
        }

        private void PassForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Додати умову, якщо выдкрите зэдання, його потрыбно закрити
            
            Application.Exit();

        }

        private void passInputText_KeyPass(object sender, KeyPressEventArgs e)
        {
            CheckInputNum checkInputNum = new CheckInputNum();
            checkInputNum.checkInputNumber(e);
        }
    }   
}
