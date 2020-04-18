using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatReserves
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (addSailorRadioButton.Checked)
            {
                AddNewSailor frm = new AddNewSailor();
                frm.Show();
            }

            else if (addBoatRadioButton.Checked)
            {
                AddNewBoat frm = new AddNewBoat();
                frm.Show();
            }

            else if (addReservationRadioButton.Checked)
            {

                AddReservation frm = new AddReservation();
                frm.Show();

            }

            else {
                ViewReservation frm = new ViewReservation();
                frm.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DataBaseInfo.con.Close();
            DataBaseInfo.con.Dispose();
            this.Hide();
            Application.Exit();
        }
    }
}
