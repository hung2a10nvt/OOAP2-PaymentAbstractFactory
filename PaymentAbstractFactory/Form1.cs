using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaymentAbstractFactory.Factories;
using PaymentAbstractFactory.Products;

namespace PaymentAbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRussia_Click(object sender, EventArgs e)
        {
            IPaymentFactory factory = new RussiaPaymentFactory();
            ShowPaymentInfo(factory);
        }

        private void ShowPaymentInfo(IPaymentFactory factory)
        {
            PaymentMethod method = factory.CreatePaymentMethod();
            PaymentSpec spec = factory.CreatePaymentSpec();

            lblMethod.Text = method.GetMethodName();

            try
            {
                picMethod.Image = Image.FromFile(method.GetMethodImagePath());
            }
            catch (FileNotFoundException)
            {
                picMethod.Image = null;
            }

            rtbSpec.Text = spec.GetSpecInfo();
        }

        private void btnEurope_Click_1(object sender, EventArgs e)
        {
            IPaymentFactory factory = new EuropePaymentFactory();
            ShowPaymentInfo(factory);
        }
    }
}
