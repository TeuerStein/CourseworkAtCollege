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
            firstName.Text = OrderedNewCar.firstNameFiledInfo;
            lastName.Text = OrderedNewCar.lastNameFiledInfo;
            fatherName.Text = OrderedNewCar.fatherNameFieldInfo;
            passportData.Text = OrderedNewCar.passportDataFieldInfo;
            telephoneNumber.Text = OrderedNewCar.passportDataFieldInfo;
            dateOfTheEndOfTheContract.Text = OrderedNewCar.dateOfTheEndOfTheContractFieldInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
