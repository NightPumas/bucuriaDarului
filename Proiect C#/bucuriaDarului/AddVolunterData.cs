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
    public partial class AddVolunterData : Form
    {
        public AddVolunterData()
        {
            InitializeComponent();
        }

        private void SendToDatabaseBtn_Click(object sender, EventArgs e)
        {
            int check = AddPersonToDatabase();
            // send to DB
            //int pontaj = PontajVoluntarExistentcs.SendExistingVolunteerData();
        }

        int AddPersonToDatabase()
        {
            try
            {
                bool error = false;

                DataValidation DataValidation = new DataValidation();
                int FirstNameCheck = DataValidation.CheckName(prenume.Text);
                int NameCheck = DataValidation.CheckName(prenume.Text);
                int PhoneCheck = DataValidation.CheckPhone(telefontutore.Text);
                int PhoneCheckTutore = DataValidation.CheckPhone(telefon.Text);
                int Emailcheck = DataValidation.CheckEmail(email.Text);
                int EmailcheckTutore = DataValidation.CheckEmail(emailtutore.Text);
                string BirttDateString = DataNasterii.Value.ToString();
                //MessageBox.Show(BirttDateString);
                //Check Name
                if (NameCheck == 0)
                {
                    MessageBox.Show("Name cannot be empty");
                    error = true;
                }
                else
                {
                    if (NameCheck == -1)
                    {
                        MessageBox.Show("Name is Invalid or to long");
                        error = true;
                    };
                }

                //Check FirstName
                if (FirstNameCheck == 0)
                {
                    MessageBox.Show("First Name cannot be empty");
                    error = true;
                }
                else
                {
                    if (FirstNameCheck == -1)
                    {
                        MessageBox.Show("First Name is Invalid or to long");
                        error = true;
                    };
                }


                if (PhoneCheck == 0)
                {
                    MessageBox.Show("Phone cannot be empty");
                    error = true;
                }
                else
                {
                    //check Phone is valid
                    if (PhoneCheck == -1)
                    {
                        MessageBox.Show("Phone is Invalid");
                        error = true;
                    };
                }

                if (PhoneCheckTutore == 0)
                {
                    MessageBox.Show("Phone cannot be empty");
                    error = true;
                }
                else
                {
                    //check Phone is valid
                    if (PhoneCheckTutore == -1)
                    {
                        MessageBox.Show("Phone is Invalid");
                        error = true;
                    };
                }

                if (Emailcheck == 0)
                {
                    MessageBox.Show("Email cannot be empty");
                    error = true;
                }
                else
                {
                    //check email is valid
                    if (Emailcheck == -1)
                    {
                        MessageBox.Show("Email is Invalid or to long");
                        error = true;
                    }
                }

                if (EmailcheckTutore == 0)
                {
                    MessageBox.Show("EmailTutore cannot be empty");
                    error = true;
                }
                else
                {
                    //check email is valid
                    if (EmailcheckTutore == -1)
                    {
                        MessageBox.Show("EmailTutore is Invalid or to long");
                        error = true;
                    }
                }

                if (error)
                {
                    MessageBox.Show("Erori in form, va rugam verificati datele "); /////////////Dialog box neaparat 
                }
                else
                {

                    SqlConnection cnn = SingletonDB.GetDBConnection();
                    SingletonDB.OpenDatabaseConnection();
                    using (SqlCommand cmd = new("dbo.InsertPerson", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
                        cmd.Parameters.Add("@RegistrationDate", SqlDbType.Date).Value = entryDate.Value.ToShortDateString();
                        cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = true;
                        int rowsAffected = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                }

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
