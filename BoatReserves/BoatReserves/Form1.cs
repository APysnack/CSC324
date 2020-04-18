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
    public partial class Form1 : Form
    {

        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userID = userIDTXB.Text;
            string password = passwordTXB.Text;

            string conDB = "Data Source = DESKTOP-L6AUHPQ; Initial Catalog = Boat_Reserves; Persist Security Info = True; User ID = " + userID + "; Password = " + password;

            try
            {
                DataBaseInfo.con = new SqlConnection(conDB);
                DataBaseInfo.con.Open();
                DashBoard frm = new DashBoard();
                frm.Show();
            }

            catch (Exception ex) {

                string title = "Database Connection";
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                userIDTXB.Clear();
                passwordTXB.Clear();

            }
        } // end login button

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Dispose();
                this.Hide();
                Application.Exit();
            }

            catch (Exception) {
                this.Hide();
                Application.Exit();
            }
        }
    }
}
