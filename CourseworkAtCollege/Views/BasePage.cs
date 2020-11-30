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
    public partial class BasePage : Form
    {
        // Код базової сторінки в середині головного класу

        public BasePage()
        {
            InitializeComponent();
        }

        private void first_part_of_base_text_Load(object sender, EventArgs eventArgsVariable)
        {
            // Перша частина для головного текста на базовій сторінці
        }
        private void secont_part_of_base_text_Load(object sender, EventArgs eventArgsVariable)
        {
            // Друга частина для головного текста на базовій сторінці
        }

        private void next_page_button_Click(object sender, EventArgs eventArgsVariable)
        {
            // Кнопка для перенаправлення Користувача на наступну сторінку
            this.Hide();
            MultipleChooserPage multipleChooserPage = new MultipleChooserPage();
            multipleChooserPage.Show();
        }

        private void exit_button_Click(object sender, EventArgs eventArgsVariable)
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
