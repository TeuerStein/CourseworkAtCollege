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

        // Ініціалізація змінної за типом моделі клієнта
        public Client selectedObject = new Client();

        // Ініціалізація змінної для
        // отримання ID із попередньої сторінки
        public int clientID;

        public ChangingObjectPage()
        {
            InitializeComponent();
        }

        private void oldInfoAboutObject(object sender, EventArgs eventArgs)
        {
            // Метод для редагування старої 
            // інформації про замовлення

            // Ініціалізація змінної за 
            // типом класа для бази даних
            DB dataBase = new DB();

            // Відкриття з'єднання із SQL сервером
            dataBase.openConnection();

            // Створення запиту до бази даних
            string commandForDataBase = "SELECT * FROM client WHERE  idClient = @idClient;";

            // Ініціалізація змінної, що використовується 
            // для передачі запиту до бази даних
            MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

            // Передача всіх значень в запит для бази даних
            command.Parameters.Add("@idClient", MySqlDbType.Int32).Value = clientID;

            // Ініціалізація змінної для роботи 
            // із об'єктами, переданими із бази даних
            MySqlDataReader sqlReader = command.ExecuteReader();

            // Ініціалізація змінної для вміщення об'єктів із бази даних
            List<string[]> objectsFromDataBase = new List<string[]>();

            while (sqlReader.Read())
            {
                // Процес присвоєння одного об'єкта за другим в масив

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

            // Завершення роботи змінної для роботи із об'єктами
            sqlReader.Close();

            // Передача всіх отриманих об'єктів полям для вводу
            firstNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][1];
            lastNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][2];
            fatherNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][3];
            passportDataBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][4];
            phoneNumberBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][5];
            dateOfTheEndOfTheContractBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][6];
            typeOfCarComboBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][7];

            // Закриття з'єднання із SQL сервером
            dataBase.closeConnection();
        }

        // Ініціалізація змінної за типом моделі клієнта
        public static Client client = new Client();

        private void ordered_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для зафіксування змін до бази даних

            // Передача змінених даних до 
            // змінних типу моделі клієнта
            client.FirstName = firstNameBox.Text;
            client.LastName = lastNameBox.Text;
            client.FatherName = fatherNameBox.Text;
            client.PassportData = passportDataBox.Text;
            client.EndOfContract = dateOfTheEndOfTheContractBox.Text;
            client.PhoneNumber = phoneNumberBox.Text;
            client.TypeOfCar = typeOfCarComboBox.Text;

            // Ініціалізація змінної за типом класа для бази даних
            DB dataBase = new DB();

            // Створення запиту до бази даних
            string commandForDataBase =
                "UPDATE client " +
                "SET " +
                    "FirstName = @firstName, " +
                    "LastName = @lastName, " +
                    "FatherName = @fatherName, " +
                    "PassportData = @passport, " +
                    "EndOfContract = @passport, " +
                    "PhoneNumber = @endOfContract, " +
                    "TypeOfCar = @typeOfCar " +
                "WHERE " +
                    "idClient = @idClient;";

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
            command.Parameters.Add("@idClient", MySqlDbType.VarChar).Value = clientID;

            // Відкриття з'єднання із SQL сервером
            dataBase.openConnection();

            // Перевірка на помилки при записі значень
            if (command.ExecuteNonQuery() == 1) { }

            // Закриття з'єднання із SQL сервером
            dataBase.closeConnection();

            // Виведення повідомлення про успішну зміну інформації
            MessageBox.Show("Зміни було записано", "Успіх!", MessageBoxButtons.OK);


            // Перенаправлення на наступну сторінку
            this.Hide();
            AllInfoAboutOrders allInfoAboutOrders = new AllInfoAboutOrders();
            allInfoAboutOrders.Show();
        }

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
        }

        private void mainPage_button_Click(object sender, EventArgs eventArgs)
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
