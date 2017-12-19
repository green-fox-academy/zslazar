using System;
using System.Collections.Generic;
using System.Text;

namespace BookPages
{
    public class Book
    {
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
                if (page.Content.em)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
