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

        // Ініціалізація змінних, що зберігає 
        // інформацію про вибраний автомобіль
        public string typeOfCar;
        public string nameOfCar;

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
            string commandForDataBase =
                "select " +
                    "FirstName," +
                     "LastName," +
                     "FatherName," +
                     "PassportData," +
                     "StartOfContract," +
                     "EndOfContract " +
                     "PhoneNumber," +
                     "TypeOfCar," +
                     "NameOfCar," +
                "from client left join (" +
                    "customer left join contract on " +
                        "customer.idContract = contract.idContract " +
                ") " +
                "on client.idClient = customer.idClient; ";

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

                objectsFromDataBase.Add(new string[10]);

                objectsFromDataBase[objectsFromDataBase.Count - 1][0] = sqlReader[0].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][1] = sqlReader[1].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][2] = sqlReader[2].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][3] = sqlReader[3].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][4] = sqlReader[4].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][5] = sqlReader[5].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][6] = sqlReader[6].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][7] = sqlReader[7].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][8] = sqlReader[8].ToString();
                objectsFromDataBase[objectsFromDataBase.Count - 1][9] = sqlReader[9].ToString();
            }

            // Завершення роботи змінної для роботи із об'єктами
            sqlReader.Close();

            // Передача всіх отриманих об'єктів полям для вводу
            firstNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][1];
            lastNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][2];
            fatherNameBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][3];
            passportDataBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][4];
            dateOfTheStartOfTheContractBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][5];
            dateOfTheEndOfTheContractBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][6];
            phoneNumberBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][7];
            typeOfCarComboBox.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][8];
            nameOfCarComboBox_1.Text = objectsFromDataBase[objectsFromDataBase.Count - 1][9];

            // Закриття з'єднання із SQL сервером
            dataBase.closeConnection();
        }

        // Ініціалізація змінних за типом моделі
        public static Client client = new Client();
        public static AutoParkModel autoParkModel = new AutoParkModel();
        public static ContractModel contractModel = new ContractModel();

        private void ordered_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для зафіксування змін до бази даних

            // Присвоєння значень з полей для вводу інформації
            // до змінних моделі
            client.FirstName = firstNameBox.Text;
            client.LastName = lastNameBox.Text;
            client.FatherName = fatherNameBox.Text;
            client.PassportData = passportDataBox.Text;
            contractModel.StartOfContract = dateOfTheStartOfTheContractBox.Text;
            contractModel.EndOfContract = dateOfTheEndOfTheContractBox.Text;
            client.PhoneNumber = phoneNumberBox.Text;

            if (typeOfCar == null)
            {
                // Перевірка змінної на наявність значення

                autoParkModel.TypeOfCar = typeOfCarComboBox.Text;
            }
            else if (typeOfCarComboBox.Text != null)
            {
                autoParkModel.TypeOfCar = typeOfCarComboBox.Text;
            }
            else
            {
                autoParkModel.TypeOfCar = typeOfCar;
            }

            if (nameOfCar == null)
            {
                // Перевірка змінної на наявність значення

                client.NameOfCar = nameOfCarComboBox_1.Text;
                autoParkModel.NameOfCar = nameOfCarComboBox_1.Text;
            }
            else if (nameOfCarComboBox_1.Text != null)
            {
                client.NameOfCar = nameOfCarComboBox_1.Text;
                autoParkModel.NameOfCar = nameOfCarComboBox_1.Text;
            }
            else
            {
                client.NameOfCar = nameOfCar;
                autoParkModel.NameOfCar = nameOfCar;
            }

            // Ініціалізація змінної за типом класа для бази даних
            DB dataBase = new DB();

            // Створення запиту до бази даних
            string commandForDataBase =
                "update autopark set " +
                    "TypeOfCar = @typeOfCar, " +
                    "NameOfCar = @nameOfCarAutoPark " +
                "where idCar=(select customer.idCar from customer where idClient=@idClient);" +
                "update contract set " +
                    "StartOfContract = @startOfContract, " +
                    "EndOfContract = @endOfContract " +
                "where idContract = (select customer.idContract from customer where idClient = @idClient); " +
                "update client set " +
                    "FirstName = @firstName, " +
                    "LastName = @lastName, " +
                    "FatherName = @fatherName, " +
                    "PassportData = @passport, " +
                    "PhoneNumber = @phoneNumber, " +
                    "NameOfCar = @nameOfCarClient " +
                "where idClient = @idClient;";

            // Ініціалізація змінної, що використовується 
            // для передачі запиту до бази даних
            MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

            // Передача всіх значень в запит для бази даних
            command.Parameters.Add("@idClient", MySqlDbType.VarChar).Value = clientID;
            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = client.FirstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = client.LastName;
            command.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = client.FatherName;
            command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = client.PassportData;
            command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = client.PhoneNumber;
            command.Parameters.Add("@nameOfCarClient", MySqlDbType.VarChar).Value = client.NameOfCar;

            command.Parameters.Add("@typeOfCar", MySqlDbType.VarChar).Value = autoParkModel.TypeOfCar;
            command.Parameters.Add("@nameOfCarAutoPark", MySqlDbType.VarChar).Value = autoParkModel.NameOfCar;

            command.Parameters.Add("@startOfContract", MySqlDbType.VarChar).Value = contractModel.StartOfContract;
            command.Parameters.Add("@endOfContract", MySqlDbType.VarChar).Value = contractModel.EndOfContract;

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

        private void nameOfCarComboBox_Click(object sender, EventArgs eventArgs)
        {

        }

        private void changingNamesOfCars(object sender, EventArgs eventArgs)
        {
            if (typeOfCar == "Економ клас")
            {
                nameOfCarComboBox_1.Items.Clear();
                nameOfCarComboBox_1.Items.AddRange(new object[] {
                    "Fiat Abarth 500",
                    "Volkswagen Suran",
                    "Mini Cooper Clubman",
                    "Suzuki Swift"});
            }
            else if (typeOfCar == "Середній клас")
            {
                nameOfCarComboBox_1.Items.Clear();
                nameOfCarComboBox_1.Items.AddRange(new object[] {
                    "Toyota Corolla",
                    "Honda Civic",
                    "BMW 520",
                    "Volkswagen Polo SE"});
            }
            else if (typeOfCar == "Позашляховик")
            {
                nameOfCarComboBox_1.Items.Clear();
                nameOfCarComboBox_1.Items.AddRange(new object[] {
                    "BMX X6",
                    "Audi Q3",
                    "Ford Explorer",
                    "Hyundai Tucson"});
            }
            else if (typeOfCar == "Преміум клас")
            {
                nameOfCarComboBox_1.Items.Clear();
                nameOfCarComboBox_1.Items.AddRange(new object[] {
                    "Audi A6",
                    "Mercedes-Benz С180",
                    "Volkswagen Arteon R-line",
                    "Skoda Suberb"});
            }
        }

        private void typeOfCarComboBox_Click(object sender, EventArgs eventArgs)
        {
            nameOfCarComboBox_1.Text = null;
        }
    }
}
