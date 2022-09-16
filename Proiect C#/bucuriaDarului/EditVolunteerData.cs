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
            int check = UpdateVoluntar();

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
                                nume.Text = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                                prenume.Text  = reader.GetString(2);
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
        int UpdateVoluntar()
        {
            try
            {
                    SqlConnection cnn = SingletonDB.GetDBConnection();
                    SingletonDB.OpenDatabaseConnection();
                using (SqlCommand cmd = new("dbo.UpdatePerson", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ObjectID", SqlDbType.Int).Value = objectIDtoEDIT;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = nume.Text;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = prenume.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email.Text;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = telefon.Text;
                    cmd.Parameters.Add("@BirthDate", SqlDbType.Date).Value = DataNasterii.Value.ToShortDateString();
                    cmd.Parameters.Add("@TutorFirstName", SqlDbType.VarChar).Value = PrenumeTutore.Text;
                    cmd.Parameters.Add("@TutorLastName", SqlDbType.VarChar).Value = NumeTutore.Text;
                    cmd.Parameters.Add("@TutorEmail", SqlDbType.VarChar).Value = emailtutore.Text;
                    cmd.Parameters.Add("@PhoneNumberTutor", SqlDbType.VarChar).Value = telefontutore.Text;
                    cmd.Parameters.Add("@Profession", SqlDbType.VarChar).Value = prefesie.Text;
                    cmd.Parameters.Add("@Hobbies", SqlDbType.VarChar).Value = Hobby.Text;
                    cmd.Parameters.Add("@Details", SqlDbType.VarChar).Value = detalii.Text;
                    cmd.Parameters.Add("@DocumentID", SqlDbType.VarChar).Value = nrdocument.Text;
                    cmd.Parameters.Add("@RegistrationDate", SqlDbType.Date).Value = DateTime.Today;
                    int rowsAffected = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SingletonDB.CloseDatabaseConnection();
                }

                MessageBox.Show("Modificare efectuata cu succes!");
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
