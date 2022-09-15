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
    public partial class adminStartPage : Form
    {
        public adminStartPage()
        {
            InitializeComponent();
            populateTable();
        }


        void populateTable()
        {
            SqlConnection cnn = SingletonDB.GetDBConnection();
            SingletonDB.OpenDatabaseConnection();
            using (SqlCommand cmd = new("dbo.PersonView", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                typeOfUser = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
            }
            SingletonDB.CloseDatabaseConnection();
            return typeOfUser;





        }


    }
}
