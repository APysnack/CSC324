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
    public partial class ReservationInfo : Form
    {
        public ReservationInfo(DataTable dtbl)
        {
            InitializeComponent();
            dataGridView.DataSource = dtbl;
            dataGridView.AutoGenerateColumns = false;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
