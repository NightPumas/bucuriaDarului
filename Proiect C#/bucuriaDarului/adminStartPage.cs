using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //DataGridViewRow row = new DataGridViewRow();
                        DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                        row.Cells[0].Value = reader.GetString(0);
                        row.Cells[1].Value = reader.GetString(1);
                        row.Cells[2].Value = reader.GetDateTime(2).ToShortDateString();
                        row.Cells[3].Value = reader.GetByte(3);
                        dataGridView.Rows.Add(row);
                    }
                }

            }
            SingletonDB.CloseDatabaseConnection();
        }


    }
}
