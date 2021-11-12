using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204026
{
    class DVD_1204026: Product_1204026
    { 
    protected string duration;
        
    public DVD_1204026(string title, string duration)
    {
        this.MyTitle = title;
        this.Duration = duration;
        this.MyType = "DVD";
        Console.WriteLine("ini dari class DVD");
    }
    public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
    }
}
