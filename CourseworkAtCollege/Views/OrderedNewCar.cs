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
    public partial class OrderedNewCar : Form
    {
        public string typeOfCar;

        public OrderedNewCar()
        {
            InitializeComponent();
        }

        private void firstNameBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void lastNameBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void fatherNameBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void passportDataBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void phoneNumberBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void dateOfTheEndOfTheContractBox_TextChanged(object sender, EventArgs eventArgs) { }

        public static Client client = new Client();

        private void ordered_button_Click(object sender, EventArgs eventArgs)
        {
            client.firstName = firstNameBox.Text;
            client.lastName = lastNameBox.Text;
            client.fatherName = fatherNameBox.Text;
            client.passportData = passportDataBox.Text;
            client.dateOfTheEndOfTheContract = dateOfTheEndOfTheContractBox.Text;
            client.phoneNumber = phoneNumberBox.Text;
            client.typeOfCar = typeOfCar;

            DB dataBase = new DB();

            string commandForDataBase  = 
                "INSERT INTO `client` (" +
                    "`FirstName`, " +
                    "`LastName`, " +
                    "`FatherName`, " +
                    "`PassportData`, " +
                    "`EndOfContract`, " +
                    "`PhoneNumber`, " +
                    "`TypeOfCar`" +
                ") " +
                "VALUES (" +
                    "@firstName, " +
                    "@lastName, " +
                    "@fatherName, " +
                    "@passport, " +
                    "@endOfContract, " +
                    "@phoneNumber, " +
                    "@typeOfCar" +
                ");";
            MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = client.firstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = client.lastName;
            command.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = client.fatherName;
            command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = client.passportData;
            command.Parameters.Add("@endOfContract", MySqlDbType.VarChar).Value = client.dateOfTheEndOfTheContract;
            command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = client.phoneNumber;
            command.Parameters.Add("@typeOfCar", MySqlDbType.VarChar).Value = client.typeOfCar;

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1) { }

            dataBase.closeConnection();

            ResultOfOrdering resultOfOrderingVariable = new ResultOfOrdering();
            resultOfOrderingVariable.Show();
        }

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
        }

        private void OrderedNewCar_Load(object sender, EventArgs e)
        {

        }
    }
}
