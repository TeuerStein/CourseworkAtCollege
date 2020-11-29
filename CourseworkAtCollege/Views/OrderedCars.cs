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
            DB dataBase = new DB();
            dataBase.openConnection();

            try
            {
                string commandForDataBase = "Select FirstName, LastName, EndOfContract, TypeOfCar from client ORDER BY TypeOfCar;";
                MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

                MySqlDataReader sqlReader = command.ExecuteReader();

                List<string[]> objectsFromDataBase = new List<string[]>();

                while (sqlReader.Read())
                {
                    objectsFromDataBase.Add(new string[4]);

                    objectsFromDataBase[objectsFromDataBase.Count - 1][0] = sqlReader[0].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][1] = sqlReader[1].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][2] = sqlReader[2].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][3] = sqlReader[3].ToString();
                }

                sqlReader.Close();

                try
                {
                    foreach (string[] singleObjectFromDataBaseForEach in objectsFromDataBase)
                        dataGridView1.Rows.Add(singleObjectFromDataBaseForEach);
                }
                catch
                {
                    Console.WriteLine("You have problems with dataGridView");
                }

            }
            catch (MySqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                dataBase.closeConnection();
            }

        }

        private void OrderedCars_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string resultOfSearch = textBox1.Text;

            DB dataBase = new DB();
            dataBase.openConnection();

            try
            {
                string commandForDataBase;

                if (textBox1.Text == null)
                {
                    commandForDataBase = "select FirstName, LastName, EndOfContract, TypeOfCar from client ORDER BY TypeOfCar;";
                }
                else
                {
                    commandForDataBase = "Select FirstName, LastName, EndOfContract, TypeOfCar from client where TypeOfCar like '" + textBox1.Text + "%' ORDER BY TypeOfCar;";
                }
                MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

                dataGridView1.Rows.Clear();

                MySqlDataReader sqlReader = command.ExecuteReader();

                List<string[]> objectsFromDataBase = new List<string[]>();

                while (sqlReader.Read())
                {
                    objectsFromDataBase.Add(new string[4]);

                    objectsFromDataBase[objectsFromDataBase.Count - 1][0] = sqlReader[0].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][1] = sqlReader[1].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][2] = sqlReader[2].ToString();
                    objectsFromDataBase[objectsFromDataBase.Count - 1][3] = sqlReader[3].ToString();
                }

                sqlReader.Close();

                try
                {
                    foreach (string[] singleObjectFromDataBaseForEach in objectsFromDataBase)
                        dataGridView1.Rows.Add(singleObjectFromDataBaseForEach);
                }
                catch
                {
                    Console.WriteLine("You have problems with dataGridView");
                }

            }
            catch (MySqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                dataBase.closeConnection();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainPage_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            BasePage basePage = new BasePage();
            basePage.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            // Кнопка для закриття програми

            this.Close();
        }
    }
}
