using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsOppgaverXamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oppgave7();
        }

        static void Oppgave1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Oppgave2()
        {
            int total, sum = 0;
            for (total = 1; total <= 10; total++)
            {
                sum += total;
                Console.WriteLine("{0}", total);
            }
            Console.WriteLine("Summen er: {0}", sum);
        }

        static void Oppgave3()
        {
            int i, n, sum = 0;

            Console.Write("Input verdi : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDe forste {0} tallene er :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write("\nSummen av de forste {0} tall er: {1} \n", n, sum);
        }

        static void Oppgave4()
        {
            int i, n, sum = 0;
            double avg;

            Console.Write("Input 10 tall : \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Nummer-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("Summen av 10 tall er: {0}\nGjennomsnittet er: {1}\n", sum, avg);
        }

        static void Oppgave5()
        {
            int i, cube;

            Console.Write("Input tall : ");
            cube = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= cube; i++)
            {
                Console.Write("Tallet er : {0} og cube av {1} er :{2} \n", i, i, (i * i * i));
            }
        }

        static void Oppgave6()
        {
            int i, n;

            Console.Write("Input tall: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} X {1} = {2} \n", n, i, n * i);
            }
        }

        static void Oppgave7()
        {
            d
        }
    }
}


