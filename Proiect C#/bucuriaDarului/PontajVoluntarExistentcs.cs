using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace bucuriaDarului
{
    public partial class PontajVoluntarExistentcs : Form
    {
        static string phoneNumber = VolunteerScreen.SetValueForPhone; //get phone from previous screen;
        public PontajVoluntarExistentcs()
        {
            InitializeComponent();
            numeleVoluntaruluiLabel.Text = getVolunteerNameFromDB();
            oreDeActivitateLabel.Text = oreTotale().ToString();
            dataCurentaLabel.Text = DateTime.Today.ToShortDateString();
        }

        //Get name

        private void buttonConfirmPontajVExistent_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (oreTotale() > 8 || oreTotale() < 0)
            {
                MessageBox.Show("Numarul de ore este incorect. Va rugam corectati");
                check = false;
            }
            if (check)
            {
                SendExistingVolunteerData();
            }
        }

        public static string ReadSingleRow(IDataRecord dataRecord)
        {
            String result = (String.Format("{0}", dataRecord[0]));
            return result;
        }

        public static string getVolunteerNameFromDB()
        {
            string volunteerName = "";
            string queryString = "SELECT [FirstName] FROM [dbo].[Volunteers] WHERE [PhoneNumber]=" + phoneNumber ;
            SqlConnection cnn = SingletonDB.GetDBConnection();
                SingletonDB.OpenDatabaseConnection();

            using (SqlCommand command = new SqlCommand(queryString, cnn))
            {
                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    volunteerName = ReadSingleRow((IDataRecord)reader);
                }
                

                // Call Close when done reading.
                reader.Close();
            }
            SingletonDB.CloseDatabaseConnection();
            return volunteerName;
        }

        public static string getVolunteerIDFromDB()
        {
            string volunteerID = "";
            string queryString = "SELECT [ObjectID] FROM [dbo].[Volunteers] WHERE [PhoneNumber]=" + phoneNumber;

            SqlConnection cnn = SingletonDB.GetDBConnection();

            using (SqlCommand cmd = new(queryString, cnn))
            {
                SingletonDB.OpenDatabaseConnection();

                SqlDataReader reader = cmd.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    volunteerID = ReadSingleRow((IDataRecord)reader);
                }

                // Call Close when done reading.
                reader.Close();
            }
            SingletonDB.CloseDatabaseConnection();
            return volunteerID;
        }

        private double oreTotale()
        {
            TimeSpan interval = dateTimePickerIesire.Value.Subtract(dateTimePickerIntrare.Value);
            double dec = Math.Round((interval.TotalMinutes / 60), 2); //limit 2 decimal
            return dec;
        }

        public
        int SendExistingVolunteerData()
        {
            try
            {
                string voluntarID = getVolunteerIDFromDB();

                SqlConnection cnn = SingletonDB.GetDBConnection();
                SingletonDB.OpenDatabaseConnection();
                using (SqlCommand cmd = new("dbo.InsertTimesheet", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IDVolunteer", SqlDbType.Int).Value = voluntarID;
                    cmd.Parameters.Add("@EntryDateTime", SqlDbType.DateTime).Value = dateTimePickerIntrare.Value;
                    cmd.Parameters.Add("@ExitDateTime ", SqlDbType.DateTime).Value = dateTimePickerIesire.Value;
                    cmd.Parameters.Add("@TotalHours ", SqlDbType.Decimal).Value = oreTotale();
                    cmd.ExecuteScalar();
                    cmd.Dispose();
                }

                SingletonDB.CloseDatabaseConnection();
                MessageBox.Show("Fisa de pontaj salvata");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea fisei de pontaj");
                return -1;
            }
        }

        private void dateTimePickerIesire_ValueChanged(object sender, EventArgs e)
        {
            oreDeActivitateLabel.Text = oreTotale().ToString();
        }

        private void dateTimePickerIntrare_ValueChanged(object sender, EventArgs e)
        {
            oreDeActivitateLabel.Text = oreTotale().ToString();
        }
    }
}
