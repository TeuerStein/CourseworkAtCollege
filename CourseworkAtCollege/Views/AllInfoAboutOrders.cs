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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs eventArgs)
        {

        }

        private void GettingAllObjectsFromDataBase()
        {
            DB dataBase = new DB();
            dataBase.openConnection();

            try
            {
                string commandForDataBase = "select * from client;";
                MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

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

                try
                {
                    foreach (string[] singleObjectFromDataBaseForEach in objectsFromDataBase)
                        dataGridView1.Rows.Add(singleObjectFromDataBaseForEach);
                } catch
                {
                    Console.WriteLine("You have problems with dataGridView");
                }

            } catch(MySqlException exception) {
                Console.WriteLine(exception.Message);
            } finally {
                dataBase.closeConnection();
            }

        }

        public static Client client = new Client();

        private void ChanginObject(string selectedObject)
        {
            client.FirstName = null; // some firstName
            client.LastName = null; // some lastName
            client.FatherName = null; // some fatherName
            client.PassportData = null; // some passportData
            client.EndOfContract = null; // some dateOfTheEndOfTheContract
            client.PhoneNumber = null; // some phoneNumber
            client.TypeOfCar = null; // some typeOfCar

            DB dataBase = new DB();
            dataBase.openConnection();

            try
            {
                string commandForDataBase =
                    "UPDATE client" +
                    "SET" +
                        "FirstName = `@firstName`," +
                        "LastName = `@lastName`," +
                        "FatherName = `@fatherName`," +
                        "PassportData = `@passport`," +
                        "EndOfContract = `@endOfContract`," +
                        "PhoneNumber = `@phoneNumber`," +
                        "TypeOfCar = `@typeOfCar`" +
                    "WHERE" +
                        "idClient = @clientID; ";
                MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

                command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = client.FirstName;
                command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = client.LastName;
                command.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = client.FatherName;
                command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = client.PassportData;
                command.Parameters.Add("@endOfContract", MySqlDbType.VarChar).Value = client.EndOfContract;
                command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = client.PhoneNumber;
                command.Parameters.Add("@typeOfCar", MySqlDbType.VarChar).Value = client.TypeOfCar;
                command.Parameters.Add("@clientID", MySqlDbType.Int32).Value = client.idClient;

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

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
        }

        private void AllInfoAboutOrders_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs eventArgs)
        {
            string resultOfSearch = textBox1.Text;

            DB dataBase = new DB();
            dataBase.openConnection();

            try
            {
                string commandForDataBase;

                if (textBox1.Text == null)
                {
                    commandForDataBase = "select * from client;";
                } else {
                    commandForDataBase = "Select * from client where FirstName like '" + textBox1.Text + "%' ;";
                }
                MySqlCommand command = new MySqlCommand(commandForDataBase, dataBase.getConnection());

                dataGridView1.Rows.Clear();

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

        private void creatingButton_Click(object sender, EventArgs eventArgs)
        {
            this.Hide();

            OrderedNewCar orderedNewCar = new OrderedNewCar();
            orderedNewCar.Show();
        }

        private void changingButton_Click(object sender, EventArgs eventArgs)
        {
            Client selectedObject = dataGridView1.SelectedRows[0].DataBoundItem as Client;
            int clientID = selectedObject.idClient;

            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Client cust = row.DataBoundItem as Client;
                if (cust != null)
                {
                    this.Hide();

                    ChangingObjectPage changingObjectPage = new ChangingObjectPage();
                    changingObjectPage.selectedObject = cust;
                    changingObjectPage.clientID = clientID;
                    changingObjectPage.Show();
                }
            }
        }
    }
}
