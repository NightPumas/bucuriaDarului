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
    public partial class PontajVoluntarExistentcs : Form
    {
        
        //char numarTelefonVoluntar;

        public PontajVoluntarExistentcs()
        {
            InitializeComponent();
            //numarTelefonVoluntar = telefonVoluntar;
            numeleVoluntaruluiLabel.Text = getVolunteerNameFromDB();
        }

        private void OradeIntrare_Click(object sender, EventArgs e)
        {

        }

        //Get name


        private void buttonConfirmPontajVExistent_Click(object sender, EventArgs e)
        {
            //if true
            SendExistingVolunteerData();
            //if false
             //MessageBox
        }



        private static string getVolunteerNameFromDB()
        {
            string volunteerName = "";
            string queryString = "SELECT [FirstName] FROM [dbo].[Volunteers] WHERE [PhoneNumber]=0751049326;";

            using (SqlConnection cnn = SingletonDB.GetDBConnection())
            {
                SqlCommand command =
                    new SqlCommand(queryString, cnn);
                cnn.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    volunteerName =  ReadSingleRow((IDataRecord)reader);
                }

                // Call Close when done reading.
                reader.Close();
            }

            return volunteerName;
        }
        private static string ReadSingleRow(IDataRecord dataRecord)
        {
            String resultVolName = (String.Format("{0}", dataRecord[0]));
            return resultVolName;
        }

        static int SendExistingVolunteerData()
        {
            try
            {
                SqlConnection cnn = SingletonDB.GetDBConnection();
                SingletonDB.OpenDatabaseConnection();
                using (SqlCommand cmd = new("dbo.InsertPontaj", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@Prenume", SqlDbType.VarChar).Value = userNameBox.Text;
                    cmd.Dispose();
                }
                SingletonDB.CloseDatabaseConnection();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                return -1;
            }
        }
    }
}
