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

        // Ініціалізація змінних, що зберігає 
        // інформацію про вибраний автомобіль
        public string typeOfCar;
        public string nameOfCar;

        public OrderedNewCar()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(textForTypeOfCarComboBox);

            this.Load += new System.EventHandler(changingNamesOfCars);

            this.Load += new System.EventHandler(textForNameOfCarComboBox);
        }

        private void textForTypeOfCarComboBox(object sender, EventArgs eventArgs)
        {
            // Попереднє присвоєння для typeOfCarComboBox
            // в залежності від вибраного раніше типу автомобілів

            typeOfCarComboBox.Text = typeOfCar;
        }

        private void textForNameOfCarComboBox(object sender, EventArgs eventArgs)
        {
            // Попереднє присвоєння для nameOfCarComboBox_1
            // в залежності від вибраного раніше автомобіля

            nameOfCarComboBox_1.Text = nameOfCar;
        }

        // Ініціалізація змінних за типом моделі
        public static Client client = new Client();
        public static AutoParkModel autoParkModel = new AutoParkModel();
        public static ContractModel contractModel = new ContractModel();

        private void ordered_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка завершення замовлення
            // та запису даних до бази даних

            // Присвоєння значень з полей для вводу інформації
            // до змінних моделі
            if(
                firstNameBox.Text != null && firstNameBox.Text != "" &&
                lastNameBox.Text != null && lastNameBox.Text != "" &&
                fatherNameBox.Text != null && fatherNameBox.Text != "" &&
                passportDataBox.Text != null && passportDataBox.Text != "" &&
                dateOfTheStartOfTheContractBox.Text != null && dateOfTheStartOfTheContractBox.Text != "" &&
                dateOfTheEndOfTheContractBox.Text != null && dateOfTheEndOfTheContractBox.Text != "" &&
                phoneNumberBox.Text != null && phoneNumberBox.Text != ""
            )
            {
                client.FirstName = firstNameBox.Text;
                client.LastName = lastNameBox.Text;
                client.FatherName = fatherNameBox.Text;
                client.PassportData = passportDataBox.Text;
                contractModel.StartOfContract = dateOfTheStartOfTheContractBox.Text;
                contractModel.EndOfContract = dateOfTheEndOfTheContractBox.Text;
                client.PhoneNumber = phoneNumberBox.Text;
            } else {
                MessageBox.Show("Ви не вказали, як мінімум, одне із значень", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Hide();
                MultipleChooserPage multipleChooserPage = new MultipleChooserPage();
                multipleChooserPage.Show();
            }

            if(typeOfCar == null) {
                // Перевірка змінної на наявність значення

                autoParkModel.TypeOfCar = typeOfCarComboBox.Text;
            } else if(typeOfCarComboBox.Text != null) {
                autoParkModel.TypeOfCar = typeOfCarComboBox.Text;
            } else {
                autoParkModel.TypeOfCar = typeOfCar;
            }

            if (nameOfCar == null) {
                // Перевірка змінної на наявність значення

                client.NameOfCar = nameOfCarComboBox_1.Text;
                autoParkModel.NameOfCar = nameOfCarComboBox_1.Text;
            } else if(nameOfCarComboBox_1.Text != null) {
                client.NameOfCar = nameOfCarComboBox_1.Text;
                autoParkModel.NameOfCar = nameOfCarComboBox_1.Text;
            } else {
                client.NameOfCar = nameOfCar;
                autoParkModel.NameOfCar = nameOfCar;
            }

            // Ініціалізація змінної за типом класа для бази даних
            DB dataBase = new DB();

            // Запис інформації до таблиці client

            // Створення запиту до бази даних
            string commandForDataBase =
                "INSERT INTO client (`FirstName`,`LastName`,`FatherName`,`PassportData`,`PhoneNumber`,`NameOfCar`) " +
                "VALUES(@firstName, @lastName, @fatherName, @passport, @phoneNumber, @nameOfCarClient); " +
                "INSERT INTO autopark(`TypeOfCar`, `NameOfCar`) " +
                "VALUES(@typeOfCar, @nameOfCarAutoPark); " +
                "INSERT INTO contract(`StartOfContract`, `EndOfContract`) " +
                "VALUES(@startOfContract, @endOfContract);" +
                "commit;" +
                "INSERT INTO customer(`idCar`, `idContract`, `idClient`) " +
                "VALUES((select max(idCar) from autopark) ,(select max(idContract) from contract), (select max(idClient) from client)); ";

            // Ініціалізація змінної, що використовується 
            // для передачі запиту до бази даних
            MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

            // Передача всіх значень в запит для бази даних
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
            bool otherList = false;

            if (typeOfCarComboBox.Text == "Економ клас")
            {
                nameOfCarComboBox_1.Items.Clear();
                nameOfCarComboBox_1.Items.AddRange(new object[] {
                    "Fiat Abarth 500",
                    "Volkswagen Suran",
                    "Mini Cooper Clubman",
                    "Suzuki Swift"});
            }
            else if (typeOfCarComboBox.Text == "Середній клас")
            {
                nameOfCarComboBox_1.Items.Clear();
                nameOfCarComboBox_1.Items.AddRange(new object[] {
                    "Toyota Corolla",
                    "Honda Civic",
                    "BMW 520",
                    "Volkswagen Polo SE"});
            }
            else if (typeOfCarComboBox.Text == "Позашляховик")
            {
                nameOfCarComboBox_1.Items.Clear();
                nameOfCarComboBox_1.Items.AddRange(new object[] {
                    "BMX X6",
                    "Audi Q3",
                    "Ford Explorer",
                    "Hyundai Tucson"});
            }
            else if (typeOfCarComboBox.Text == "Преміум клас")
            {
                nameOfCarComboBox_1.Items.Clear();
                nameOfCarComboBox_1.Items.AddRange(new object[] {
                    "Audi A6",
                    "Mercedes-Benz С180",
                    "Volkswagen Arteon R-line",
                    "Skoda Suberb"});
            }

            for (int count = 0; count < 4; count++)
            {
                if (nameOfCar == (nameOfCarComboBox_1.Items[count]).ToString())
                {
                    otherList = true;
                    break;
                }
            }
            if (otherList == false)
            {
                nameOfCarComboBox_1.Text = nameOfCar;
            }
            else
            {
                nameOfCarComboBox_1.Text = (nameOfCarComboBox_1.Items[0]).ToString();
            }
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
