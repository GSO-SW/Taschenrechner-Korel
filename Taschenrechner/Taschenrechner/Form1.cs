using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tbxZahl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double Zahl1 = Convert.ToInt32(tbxZahl1.Text);
            double Zahl2 = Convert.ToInt32(tbxZahl2.Text);
            tbxErgebniss.Text = Convert.ToString(Zahl1 + Zahl2);
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            double Zahl1 = Convert.ToInt32(tbxZahl1.Text);
            double Zahl2 = Convert.ToInt32(tbxZahl2.Text);
            tbxErgebniss.Text = Convert.ToString(Zahl1 - Zahl2);
        }

        private void TbxZahl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxErgebniss_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMult_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {

        }
    }
}
