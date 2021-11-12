using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204026
{
    class Program
    {
        static void Main(string[] args)
        {
            Book_1204026 product1 = new Book_1204026 ("Book", "C# object oriented Solution", "300" );
            DVD_1204026 product2 = new DVD_1204026("Eternal sunshine of the spotless mind", "300");
            Console.WriteLine("product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);

        }
    }
}
