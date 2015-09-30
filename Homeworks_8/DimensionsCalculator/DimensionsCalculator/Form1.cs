using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionsCalculator
{
    public partial class DropDown : Form
    {
        public DropDown()
        {
            InitializeComponent();

        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
            double quantity = double.Parse(textQuantity.Text);
            double length = double.Parse(textLength.Text);
            double wide = double.Parse(textWide.Text);
            double height = double.Parse(textHeight.Text);
            double result;

            if (checkMeters.Checked)
            {
                result = quantity * (length * wide) / 2.45;
                textResult.Text = Math.Round(result, 2).ToString();
            }
            else if (checkCub.Checked)
            {
                result = quantity * ((length * wide)/height)/2.45;
                textResult.Text = Math.Round(result, 2).ToString();
            }
        }
    }
}
