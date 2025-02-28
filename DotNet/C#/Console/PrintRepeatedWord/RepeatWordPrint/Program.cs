using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatWordPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            Dictionary<char, int> dictObj = new Dictionary<char, int>();
            int count = 1;
            int flag = 0;
            for (int i = 0; i <= inp.Length - 1; i++) { 
                for(int j = i + 1; j <= inp.Length - 1; j++)
                {
                    if (inp[i] == inp[j])
                    {
                        count++;
                    }
                }

                if(count > 1)
                {
                    foreach(var item in dictObj)
                    {
                        if (inp[i] == item.Key)
                        {
                            flag = 1;
                            break;
                        }

                        flag = 0;
                    }

                    if(flag == 0)
                    {
                        dictObj.Add(inp[i], count);
                        count = 1;
                    }
                }
            }

            foreach(var item in dictObj)
            {
                Console.Write($"{item.Key}-{item.Value} , ");
            }
        }
    }
}
