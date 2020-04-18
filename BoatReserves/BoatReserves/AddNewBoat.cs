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
    public partial class AddNewBoat : Form
    {
        public AddNewBoat()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String boatID = BIDTextBox.Text;
            String boatName = bNameTextBox.Text;
            String boatColor = bColorTextBox.Text;

            try
            {
                String insertStmt = "insert into BOATS values(" + "'" + boatID + "'" + "," + "'" + boatName + "'" + "," + "'" + boatColor + "'" + ")";
                SqlCommand cmd = new SqlCommand(insertStmt, DataBaseInfo.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                String message = "Boat was successfully added to database";
                MessageBox.Show(message, boatName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                BIDTextBox.Clear();
                bNameTextBox.Clear();
                bColorTextBox.Clear();

            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error adding Boat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

        } // end submit button

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
