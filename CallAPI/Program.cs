using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWebRequest api = new MyWebRequest("http://uat.sgbbc.com.sg/api/list-auctions", "POST", "status=2&token=zVjk98qEsZqFeJmHYxKqVBKmA20oYDwlImHXRuEoN3M&uid=1257");
            Console.WriteLine(api.GetResponse());

            Console.ReadLine();
        }
    }
}
