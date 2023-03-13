using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cpfEsc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void diasEsc_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeEsc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBut_Click(object sender, EventArgs e)
        {
            Empregado emp = new Empregado();

            emp.Nome = nomeEsc.Text;
            emp.Cpf = cpfEsc.Text;  
            emp.DiasTrab = int.Parse(diasEsc.Text);
            emp.ValorDiaria = Double.Parse(valorEsc.Text);

            emp.CalcularSb();

            baseEsc.Text = emp.TotalSb.ToString(); 

           
            emp.ValorIr();
            
            irEsc.Text = emp.TotalIr.ToString(); 

            emp.CalcularSl();   

            liqEsc.Text = emp.TotalSl.ToString();
            
        }
    }
}
