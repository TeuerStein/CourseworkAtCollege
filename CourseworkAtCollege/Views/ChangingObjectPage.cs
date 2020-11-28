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

        public ChangingObjectPage()
        {
            InitializeComponent();

        }

        private void oldInfoAboutObject(object sender, EventArgs eventArgs)
        {
            firstNameBox.Text = selectedObject.firstName;
            lastNameBox.Text = selectedObject.lastName;
            fatherNameBox.Text = selectedObject.fatherName;
            passportDataBox.Text = selectedObject.passportData;
            phoneNumberBox.Text = selectedObject.phoneNumber;
            dateOfTheEndOfTheContractBox.Text = selectedObject.dateOfTheEndOfTheContract;
            typeOfCarComboBox.Text = selectedObject.typeOfCar;
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
            client.firstName = firstNameBox.Text;
            client.lastName = lastNameBox.Text;
            client.fatherName = fatherNameBox.Text;
            client.passportData = passportDataBox.Text;
            client.dateOfTheEndOfTheContract = dateOfTheEndOfTheContractBox.Text;
            client.phoneNumber = phoneNumberBox.Text;
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

            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = client.firstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = client.lastName;
            command.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = client.fatherName;
            command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = client.passportData;
            command.Parameters.Add("@endOfContract", MySqlDbType.VarChar).Value = client.dateOfTheEndOfTheContract;
            command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = client.phoneNumber;
            command.Parameters.Add("@typeOfCar", MySqlDbType.VarChar).Value = client.typeOfCar;

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
