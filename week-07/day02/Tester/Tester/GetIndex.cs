using System;
using System.Collections.Generic;
using System.Text;


namespace Tester
{
    public class GetIndex
    {
        //List<string> list = new List<string>()
        //    {
        //        "carrot",
        //        "rabbit",
        //        "fox",
        //        "dog"
        //    };

        public int Indexer(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                return list.IndexOf(item);
            }
            else
                return -1;
        }
    }
}