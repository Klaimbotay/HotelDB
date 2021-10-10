using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsSQL
{
    public partial class AddServiceForm : Form
    {
        private List<Service> services;
        private Service currentService;
        private Visitor visitor;
        private string date;

        public AddServiceForm(Visitor v)
        {
            InitializeComponent();
            fio_value.Text = v.Surname + " " + v.Name + " " + v.SecondName;
            room_value.Text = v.RoomNumber;
            sDate_value.Text = v.StartDate;
            eDate_value.Text = v.EndDate;

            services = GetServicesWithPrices();
            visitor = v;
            service_comboBox.Items.AddRange(services.Select(s => s.Name).ToArray());
        }

        private List<Service> GetServicesWithPrices()
        {
            var result = new List<Service>();
            var connectStr = "server=localhost;user=root;database=hotel;password=130899";
            var connection = new MySqlConnection(connectStr);
            connection.Open();

            var command = " select txtServiceTypeName, fltServiceTypePrice, intServiceTypeId from tblservicetype";
            var sqlCommand = new MySqlCommand(command, connection);

            var reader = sqlCommand.ExecuteReader();

            while(reader.Read())
                result.Add(new Service(reader[0].ToString(), int.Parse(reader[1].ToString()), reader[2].ToString()));

            connection.Close();

            return result;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (date == null)
                return;

            var connectStr = "server=localhost;user=root;database=hotel;password=130899";
            var connection = new MySqlConnection(connectStr);
            connection.Open();

            var command = "insert into tblservice (intServiceTypeId, intVisitId, intServiceCount, fltServiceSum, datServiceDate) values(@sId, @vId, @count, @sum, @date)";
            var sqlCommand = new MySqlCommand(command, connection);
            sqlCommand.Parameters.Add("@sId", MySqlDbType.Int32).Value = int.Parse(currentService.Id);
            sqlCommand.Parameters.Add("@vId", MySqlDbType.Int32).Value = int.Parse(visitor.Id);
            sqlCommand.Parameters.Add("@count", MySqlDbType.Int32).Value = int.Parse(amount_slider.Value.ToString());
            sqlCommand.Parameters.Add("@sum", MySqlDbType.Decimal).Value = decimal.Parse(sum_value.Text);
            sqlCommand.Parameters.Add("@date", MySqlDbType.Date).Value = date;

            var transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;

            try
            {
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "Ошибка добавления", MessageBoxButtons.OK);
            }
            finally
            {
                connection.Close();
                Close();
            }
        }

        private void amount_slider_ValueChanged(object sender, EventArgs e)
        {
            if (price_value.Text != "<стоимость>")
            {
                var sum = int.Parse(amount_slider.Value.ToString()) * 
                    int.Parse(price_value.Text);
                sum_value.Text = sum.ToString();
            }
        }

        private void service_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var service = service_comboBox.SelectedItem.ToString();

            currentService = services.Where(s => s.Name == service)
                                     .FirstOrDefault();

            price_value.Text = currentService.Price.ToString();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            date = e.Start.ToString()
                          .Remove(10, 8);
            var blocks = date.Split('.');

            date = blocks[2] + "-" + blocks[1] + "-" + blocks[0];
        }
    }
}
