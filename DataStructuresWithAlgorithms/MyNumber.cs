using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class MyNumber
  {
    public static bool IsPrime(int n)
    {
      for (int i = 2; i <= n / 2; i++)
      {
        if (n % i == 0)
        {
          return false;
        }
      }
      return true;
    }
    public static int Factorial(int n)
    {
      if (n == 0)
        return 1;

      return n * Factorial(n - 1);
    }
  }
}
