using System;
using System.Collections.Generic;
using System.Text;

namespace BookPages
{
    public class Book
    {
        public string TheCharacter = "";

        private List<Page> Pages;
        
        public Book()
        {
            this.Pages = new List<Page>();
        }

        public void Add(Page page)
        {
            Pages.Add(page);
        }

        public int CountBlankPages()
        {
            int counter = 0;
            foreach (var page in Pages)
            {
                if (page.Content.Equals(TheCharacter))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
