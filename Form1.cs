using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Readjustment
{
    public partial class forms : Form
    {
        public forms()
        {
            InitializeComponent();
        }

        private void Calculatr_Click(object sender, EventArgs e)

        {
            string name = txtname.Text;
            int oldSalary = Convert.ToInt32(txtold.Text);
            int newSalary = Convert.ToInt32(txtn.Text);

            int readjust = newSalary - oldSalary;

            txtresult.Text = "Name: " + name + "\r\nYour old salary is:$" + oldSalary +
                "\r\nYour new salary is:$"+ newSalary +
                "\r\nThe readjustment in your salary was:$" + readjust;
            // Inserir a função de porcentagem depois!
        }
    }
}

