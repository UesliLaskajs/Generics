using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ActionDelegate
    {
        Action<string> printName = (name) =>
        {
           Console.WriteLine(name);
        };


        public ActionDelegate()
        {
            printName("Uesli");
        }

    }

    public class Age
    {
        Action<int> ageMeasure = (num) =>
        {
            Console.WriteLine(num);
        };

        public Age()
        {
            ageMeasure(20);
            sum(1, 2);
        }

        Func<int, int, string> sum = (a, b ) =>
        {
            return a+b.ToString();
        };

        
    } 

}
