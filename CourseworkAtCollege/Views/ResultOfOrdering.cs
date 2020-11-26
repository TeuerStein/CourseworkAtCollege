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
            firstName.Text = "Ім'я: " + OrderedNewCar.client.firstName;
            lastName.Text = "Прізвище: " + OrderedNewCar.client.lastName;
            fatherName.Text = "По батькові: " + OrderedNewCar.client.fatherName;
            passportData.Text = "Паспорт: " + OrderedNewCar.client.passportData;
            telephoneNumber.Text = "Номер телефону: " + OrderedNewCar.client.phoneNumber;
            dateOfTheEndOfTheContract.Text = "Дата завершення контракту: " + OrderedNewCar.client.dateOfTheEndOfTheContract;
            typeOfCar.Text = "Тип машини: " + OrderedNewCar.client.typeOfCar;
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {

        }

        private void button2_Click(object sender, EventArgs eventArgs)
        {

        }

        private void button3_Click(object sender, EventArgs eventArgs)
        {
            this.Close();
        }
    }
}
