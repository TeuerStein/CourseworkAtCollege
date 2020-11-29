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
    public partial class ResultOfOrdering : Form
    {
        public ResultOfOrdering()
        {
            InitializeComponent();
        }

        private void Labels_Load(object sender, EventArgs eventArgs)
        {
            firstName.Text = "Ім'я: " + OrderedNewCar.client.FirstName;
            lastName.Text = "Прізвище: " + OrderedNewCar.client.LastName;
            fatherName.Text = "По батькові: " + OrderedNewCar.client.FatherName;
            passportData.Text = "Паспорт: " + OrderedNewCar.client.PassportData;
            telephoneNumber.Text = "Номер телефону: " + OrderedNewCar.client.PhoneNumber;
            dateOfTheEndOfTheContract.Text = "Дата завершення контракту: " + OrderedNewCar.client.EndOfContract;
            typeOfCar.Text = "Тип машини: " + OrderedNewCar.client.TypeOfCar;
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            this.Hide();

            BasePage basePage = new BasePage();
            basePage.Show();
        }

        private void button3_Click(object sender, EventArgs eventArgs)
        {
            this.Close();
        }
    }
}
