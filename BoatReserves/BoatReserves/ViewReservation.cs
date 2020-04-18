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
    public partial class ViewReservation : Form
    {
        public ViewReservation()
        {
            InitializeComponent();
        }
        private void submitButton_Click(object sender, EventArgs e)
        {

            String query;
            String sailorID = SIDTextBox.Text;

            try {

                query = "select s.sname, r.bid, b.bname, b.color, r.day from sailors s, boats b, reserves r where s.sin = r.sid and b.bid = r.bid and r.sid = '" + sailorID.Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, DataBaseInfo.con);
                DataTable dtbl = new DataTable();
                sqldata.Fill(dtbl);

                ReservationInfo frm = new ReservationInfo(dtbl);
                frm.Show();

            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error Retrieving Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
