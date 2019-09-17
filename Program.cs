using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      int a;
      int b;
      double eredmeny; // lebegőpontos szám, törtszám

      Console.Write("First number: ");
      a = Convert.ToInt32( Console.ReadLine());

      Console.Write("Second number: ");
      b = Convert.ToInt32(Console.ReadLine());

      eredmeny = a + b;
      Console.WriteLine(a + "+" + b + "=" + eredmeny);
      eredmeny = a - b;
      Console.WriteLine(a + "-" + b + "=" + eredmeny);
      eredmeny = a * b;
      Console.WriteLine(a + "*" + b + "=" + eredmeny);
      eredmeny = (double) a / b;
      Console.WriteLine(a + "/" + b + "=" + eredmeny);

      Console.ReadKey();
    }
  }
}
