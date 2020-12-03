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
    public partial class AutoChooser : Form
    {
        public string typeOfCar;
        public string nameOfCar;

        public AutoChooser()
        {
            InitializeComponent();
        }

        private void carChooser(object sender, EventArgs eventArgs)
        {
            if(typeOfCar == "Економ клас") 
            {
                
                // Середній клас 
                this.Toyota_Corolla.Hide();
                this.text_for_Toyota_Corolla.Hide();

                this.Honda_Civic.Hide();
                this.text_for_Honda_Civic.Hide();

                this.BMW_520.Hide();
                this.text_for_BMW_520.Hide();

                this.Volkswagen_Polo_SE.Hide();
                this.text_for_Volkswagen_Polo_SE.Hide();

                // Позашляховики
                this.BMX_X6.Hide();
                this.text_for_BMX_X6.Hide();

                this.Audi_Q3.Hide();
                this.text_for_Audi_Q3.Hide();

                this.Ford_Explorer.Hide();
                this.text_for_Ford_Explorer.Hide();

                this.Hyundai_Tucson.Hide();
                this.text_for_Hyundai_Tucson.Hide();

                // Преміум клас
                this.Audi_A6.Hide();
                this.text_for_Audi_A6.Hide();

                this.Mercedes_Benz_С180.Hide();
                this.text_for_Mercedes_Benz_С180.Hide();

                this.Volkswagen_Arteon_R_line.Hide();
                this.text_for_Volkswagen_Arteon_R_line.Hide();

                this.Skoda_Suberb.Hide();
                this.text_for_Skoda_Suberb.Hide();

            } else if(typeOfCar == "Середній клас") {

                // Економ клас
                this.Fiat_Abarth_500.Hide();
                this.text_for_Fiat_Abarth_500.Hide();

                this.Volkswagen_Suran.Hide();
                this.text_for_Volkswagen_Suran.Hide();

                this.Mini_Cooper_Clubman.Hide();
                this.text_for_Mini_Cooper_Clubman.Hide();

                this.Suzuki_Swift.Hide();
                this.text_for_Suzuki_Swift.Hide();

                // Позашляховики
                this.BMX_X6.Hide();
                this.text_for_BMX_X6.Hide();

                this.Audi_Q3.Hide();
                this.text_for_Audi_Q3.Hide();

                this.Ford_Explorer.Hide();
                this.text_for_Ford_Explorer.Hide();

                this.Hyundai_Tucson.Hide();
                this.text_for_Hyundai_Tucson.Hide();

                // Преміум клас
                this.Audi_A6.Hide();
                this.text_for_Audi_A6.Hide();

                this.Mercedes_Benz_С180.Hide();
                this.text_for_Mercedes_Benz_С180.Hide();

                this.Volkswagen_Arteon_R_line.Hide();
                this.text_for_Volkswagen_Arteon_R_line.Hide();

                this.Skoda_Suberb.Hide();
                this.text_for_Skoda_Suberb.Hide();

            } else if(typeOfCar == "Позашляховик") {

                // Економ клас
                this.Fiat_Abarth_500.Hide();
                this.text_for_Fiat_Abarth_500.Hide();

                this.Volkswagen_Suran.Hide();
                this.text_for_Volkswagen_Suran.Hide();

                this.Mini_Cooper_Clubman.Hide();
                this.text_for_Mini_Cooper_Clubman.Hide();

                this.Suzuki_Swift.Hide();
                this.text_for_Suzuki_Swift.Hide();

                // Середній клас 
                this.Toyota_Corolla.Hide();
                this.text_for_Toyota_Corolla.Hide();

                this.Honda_Civic.Hide();
                this.text_for_Honda_Civic.Hide();

                this.BMW_520.Hide();
                this.text_for_BMW_520.Hide();

                this.Volkswagen_Polo_SE.Hide();
                this.text_for_Volkswagen_Polo_SE.Hide();

                // Преміум клас
                this.Audi_A6.Hide();
                this.text_for_Audi_A6.Hide();

                this.Mercedes_Benz_С180.Hide();
                this.text_for_Mercedes_Benz_С180.Hide();

                this.Volkswagen_Arteon_R_line.Hide();
                this.text_for_Volkswagen_Arteon_R_line.Hide();

                this.Skoda_Suberb.Hide();
                this.text_for_Skoda_Suberb.Hide();

            } else if(typeOfCar == "Преміум клас") {

                // Економ клас
                this.Fiat_Abarth_500.Hide();
                this.text_for_Fiat_Abarth_500.Hide();

                this.Volkswagen_Suran.Hide();
                this.text_for_Volkswagen_Suran.Hide();

                this.Mini_Cooper_Clubman.Hide();
                this.text_for_Mini_Cooper_Clubman.Hide();

                this.Suzuki_Swift.Hide();
                this.text_for_Suzuki_Swift.Hide();

                // Середній клас 
                this.Toyota_Corolla.Hide();
                this.text_for_Toyota_Corolla.Hide();

                this.Honda_Civic.Hide();
                this.text_for_Honda_Civic.Hide();

                this.BMW_520.Hide();
                this.text_for_BMW_520.Hide();

                this.Volkswagen_Polo_SE.Hide();
                this.text_for_Volkswagen_Polo_SE.Hide();

                // Позашляховики
                this.BMX_X6.Hide();
                this.text_for_BMX_X6.Hide();

                this.Audi_Q3.Hide();
                this.text_for_Audi_Q3.Hide();

                this.Ford_Explorer.Hide();
                this.text_for_Ford_Explorer.Hide();

                this.Hyundai_Tucson.Hide();
                this.text_for_Hyundai_Tucson.Hide();

            }
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

        private void Fiat_Abarth_500_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Fiat Abarth 500";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Toyota_Corolla_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Toyota Corolla";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void BMX_X6_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "BMX X6";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Audi_A6_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Audi A6";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Volkswagen_Suran_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Volkswagen Suran";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Honda_Civic_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Honda Civic";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Audi_Q3_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Audi Q3";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Mercedes_Benz_С180_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Mercedes-Benz С180";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Mini_Cooper_Clubman_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Mini Cooper Clubman";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void BMW_520_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "BMW 520";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Ford_Explorer_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Ford Explorer";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Volkswagen_Arteon_R_line_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Volkswagen Arteon R-line";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Suzuki_Swift_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Suzuki Swift";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Volkswagen_Polo_SE_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Volkswagen Polo SE";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Hyundai_Tucson_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Hyundai Tucson";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void Skoda_Suberb_Click(object sender, EventArgs eventArgs)
        {
            nameOfCar = "Skoda Suberb";

            OrderedNewCarByName(sender, eventArgs);
        }

        private void OrderedNewCarByName(object sender, EventArgs eventArgs)
        {
            this.Hide();

            OrderedNewCar orderedNewCar = new OrderedNewCar();
            orderedNewCar.typeOfCar = this.typeOfCar;
            orderedNewCar.nameOfCar = this.nameOfCar;
            orderedNewCar.Show();
        }
    }
}
