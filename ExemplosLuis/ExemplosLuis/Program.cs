using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosLuis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.Add("Macoratti");
            nomes.Add("Miriam");
            nomes.Add("Jessica");
            nomes.Add("Jefferson");
            nomes.Add("Janice");
            nomes.Add("Marcia");
            nomes.Add("Bianca");
            nomes.Add("Carlos");
            nomes.Add("Yuri");


            //string resultado = nomes.Find(delegate (string nome)
            //{
            //    return nome.Equals("Bianca");
            //});

            //string resultado = nomes.Find(nome => nome.Equals("Bianca"));


            //Lambda
            nomes.RemoveAll(p => p.StartsWith("J"));

            if (nomes.Exists(e => e.Equals("Marcia")))
            {
                Console.WriteLine("existe uma pessoa chamada Marcia na lista");
            }

            nomes.ForEach(n => Console.WriteLine(n));

            foreach (string pessoa in nomes.FindAll(p => (p.StartsWith("M"))))
            {
                Console.WriteLine(pessoa);
            }

            //Console.WriteLine(resultado);
            Console.ReadKey();


        }
    }
}
