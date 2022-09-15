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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace bucuriaDarului
{
    public partial class PontajVoluntarExistentcs : Form
    {

        //char numarTelefonVoluntar;
        string dataIntrare = "";
        string dataIesire = "";

        public PontajVoluntarExistentcs()
        {
            InitializeComponent();
            //numarTelefonVoluntar = telefonVoluntar;
            numeleVoluntaruluiLabel.Text = getVolunteerNameFromDB();
            oreDeActivitateLabel.Text = oreTotalePentruUI().ToString();
            dataCurentaLabel.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void OradeIntrare_Click(object sender, EventArgs e)
        {

        }

        //Get name


        private void buttonConfirmPontajVExistent_Click(object sender, EventArgs e)
        {
            //if true
            //WSendExistingVolunteerData();
            //if false
             //MessageBox
        }



        public static string getVolunteerNameFromDB()
        {
            string volunteerName = "";
            string queryString = "SELECT [FirstName] FROM [dbo].[Volunteers] WHERE [PhoneNumber]=751049326;";

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
        public static string ReadSingleRow(IDataRecord dataRecord)
        {
            String result = (String.Format("{0}", dataRecord[0]));
            return result;
        }

        public static string getVolunteerIDFromDB()
        {
            string volunteerID = "";
            string queryString = "SELECT [ObjectID] FROM [dbo].[Volunteers] WHERE [PhoneNumber]=0751049326;";

            using (SqlConnection cnn = SingletonDB.GetDBConnection())
            {
                SqlCommand command =
                    new SqlCommand(queryString, cnn);
                cnn.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    volunteerID = ReadSingleRow((IDataRecord)reader);
                }

                // Call Close when done reading.
                reader.Close();
            }

            return volunteerID;
        }

        private string FormatDateTime(String time)
        {
            DateTime currentDate = DateTime.Now;

            string an = currentDate.Year.ToString();
            string luna = currentDate.Month.ToString();
            string zi = currentDate.Day.ToString();
            string ora = currentDate.Hour.ToString();
            string minut = currentDate.Minute.ToString();
            string secunda = "00";

            string dateformat = an;
            dateformat = dateformat + "-";
            dateformat = dateformat + luna;
            dateformat = dateformat + "-";
            dateformat = dateformat + zi;
            dateformat = dateformat + " ";
            dateformat = dateformat + ora;
            dateformat = dateformat + ":";
            dateformat = dateformat + minut;
            dateformat = dateformat + ":";
            dateformat = dateformat + secunda;


            return dateformat;
        }


        private string oreTotalePentruUI()
        {
            TimeSpan interval = dateTimePickerIesire.Value.Subtract(dateTimePickerIntrare.Value);

            string dec = interval.Hours.ToString();
            return dec;
        }

        private decimal oreTotalePentruDB()
        {
            TimeSpan timeSpan = dateTimePickerIesire.Value.Subtract(dateTimePickerIntrare.Value);

            decimal dec = Convert.ToDecimal(timeSpan);
            return dec;
        }

        //public
        //static int SendExistingVolunteerData()
        //{
        //    try
        //    {
        //        SqlConnection cnn = SingletonDB.GetDBConnection();
        //        SingletonDB.OpenDatabaseConnection();
        //        using (SqlCommand cmd = new("dbo.InsertTimesheet", cnn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add("@IDVolunteer", SqlDbType.Int).Value = getVolunteerIDFromDB();
        //            cmd.Parameters.Add("@EntryDateTime", SqlDbType.DateTime).Value = dataIntrare;
        //            cmd.Parameters.Add("@ExitDateTime ", SqlDbType.DateTime).Value = dataIesire);
        //            cmd.Parameters.Add("@TotalHours ", SqlDbType.TinyInt).Value = oreTotalePentruDB();
        //            int rowsAffected = cmd.ExecuteNonQuery();
        //            cmd.Dispose();
        //        }
        //        return 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Can not open connection ! ");
        //        return -1;
        //    }
        //}

        private void dateTimePickerIntrare_ValueChanged(object sender, EventArgs e)
        {
            dataIntrare = FormatDateTime(dateTimePickerIesire.ToString());
            oreDeActivitateLabel.Text = oreTotalePentruUI().ToString();
        }

        private void dateTimePickerIesire_ValueChanged(object sender, EventArgs e)
        {
            dataIesire = FormatDateTime(dateTimePickerIntrare.ToString());
            oreDeActivitateLabel.Text = oreTotalePentruUI().ToString();
        }
    }
}
