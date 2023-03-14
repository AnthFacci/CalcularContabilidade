using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Empregado
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int DiasTrab { get; set; }

        public double ValorDiaria { get; set; }

        public double TotalSb { get; private set; }

        public double TotalIr { get; private set; } 

        public double TotalSl { get; private set; } 

        public void CalcularSb()
        {
            TotalSb = (DiasTrab * ValorDiaria);

            ValorIr();

            CalcularSl();
        }

        private  void ValorIr()
        {
            if (TotalSb <= 1903.98)
            {
                TotalIr = (TotalSb * 0);
            }

            else if (TotalSb >= 1903.99 || TotalSb <= 2826.65)
            {
                TotalIr = (TotalSb * 0.075);
            }

            else if (TotalSb >= 2826.66 || TotalSb <= 3751.05)
            {
                TotalIr = (TotalSb * 0.15);
            }

            else if ( TotalSb >= 3751.06 || TotalSb <= 4664.68)
            {
                TotalIr = (TotalSb * 0.225);
            }

            
        }

        private  void CalcularSl()
        {
            TotalSl = (TotalSb - TotalIr); 
        }
    }
}
