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

        // Ініціалізація змінної, що зберігає 
        // інформацію про вибраний автомобіль
        public string typeOfCar;

        public OrderedNewCar()
        {
            InitializeComponent();
        }

        private void textForTypeOfCarComboBox(object sender, EventArgs eventArgs)
        {
            // Попереднє присвоєння для typeOfCarComboBox
            // в залежності від вибраного раніше типу автомобілів

            typeOfCarComboBox.Text = typeOfCar;
        }

        // Ініціалізація змінної за типом моделі клієнта
        public static Client client = new Client();

        private void ordered_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка завершення замовлення
            // та запису даних до бази даних

            // Присвоєння значень з полей для вводу інформації
            // до змінних моделі
            client.FirstName = firstNameBox.Text;
            client.LastName = lastNameBox.Text;
            client.FatherName = fatherNameBox.Text;
            client.PassportData = passportDataBox.Text;
            client.EndOfContract = dateOfTheEndOfTheContractBox.Text;
            client.PhoneNumber = phoneNumberBox.Text;
            if(typeOfCar == null) {
                // Перевірка змінної на наявність значення

                client.TypeOfCar = typeOfCarComboBox.Text;
            } else {
                client.TypeOfCar = typeOfCar;
            }

            // Ініціалізація змінної за типом класа для бази даних
            DB dataBase = new DB();

            // Створення запиту до бази даних
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

            // Ініціалізація змінної, що використовується 
            // для передачі запиту до бази даних
            MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

            // Передача всіх значень в запит для бази даних
            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = client.FirstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = client.LastName;
            command.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = client.FatherName;
            command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = client.PassportData;
            command.Parameters.Add("@endOfContract", MySqlDbType.VarChar).Value = client.EndOfContract;
            command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = client.PhoneNumber;
            command.Parameters.Add("@typeOfCar", MySqlDbType.VarChar).Value = client.TypeOfCar;

            // Відкриття з'єднання із SQL сервером
            dataBase.openConnection();

            // Перевірка на помилки при записі значень
            if(command.ExecuteNonQuery() == 1) { }

            // Закриття з'єднання із SQL сервером
            dataBase.closeConnection();

            // Перенаправлення на наступну сторінку
            this.Hide();
            ResultOfOrdering resultOfOrderingVariable = new ResultOfOrdering();
            resultOfOrderingVariable.Show();
        }

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
        }

        private void mainPage_button_Click(object sender, EventArgs e)
        {
            // Кнопка для перенесення на головне меню

            this.Hide();
            BasePage basePage = new BasePage();
            basePage.Show();
        }

        private void orderedCarsToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для переходу на сторінку замовлень

            this.Hide();
            OrderedCars orderedCars = new OrderedCars();
            orderedCars.Show();
        }

        private void AllInfoAboutOrdersToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для переходу на сторінку перегляду замовлених автомобілів

            this.Hide();
            AllInfoAboutOrders allInfoAboutOrders = new AllInfoAboutOrders();
            allInfoAboutOrders.Show();
        }

        private void OrderedNewCarToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для переходу на сторінку створення замовлення

            this.Hide();
            OrderedNewCar orderedNewCar = new OrderedNewCar();
            orderedNewCar.Show();
        }
    }
}
