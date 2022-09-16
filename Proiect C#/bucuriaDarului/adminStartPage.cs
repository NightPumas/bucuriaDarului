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
        public static string SetObjectIdForUpdate = "";
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

                        DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();

                        row.Cells[0].Value = reader.GetInt32(0);
                        row.Cells[1].Value = reader.GetString(1) + " " +  reader.GetString(2);
                        row.Cells[2].Value = reader.GetDateTime(3).ToShortDateString();
                        row.Cells[3].Value = reader.GetDecimal(4);
                        dataGridView.Rows.Add(row);
                    }
                }

            }
            SingletonDB.CloseDatabaseConnection();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetObjectIdForUpdate = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            EditVolunteerData EditVolunteerData = new EditVolunteerData();
            EditVolunteerData.ShowDialog();


            //MessageBox.Show(DataGridView.)
        }
    }
}
