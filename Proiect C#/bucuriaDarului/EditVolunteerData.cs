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
            //int check = EditPersoninDB();
            PontajVoluntarExistentcs PontajVoluntarExistentcs = new PontajVoluntarExistentcs();
            PontajVoluntarExistentcs.ShowDialog();
            this.Close();
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
                            if (reader.GetString(1).Length != 0)
                                prenume.Text = reader.GetString(1);
                            if (reader.GetString(2).Length != 0) 
                                nume.Text  = reader.GetString(2);
                            if (reader.GetString(6).Length != 0)
                                email.Text = reader.GetString(3);
                            if (reader.GetString(6).Length != 0)
                                telefon.Text = reader.GetString(4);
                            if (reader.GetDateTime(5).ToString().Length != 0) 
                                DataNasterii.Value = reader.GetDateTime(5);
                            if(reader.GetString(6).Length != 0) 
                                PrenumeTutore.Text = reader.GetString(6);
                            if (reader.GetString(7).Length != 0) 
                                NumeTutore.Text = reader.GetString(7);
                            if (reader.GetString(8).Length != 0) 
                                emailtutore.Text = reader.GetString(8);
                            if (reader.GetString(9).Length != 0)
                                telefontutore.Text = reader.GetString(9);
                            if (reader.GetString(6).Length != 0)
                                prefesie.Text = reader.GetString(10);
                            if (reader.GetString(6).Length != 0)
                                detalii.Text = reader.GetString(11);
                            if (reader.GetString(6).Length != 0)
                                nrdocument.Text = reader.GetString(12);
                        }
                    }

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
