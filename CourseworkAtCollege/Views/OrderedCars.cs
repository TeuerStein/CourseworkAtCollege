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
    public partial class OrderedCars : Form
    {
        public OrderedCars()
        {
            InitializeComponent();

            gettingAllObjectsFromDataBase();
        }

        private void gettingAllObjectsFromDataBase()
        {
            // Метод для виведення інформації
            // про замовлені автомобілі
            // до таблиці (тобто до dataGridView)

            // Ініціалізація змінної за типом класа для бази даних
            DB dataBase = new DB();

            // Відкриття з'єднання із SQL сервером
            dataBase.openConnection();

            try
            {

                // Створення запиту до бази даних
                string commandForDataBase = "Select FirstName, LastName, EndOfContract, TypeOfCar from client ORDER BY TypeOfCar;";

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

                    objectsFromDataBase.Add(new string[4]);

                    objectsFromDataBase[objectsFromDataBase.Count - 1][0] = sqlReader[0].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][1] = sqlReader[1].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][2] = sqlReader[2].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][3] = sqlReader[3].ToString();
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
                    commandForDataBase = "select FirstName, LastName, EndOfContract, TypeOfCar from client ORDER BY TypeOfCar;";
                } else {

                    // Створення запиту за, введеними у рядок пошуку, даними
                    commandForDataBase = "Select FirstName, LastName, EndOfContract, TypeOfCar from client where TypeOfCar like '" + textBox1.Text + "%' ORDER BY TypeOfCar;";
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

                    objectsFromDataBase.Add(new string[4]);

                    objectsFromDataBase[objectsFromDataBase.Count - 1][0] = sqlReader[0].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][1] = sqlReader[1].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][2] = sqlReader[2].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][3] = sqlReader[3].ToString();
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

        private void mainPage_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для перенесення на головне меню

            this.Hide();
            BasePage basePage = new BasePage();
            basePage.Show();
        }

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
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
