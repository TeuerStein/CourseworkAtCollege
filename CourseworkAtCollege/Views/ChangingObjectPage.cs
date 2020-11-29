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

namespace CourseworkAtCollege
{
    public partial class ChangingObjectPage : Form
    {
        public Client selectedObject = new Client();
        public int clientID;

        public ChangingObjectPage()
        {
            InitializeComponent();

        }

        private void oldInfoAboutObject(object sender, EventArgs eventArgs)
        {
            DB dataBase = new DB();
            dataBase.openConnection();

            string commandForDataBase = "SELECT * FROM client WHERE  idClient = @idClient;";
            MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

            command.Parameters.Add("@idClient", MySqlDbType.Int32).Value = clientID;

            MySqlDataReader sqlReader = command.ExecuteReader();
            List<string[]> objectsFromDataBase = new List<string[]>();

            while (sqlReader.Read())
            {
                objectsFromDataBase.Add(new string[8]);

                objectsFromDataBase[objectsFromDataBase.Count - 1][0] = sqlReader[0].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][1] = sqlReader[1].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][2] = sqlReader[2].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][3] = sqlReader[3].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][4] = sqlReader[4].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][5] = sqlReader[5].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][6] = sqlReader[6].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][7] = sqlReader[7].ToString();
            }

            sqlReader.Close();

            firstNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][1];
            lastNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][2];
            fatherNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][3];
            passportDataBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][4];
            phoneNumberBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][5];
            dateOfTheEndOfTheContractBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][6];
            typeOfCarComboBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][7];

            dataBase.closeConnection();
        }

        private void ChangingObjectPage_Load(object sender, EventArgs e)
        {
        }

        private void ordered_button_Click(object sender, EventArgs eventArgs)
        {
        }

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
        }

        public static Client client = new Client();

        private void ordered_button_Click_1(object sender, EventArgs eventArgs)
        {
            client.FirstName = firstNameBox.Text;
            client.LastName = lastNameBox.Text;
            client.FatherName = fatherNameBox.Text;
            client.PassportData = passportDataBox.Text;
            client.EndOfContract = dateOfTheEndOfTheContractBox.Text;
            client.PhoneNumber = phoneNumberBox.Text;
            // client.typeOfCar = typeOfCar;

            DB dataBase = new DB();

            string commandForDataBase =
                "UPDATE client" +
                "SET" +
                    "FirstName = 'My'," +
                    "LastName = 'Berem'," +
                    "FatherName = 'Erysalim'," +
                    "PassportData = 'Segodnia'," +
                    "EndOfContract = 'AAAAAAAAA'," +
                    "PhoneNumber = 'Xrest'," +
                    "TypeOfCar = 'SlavaIsysy'" +
                "WHERE" +
                    "idClient = 1;";
            MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = client.FirstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = client.LastName;
            command.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = client.FatherName;
            command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = client.PassportData;
            command.Parameters.Add("@endOfContract", MySqlDbType.VarChar).Value = client.EndOfContract;
            command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = client.PhoneNumber;
            command.Parameters.Add("@typeOfCar", MySqlDbType.VarChar).Value = client.TypeOfCar;

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1) { }

            dataBase.closeConnection();

            ResultOfOrdering resultOfOrderingVariable = new ResultOfOrdering();
            resultOfOrderingVariable.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {

        }
    }
}
