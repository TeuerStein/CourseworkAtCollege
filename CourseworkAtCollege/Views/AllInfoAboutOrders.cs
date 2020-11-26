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

        private void dataGridView(string[] objectFromDataBase)
        {
            dataGridView1.Rows.Add(objectFromDataBase);
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

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {

        }

        private void AllInfoAboutOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
