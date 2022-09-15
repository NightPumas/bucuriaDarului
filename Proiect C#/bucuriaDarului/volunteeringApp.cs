using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bucuriaDarului
{
    public partial class volunteeringApp : Form
    {
        public volunteeringApp()
        {
            InitializeComponent();
        }

        private void loginBtb_Click(object sender, EventArgs e)
        {
            bool completed = true;

            if (userNameBox.Text.Length == 0 || passwordBox.Text.Length == 0)
            {
                MessageBox.Show("Username or password cannot be blank");
                completed = false;
            }

            if (completed)
            {
                int check = CheckCredentials();

                switch (check)
                {
                    case -1:
                        {
                            MessageBox.Show("User not found");
                            break;
                        }
                    case 0: //Open AdminWindows
                        {
                            this.Hide();
                            //MessageBox.Show("Login Succes");
                            adminStartPage adminStartPage = new adminStartPage();
                            adminStartPage.ShowDialog();
                            break;
                        }
                    case 1: //Open reader
                        {
                            this.Hide();
                            //MessageBox.Show("Login Succes");
                            //VolunteerScreen VolunteerScreen = new VolunteerScreen();
                           // VolunteerScreen.ShowDialog();
                            break;
                        }
                    case 2: //Open vountar
                        {
                            this.Hide();
                            //MessageBox.Show("Login Succes");
                            VolunteerScreen VolunteerScreen = new VolunteerScreen();
                            VolunteerScreen.ShowDialog();
                            break;
                        }
                }
            }

        }

        int CheckCredentials ()
        {
            try
            {
                Int32 typeOfUser;
                SqlConnection cnn = SingletonDB.GetDBConnection();
                SingletonDB.OpenDatabaseConnection();
                using (SqlCommand cmd = new("dbo.CheckPassword", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = userNameBox.Text;
                    cmd.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = passwordBox.Text;
                    typeOfUser = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                }
                SingletonDB.CloseDatabaseConnection();
                return typeOfUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                return -1;
            }
        }

        void ClearCredentials()
        {
            userNameBox.Text = String.Empty;
            passwordBox.Text = String.Empty;
        }
    }
}