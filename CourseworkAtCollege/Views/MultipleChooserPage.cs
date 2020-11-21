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
    public partial class MultipleChooserPage : Form
    {
        public MultipleChooserPage()
        {
            InitializeComponent();
        }

        private void order_Click(object sender, EventArgs eventArgs)
        {
            this.Hide();
            AutoCollection autoCollection = new AutoCollection();
            autoCollection.Show();
        }
    }
}
