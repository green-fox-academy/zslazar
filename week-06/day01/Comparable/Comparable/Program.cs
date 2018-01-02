using System;
using System.Collections.Generic;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dominoes = InitializeDominoes();

            List<Domino> dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            dominoes.Sort();

            foreach (var item in dominoes)
            {
                Console.WriteLine(item.GetValues()[0] + " " + item.GetValues()[1] + " | ");
            }

            Console.ReadKey();
        }

        /*
         public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>
            {
                new Domino(5, 2),
                new Domino(4, 6),
                new Domino(1, 5),
                new Domino(6, 7),
                new Domino(2, 4),
                new Domino(7, 1),
                new Domino(6, 4)
            };
            return dominoes;
        }
      */
    }
}
