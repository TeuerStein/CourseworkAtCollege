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

namespace CourseworkAtCollege
{
    public partial class AllInfoAboutOrders : Form
    {

        public AllInfoAboutOrders()
        {
            InitializeComponent();

            GettingAllObjectsFromDataBase();
        }

        private void GettingAllObjectsFromDataBase()
        {
            // Метод для виведення всієї інформації
            // про замовлення з бази даних
            // до таблиці (тобто до dataGridView)

            // Ініціалізація змінної за типом класа для бази даних
            DB dataBase = new DB();

            // Відкриття з'єднання із SQL сервером
            dataBase.openConnection();

            try
            {
                // Створення запиту до бази даних
                string commandForDataBase =
                    "select  FirstName,LastName,FatherName,PassportData,PhoneNumber,NameOfCar,StartOfContract,EndOfContract from client inner join (customer inner join contract on customer.idContract = contract.idContract ) on client.idClient = customer.idClient; ";



                // Ініціалізація змінної, що використовується 
                // для передачі запиту до бази даних
                MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

                // Ініціалізація змінної для роботи 
                // із об'єктами, переданими із бази даних
                MySqlDataReader sqlReader = command.ExecuteReader();

                // Ініціалізація змінної для вміщення об'єктів із бази даних
                List<string[]> objectsFromDataBase = new List<string[]>();

                while (sqlReader.Read())
                {
                    // Процес присвоєння одного об'єкта за другим в масив

                    objectsFromDataBase.Add(new string[9]);

                    objectsFromDataBase[objectsFromDataBase.Count - 1][0] = sqlReader[0].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][1] = sqlReader[1].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][2] = sqlReader[2].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][3] = sqlReader[3].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][4] = sqlReader[4].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][5] = sqlReader[5].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][6] = sqlReader[6].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][7] = sqlReader[1].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][8] = sqlReader[2].ToString();
                }

                // Завершення роботи змінної для роботи із об'єктами
                sqlReader.Close();

                try
                {
                    // Передача всіх отриманих об'єктів до таблиці (тобто до dataGridView)

                    foreach (string[] singleObjectFromDataBaseForEach in objectsFromDataBase)
                        dataGridView1.Rows.Add(singleObjectFromDataBaseForEach);
                } catch {

                    // Повернення помилки в логи консолі 
                    // для подальшого виправлення можливих помилок
                    Console.WriteLine("You have some problems with dataGridView");
                }

            } catch(MySqlException exception) {

                // Повернення помилки в логи консолі 
                // для подальшого виправлення можливих помилок
                Console.WriteLine(exception.Message);
            } finally {

                // Закриття з'єднання із SQL сервером
                dataBase.closeConnection();
            }

        }

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs eventArgs)
        {

            // Ініціалізація змінної для передачі 
            // введеного значення до рядка пошуку
            string resultOfSearch = textBox1.Text;

            // Ініціалізація змінної за типом класа для бази даних
            DB dataBase = new DB();

            // Відкриття з'єднання із SQL сервером
            dataBase.openConnection();

            try
            {
                
                // Ініціалізація змінної для 
                // передачі запитів до бази даних
                string commandForDataBase;

                if (textBox1.Text == null)
                {

                    // Якщо поле пошуку пусте, 
                    // то будуть виведені всі об'єкти
                    commandForDataBase = "select * from client;";
                } else {

                    // Створення запиту за, введеними у рядок пошуку, даними
                    commandForDataBase = "Select * from client where FirstName like '" + textBox1.Text + "%' ;";
                }

                // Ініціалізація змінної, що використовується 
                // для передачі запиту до бази даних
                MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

                // Очищуємо попередню інформацію
                // з таблиці
                dataGridView1.Rows.Clear();

                // Ініціалізація змінної для роботи 
                // із об'єктами, переданими із бази даних
                MySqlDataReader sqlReader = command.ExecuteReader();

                // Ініціалізація змінної для вміщення об'єктів із бази даних
                List<string[]> objectsFromDataBase = new List<string[]>();

                while (sqlReader.Read())
                {
                    // Процес присвоєння одного об'єкта за другим в масив

                    objectsFromDataBase.Add(new string[9]);

                    objectsFromDataBase[objectsFromDataBase.Count - 1][0] = sqlReader[0].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][1] = sqlReader[1].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][2] = sqlReader[2].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][3] = sqlReader[3].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][4] = sqlReader[4].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][5] = sqlReader[5].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][6] = sqlReader[6].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][7] = sqlReader[7].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][8] = sqlReader[8].ToString();
                }

                // Завершення роботи змінної для роботи із об'єктами
                sqlReader.Close();

                try
                {
                    // Передача всіх отриманих об'єктів до таблиці (тобто до dataGridView)

                    foreach (string[] singleObjectFromDataBaseForEach in objectsFromDataBase)
                        dataGridView1.Rows.Add(singleObjectFromDataBaseForEach);
                }
                catch
                {

                    // Повернення помилки в логи консолі 
                    // для подальшого виправлення можливих помилок
                    Console.WriteLine("You have problems with dataGridView");
                }

            } catch (MySqlException exception) {

                // Повернення помилки в логи консолі 
                // для подальшого виправлення можливих помилок
                Console.WriteLine(exception.Message);
            } finally {

                // Закриття з'єднання із SQL сервером
                dataBase.closeConnection();
            }

        }

        private void creatingButton_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для перенесення користувача на 
            // сторінку створення нового замовлення

            this.Hide();
            OrderedNewCar orderedNewCar = new OrderedNewCar();
            orderedNewCar.Show();
        }

        private void changingButton_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для перенесення користувача на 
            // сторінку редагування вибраного замовлення

            int clientID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            this.Hide();

            ChangingObjectPage changingObjectPage = new ChangingObjectPage();
            changingObjectPage.clientID = clientID;
            changingObjectPage.Show();
        }

        private void mainPage_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для перенесення на головне меню

            this.Hide();
            BasePage basePage = new BasePage();
            basePage.Show();
        }

        private void deletingButton_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для видалення вибраного замовлення

            // Ініціалізація змінної для передачі ID вибраного замовлення
            int clientID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            // Ініціалізація змінної за типом класа для бази даних
            DB dataBase = new DB();

            // Створення запиту до бази даних
            string commandForDataBase = string.Format("DELETE FROM client WHERE idClient = {0}", clientID);

            // Відкриття з'єднання із SQL сервером
            dataBase.openConnection();

            using ( MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection()) ){
                try
                {

                    // Видалення, вибраного користувачем,
                    // замовлення з бази даних
                    command.ExecuteNonQuery();
                } catch (MySqlException mySQLException) {

                    // При помилці видалення - 
                    // передати повідомлення про саму помилку
                    Exception error = new Exception("Program wasn't deleted this object!", mySQLException);
                    throw error;
                }
            }

            // Закриття з'єднання із SQL сервером
            dataBase.closeConnection();

            // Перенесення користувача на сторінку
            // із таблицею (тобто dataGridView)
            this.Hide();
            AllInfoAboutOrders allInfoAboutOrders = new AllInfoAboutOrders();
            allInfoAboutOrders.Show();
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
