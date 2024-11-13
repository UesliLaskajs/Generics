using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    interface IEnvelope<T>
    {
        void getEnvelope(T envelope);


    }


    public class entitys
    {
        int id { get; }
        int name { get; }


    }

    internal class GenericInheritance:IEnvelope<entitys>
    {
        public void getEnvelope(entitys name)
        {
            Console.WriteLine(name);
        }
    }
}
