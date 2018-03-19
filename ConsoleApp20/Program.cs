using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Inimesed = new List<string>();
            {
                Inimesed.Add("Jenelle");
                Inimesed.Add("Leonie");
                Inimesed.Add("Bethanie");
                Inimesed.Add("Breanna");
                Inimesed.Add("Sidney");
                Inimesed.Add("Kristyn");
                Inimesed.Add("Kim");
                Inimesed.Add("Guillermina");
                Inimesed.Add("Fidela");
                Inimesed.Add("Lora");
            };
            // Leiab nimede pikkused
            var lenght = Inimesed.GroupBy(x => x.Length);

            // teeb gruppid nime pikkuse järgi
            foreach (var item in lenght)
            {
                
                Console.WriteLine("Names with {0} letters:", item.Key);

                // paneb nimed pikkuse järgi gruppidesse
                foreach (var xd in item)
                {
                    
                    Console.WriteLine("{0}", xd);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
