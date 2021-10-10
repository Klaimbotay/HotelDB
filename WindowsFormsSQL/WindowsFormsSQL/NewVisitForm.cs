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
    public partial class NewVisitForm : Form
    {
        private readonly string connectStr = "server=localhost;user=root;database=hotel;password=130899";
        private MySqlConnection connection;
        public NewVisitForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (startDate.Text.Length == 0 || endDate.Text.Length == 0 ||
                name.Text.Length == 0 || surname.Text.Length == 0 ||
                secondName.Text.Length == 0 || clientAdress.Text.Length == 0 ||
                passportNumber.Text.Length == 0 ||
                livingSum.Text.Length == 0 || roomNumber.Text.Length == 0) return;

            connection = new MySqlConnection(connectStr);
            connection.Open();

            var command = "INSERT INTO `tblclient` (`txtClientSurname`, `txtClientName`, `txtClientSecondName`, `txtClientAdress`, `txtPassportNumber`) VALUES (@surname, @name, @secondName, @adress, @passportNumber)";
            var sqlCommand = new MySqlCommand(command, connection);
            sqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            sqlCommand.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            sqlCommand.Parameters.Add("@secondName", MySqlDbType.VarChar).Value = secondName.Text;
            sqlCommand.Parameters.Add("@adress", MySqlDbType.VarChar).Value = clientAdress.Text;
            sqlCommand.Parameters.Add("@passportNumber", MySqlDbType.VarChar).Value = passportNumber.Text;

            var transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка добавления нового клиента", error.Message, MessageBoxButtons.OK);
            }

            var lastID = GetLastIndex();

            var command1 = "INSERT INTO `tblvisit` (`intClientId`, `intRoomNumber`, `datBegin`, `datEnd`, `fltRoomSum`, `fltServiceSum`) VALUES(@clientId, @room, @datBegin, @datEnd, @roomSum, 0)";
            var sqlCommand3 = new MySqlCommand(command1, connection);
            sqlCommand3.Parameters.Add("@clientId", MySqlDbType.Int32).Value = lastID;
            sqlCommand3.Parameters.Add("@room", MySqlDbType.Int32).Value = int.Parse(roomNumber.Text);
            sqlCommand3.Parameters.Add("@datBegin", MySqlDbType.Date).Value = startDate.Text;
            sqlCommand3.Parameters.Add("@datEnd", MySqlDbType.Date).Value = endDate.Text;
            sqlCommand3.Parameters.Add("@roomSum", MySqlDbType.Decimal).Value = double.Parse(livingSum.Text);

            var otherTransaction = connection.BeginTransaction();
            sqlCommand.Transaction = otherTransaction;

            try
            {
                sqlCommand3.ExecuteNonQuery();
                otherTransaction.Commit();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Ошибка добавления", error.Message, MessageBoxButtons.OK);
            }
            finally
            {
                connection.Close();
                Application.Restart();
            }
        }

        private int GetLastIndex()
        {
            var command = "SELECT max(intClientId) FROM tblclient";
            var sqlCommand = new MySqlCommand(command, connection);
            var maxId = sqlCommand.ExecuteScalar();

            return int.Parse(maxId.ToString());
        }
    }
}
