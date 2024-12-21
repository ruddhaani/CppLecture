using System;
using System.Collections;

namespace ArrayListExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayListObj = new ArrayList() { "INDIA" , "AUS" , "BRAZIL" , "SPAIN" , "UK"};
            //arrayListObj.Add("Brazil");
            //arrayListObj.Add("India");
            //arrayListObj.Add("Australia");
            //arrayListObj.Add("USA");
            //arrayListObj.Add("Spain");

            if(arrayListObj.Count > 0)
            {
                foreach(var country in arrayListObj)
                {
                    Console.WriteLine(country);
                }
            }

        }
    }
}
