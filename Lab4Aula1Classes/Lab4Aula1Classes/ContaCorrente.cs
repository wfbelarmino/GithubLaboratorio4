using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab4Aula1Classes
{
    class ContaCorrente
    {

        public DateTime  localDate { get; set; }
        public DateTime utcDate { get; set; }

        private decimal saldo;
        public decimal Saldo { get { return saldo; } }
       
        public void Depositar(decimal val)
        {
            saldo += val;
            RetornaData();
        }

        public void Sacar(decimal val)
        {
            saldo -= val;
            RetornaData();

        }
        public ContaCorrente(decimal val, string nome)
        {

            saldo = val;
            RetornaData();  


        }

        private void RetornaData()
        {
            
            localDate = DateTime.Now;
            utcDate = DateTime.UtcNow;
        }

        public static DateTime Now { get; }



    }


}
