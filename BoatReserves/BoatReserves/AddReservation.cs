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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String sailorID = SIDTextBox.Text;
            String boatID = BIDTextBox.Text;
            String date = dateTextBox.Text;

            try
            {
                String insertStmt = "insert into Reserves values(" + "'" + sailorID + "'" + "," + "'" + boatID + "'" + "," + "'" + date + "'" + ")";
                SqlCommand cmd = new SqlCommand(insertStmt, DataBaseInfo.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                String message = "Reservation was successfully added to database";
                MessageBox.Show(message, date, MessageBoxButtons.OK, MessageBoxIcon.Information);


                SIDTextBox.Clear();
                BIDTextBox.Clear();
                dateTextBox.Clear();

            }

            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Error Adding Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
