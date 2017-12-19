using System;

namespace BookPages
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Add(new Page { Content = "This is the first page" });
            b.Add(new Page { Content = string.Empty });
            b.Add(new Page { Content = string.Empty });


            Console.WriteLine(b.CountBlankPages());
            Console.ReadLine();
        }
    }
}
