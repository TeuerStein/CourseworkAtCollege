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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs eventArgsVariable)
        {

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

        }

        private void third_car_Click(object sender, EventArgs eventArgsVariable)
        {

        }

        private void four_car_Click(object sender, EventArgs eventArgsVariable)
        {

        }
    }
}
