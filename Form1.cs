using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            // int a=;
            double d=Sample.Addition(1, 1);
            txtValue.Text = d.ToString();
       }
    }
}
