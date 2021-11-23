using System;
using System.Globalization;

namespace Lab4Aula1Classes
{
    class Program
    {
        public static bool DataTime { get; private set; }
         public static ContaCorrente minhaConta 
        {
            get; set;
        }

        static void Main(string[] args)
        {
            string nome = Console.ReadLine();


            minhaConta = new ContaCorrente(500, nome);
            Console.WriteLine("Saldo na Conta do {0} é de R$ {1}", nome, minhaConta.Saldo);


            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            ExibeData();

            minhaConta.Sacar(50);
            Console.WriteLine(minhaConta.Saldo);
            ExibeData();

            //DateTime localDate = DateTime.Now;
            //DateTime utcDate = DateTime.UtcNow;

        }


        public static void ExibeData()
        {
            String[] cultureNames = { "pt-BR" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("   Local date and time: {0}, {1:G}",
                                    minhaConta.localDate.ToString(culture), minhaConta.localDate.Kind);
                //Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                   // minhaConta.utcDate.ToString(culture), minhaConta.utcDate.Kind);

            }
        }


    }
}
