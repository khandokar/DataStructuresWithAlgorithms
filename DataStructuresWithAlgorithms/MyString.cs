using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class MyString
  {
    public bool IsValid(string s)
    {
      Stack<char> stack = new Stack<char>();
      Dictionary<char, char> oepntoclose = new Dictionary<char, char>
      {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
      };

      foreach (char c in s)
      {
        if (oepntoclose.ContainsKey(c))
        {
          if (stack.Count> 0 && stack.Peek() == oepntoclose[c])
          {
            stack.Pop();
          }
          else
          {
            return false;
          }
        }
        else
        {
          stack.Push(c);
        }
      }
      return stack.Count > 0 ? false : true;
    }
  }
}
