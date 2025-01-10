using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSingleCastExample
{
    public delegate void Adddelegate(int a, int b);
    public delegate string Saydelegate(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleCastClass obj= new SingleCastClass();
            Adddelegate addobj = new Adddelegate(obj.AddNum);
            //  or == Adddelegate addobj = obj.AddNum;
            addobj(40, 45);
            // addobj.invoke(40,45);

            Saydelegate sayobj = new Saydelegate(SingleCastClass.SayHello);
            Console.Write(sayobj("Prajakta"));
            //or == sayobj.invoke("Prajakta");
        }
    }
}
