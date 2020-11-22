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
    public partial class OrderedNewCar : Form
    {
        public string typeOfCar;

        public OrderedNewCar()
        {
            InitializeComponent();
        }

        private void firstNameBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void lastNameBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void fatherNameBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void passportDataBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void phoneNumberBox_TextChanged(object sender, EventArgs eventArgs) { }

        private void dateOfTheEndOfTheContractBox_TextChanged(object sender, EventArgs eventArgs) { }

        public static string firstNameFiledInfo = "";
        public static string lastNameFiledInfo = "";
        public static string fatherNameFieldInfo = "";
        public static string passportDataFieldInfo = "";
        public static string phoneNumberFieldInfo = "";
        public static string dateOfTheEndOfTheContractFieldInfo = "";

        private void ordered_button_Click(object sender, EventArgs eventArgs)
        {
            firstNameFiledInfo = firstNameBox.Text;
            lastNameFiledInfo = lastNameBox.Text;
            fatherNameFieldInfo = fatherNameBox.Text;
            passportDataFieldInfo = passportDataBox.Text;
            phoneNumberFieldInfo = phoneNumberBox.Text;
            dateOfTheEndOfTheContractFieldInfo = dateOfTheEndOfTheContractBox.Text;

            ResultOfOrdering resultOfOrderingVariable = new ResultOfOrdering();
            resultOfOrderingVariable.Show();
        }

        private void exit_button_Click(object sender, EventArgs eventArgs)
        {
            // Кнопка для закриття програми

            this.Close();
        }
    }
}
