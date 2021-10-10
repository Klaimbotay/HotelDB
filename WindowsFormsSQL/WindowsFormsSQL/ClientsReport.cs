using MySql.Data.MySqlClient;
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
    public partial class ClientsReport : Form
    {
        private readonly string connectStr = "server=localhost;user=root;database=hotel;password=130899";

        public ClientsReport()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            FillListClients();
        }

        private void FillListClients()
        {
            var visitors = new Dictionary<string, ListViewGroup>();

            foreach (var v in GetData())
            {
                if (!visitors.ContainsKey(v.PassportNumber))
                {
                    var roomSum = GetRoomSumById(v.ClientId); 
                    var title = v.Surname + " " + v.Name + " " + v.SecondName + 
                        " " + v.Adress + "   " + v.PassportNumber + "  " + roomSum + " руб.";
                    var group = new ListViewGroup(title, HorizontalAlignment.Left);
                    
                    visitors.Add(v.PassportNumber, group);
                }

                var lvi = new ListViewItem(v.StartDate.Substring(0, 10), visitors[v.PassportNumber]);
                lvi.SubItems.Add(v.EndDate.Substring(0, 10));
                lvi.SubItems.Add(v.RoomNumber);
                lvi.SubItems.Add(v.RoomSum);

                lvi.Tag = v.Id;
                listViewClients.Items.Add(lvi);

                listViewClients.Groups.Add(visitors[v.PassportNumber]);
            }
        }

        private IEnumerable<Visitor> GetData()
        {
            var connection = new MySqlConnection(connectStr);
            connection.Open();

            var command = @"call pr_report_clients()";
            var sqlCommand = new MySqlCommand(command, connection);
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "select * from tmpclients";

            var reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var visitor = new Visitor(reader[1].ToString(), reader[0].ToString(),
                    reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                    reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                    null, reader[8].ToString(), reader[9].ToString(), reader[10].ToString());

                yield return visitor;
            }

            connection.Close();
        }

        private string GetRoomSumById(string clientID)
        {
            var connection = new MySqlConnection(connectStr);
            connection.Open();
            var command = "select fltRoomSum from tblvisit where (intClientId = @id)";
            var sqlCommand = new MySqlCommand(command, connection);
            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = clientID;

            var reader = sqlCommand.ExecuteReader();
            var sum = 0;
            while (reader.Read())
            {
                sum += int.Parse(reader[0].ToString());
            }

            connection.Close();
            return sum.ToString();
        }

        private void listViewClients_ItemActivate(object sender, EventArgs e)
        {
            var listView = (ListView) sender;
            var visitID = listView.FocusedItem.Tag;
            
            var servicesForm = new ServicesForm(visitID.ToString());
            servicesForm.Show();
        }
    }
}
