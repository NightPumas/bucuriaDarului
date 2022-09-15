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

namespace bucuriaDarului
{
    public partial class VolunteerScreen : Form
    {
        public VolunteerScreen()
        {
            InitializeComponent();
        }

        private void CautareNrTelefon_Click(object sender, EventArgs e)
        {
            bool nrTelefonExistent = true;

            if (NrTelefonSearch.Text.Length == 0 )
            {
                MessageBox.Show("Campul nr telefon este obligatoriu");
                nrTelefonExistent = false;
            }

            if (nrTelefonExistent)
            {
                int check = CheckNrTelefon();

                switch (check)
                {
                    case -1:
                        {
                            MessageBox.Show("User Ne-Existent");
                            AddVolunterData AddVolunterData = new AddVolunterData();
                            AddVolunterData.ShowDialog();
                            break;
                        }
                    case 1: //Open AdminWindows
                        {
                            MessageBox.Show("User Existent");
                            PontajVoluntarExistentcs PontajVoluntarExistentcs = new PontajVoluntarExistentcs();
                            PontajVoluntarExistentcs.ShowDialog();
                            break;
                        }
                    case -99: //Open AdminWindows
                        {
                            MessageBox.Show("Error Error Error");
                            break;
                        }
                }
            }



        }

        int CheckNrTelefon()
        {
            try
            {
                Int32 result;
                SqlConnection cnn = SingletonDB.GetDBConnection();
                SingletonDB.OpenDatabaseConnection();
                using (SqlCommand cmd = new("dbo.CheckPhoneNumberExistance", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = NrTelefonSearch.Text;
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                }
                SingletonDB.CloseDatabaseConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Error Error ! ");
                return -99;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NrTelefonSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
