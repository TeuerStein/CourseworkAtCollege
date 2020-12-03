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
            // Виведення інформації про замовлення
            // для перегляду форми на наявність помилок

            firstName.Text = "Ім'я: " + OrderedNewCar.client.FirstName;
            lastName.Text = "Прізвище: " + OrderedNewCar.client.LastName;
            fatherName.Text = "По батькові: " + OrderedNewCar.client.FatherName;
            passportData.Text = "Паспорт: " + OrderedNewCar.client.PassportData;
            telephoneNumber.Text = "Номер телефону: " + OrderedNewCar.client.PhoneNumber;
            dateOfTheStartOfTheContract.Text = "Дата початку контракта: " + OrderedNewCar.contractModel.StartOfContract;
            dateOfTheEndOfTheContract.Text = "Дата завершення контракта: " + OrderedNewCar.contractModel.EndOfContract;
            typeOfCar.Text = "Тип машини: " + OrderedNewCar.autoParkModel.TypeOfCar;
            nameOfCar.Text = "Машина: " + OrderedNewCar.client.NameOfCar;
        }

        private void mainPageButton_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для перенесення на головне меню

            this.Hide();
            BasePage basePage = new BasePage();
            basePage.Show();
        }

        private void exitButton_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для виходу з програми

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
