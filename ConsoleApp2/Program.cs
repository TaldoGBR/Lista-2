using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;

            p1 = float(input("Digite a nota da primeira avaliação (P1): "));

            p2 = (15 - p1) / 2;

            Console.Write(f"Para ser aprovado com média 5, você precisa tirar {p2_necessaria:.2f} na segunda avaliação (P2).");

        }
    }
}
