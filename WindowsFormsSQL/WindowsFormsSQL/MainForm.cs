using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSQL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void visitors_btn_Click(object sender, EventArgs e)
        {
            var visitorsForm = new VisitorsForm();
            visitorsForm.Show();
        }

        private void clientsReport_bnt_Click(object sender, EventArgs e)
        {
            var clientsReport = new ClientsReport();
            clientsReport.Show();
        }
    
        private void servicesReport_btn_Click(object sender, EventArgs e)
        {
            var servicesReport = new ServicesReport();
            servicesReport.Show();
        }

        private void roomsReport_bnt_Click(object sender, EventArgs e)
        {
            var roomNumber = roomNumberSlider.Value.ToString();
            var roomReport = new RoomReport(roomNumber);
            roomReport.Show();
        }
    }
}
