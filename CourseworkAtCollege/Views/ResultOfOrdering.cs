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
            firstName.Text = OrderedNewCar.client.firstName;
            lastName.Text = OrderedNewCar.client.lastName;
            fatherName.Text = OrderedNewCar.client.fatherName;
            passportData.Text = OrderedNewCar.client.passportData;
            dateOfTheEndOfTheContract.Text = OrderedNewCar.client.dateOfTheEndOfTheContract;
            telephoneNumber.Text = OrderedNewCar.client.phoneNumber;
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {

        }

        private void button2_Click(object sender, EventArgs eventArgs)
        {

        }

        private void button3_Click(object sender, EventArgs eventArgs)
        {

        }
    }
}
