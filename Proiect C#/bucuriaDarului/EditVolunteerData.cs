using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bucuriaDarului
{
    public partial class EditVolunteerData : Form
    {
        static string objectIDtoEDIT = adminStartPage.SetObjectIdForUpdate; //get phone from previous screen;
        public EditVolunteerData()
        {
            InitializeComponent();
            AddInfoOnUI();
        }

        private void SendToDatabaseBtn_Click(object sender, EventArgs e)
        {
           // int check = UpdateVoluntar();

        }

        int AddInfoOnUI()
        {
            try
            {
                SqlConnection cnn = SingletonDB.GetDBConnection();
                SingletonDB.OpenDatabaseConnection();
                using (SqlCommand cmd = new("dbo.ViewAllVolunteers", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ObjectID", SqlDbType.VarChar).Value = objectIDtoEDIT;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(1))
                                prenume.Text = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                                nume.Text  = reader.GetString(2);
                            if (!reader.IsDBNull(3))
                                email.Text = reader.GetString(3);
                            if (!reader.IsDBNull(4))
                                telefon.Text = reader.GetString(4);
                            if (!reader.IsDBNull(5))
                                DataNasterii.Value = reader.GetDateTime(5);
                            if(!reader.IsDBNull(6)) 
                                PrenumeTutore.Text = reader.GetString(6);
                            if (!reader.IsDBNull(7))
                                NumeTutore.Text = reader.GetString(7);
                            if (!reader.IsDBNull(8))
                                emailtutore.Text = reader.GetString(8);
                            if (!reader.IsDBNull(9))
                                telefontutore.Text = reader.GetString(9);
                            if (!reader.IsDBNull(10))
                                prefesie.Text = reader.GetString(10);
                            if (!reader.IsDBNull(11))
                                Hobby.Text = reader.GetString(11);
                            if (!reader.IsDBNull(12))
                                detalii.Text = reader.GetString(12);
                            if (!reader.IsDBNull(13))
                                nrdocument.Text = reader.GetString(13);
                        }
                    }

                }
                SingletonDB.CloseDatabaseConnection();


                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A intervenit o eroare la preluarea datelor");
                return -1;
            }
        }
    }
}
