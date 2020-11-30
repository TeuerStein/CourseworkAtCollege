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
    public partial class AutoCollection : Form
    {
        public AutoCollection()
        {
            InitializeComponent();
        }

        // Зображення з подією при кліку мишки
        private void first_car_Click(object sender, EventArgs eventArgsVariable)
        {
            this.Hide();
            OrderedNewCar orderNewCar = new OrderedNewCar();
            orderNewCar.typeOfCar = "Економ клас";
            orderNewCar.Show();
        }

        private void second_car_Click(object sender, EventArgs eventArgsVariable)
        {
            this.Hide();
            OrderedNewCar orderNewCar = new OrderedNewCar();
            orderNewCar.typeOfCar = "Середній клас";
            orderNewCar.Show();
        }

        private void third_car_Click(object sender, EventArgs eventArgsVariable)
        {
            this.Hide();
            OrderedNewCar orderNewCar = new OrderedNewCar();
            orderNewCar.typeOfCar = "Позашляховик";
            orderNewCar.Show();

        }

        private void four_car_Click(object sender, EventArgs eventArgsVariable)
        {
            this.Hide();
            OrderedNewCar orderNewCar = new OrderedNewCar();
            orderNewCar.typeOfCar = "Преміум клас";
            orderNewCar.Show();
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

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
        }
    }
}
