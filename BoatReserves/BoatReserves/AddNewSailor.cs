using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BoatReserves
{
    public partial class AddNewSailor : Form
    {
        public AddNewSailor()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String sailorID = SIDTextBox.Text;
            String sailorName = sNameTextBox.Text;
            String sailorRating = sRatingTextBox.Text;
            String sailorAge = sAgeTextBox.Text;

            try
            {
                String insertStmt = "insert into Sailors values(" + "'" + sailorID + "'" + "," + "'" + sailorName + "'" + "," + "'" + sailorRating + "'" + "," + "'" + sailorAge + "'" + ")";
                SqlCommand cmd = new SqlCommand(insertStmt, DataBaseInfo.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                String message = "Sailor successfully added to database";
                MessageBox.Show(message, sailorName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                SIDTextBox.Clear();
                sNameTextBox.Clear();
                sRatingTextBox.Clear();
                sAgeTextBox.Clear();
            }

            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error Adding Sailor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
