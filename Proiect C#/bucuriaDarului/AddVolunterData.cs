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
            bool completed = true;

            int check = AddPersonToDatabase();

        }

        int AddPersonToDatabase()
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
                //ErrorMessage << "Phone cannot be empty";
                //error = true;
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
                //ErrorMessage << "Phone cannot be empty";
                //error = true;
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



            return 1;   
        }
    }
}
