using ACME.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME.Win
{
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var _customer = new Customer();
            var _result = _customer.CalculatePercentOfGoalSteps(this.txtStepGoalToday.Text, this.txtNumberOfStepsToday.Text);
            ResultLabel.Text = "You Reached " + _result + "% of your goal!";
        }
    }
}
