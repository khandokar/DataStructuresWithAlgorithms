using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class MySingleLinkedList
  {
    public class Node
    {
      public int data;

      public Node next;

      public Node(int x)
      {
        data = x;
        next = null;
      }
    }

    Node head;
    private int length = 0;

    public int GetLength()
    {
      return length;
    }

    public void Insert(int data)
    {
      Node node = new Node(data);
      if (head == null)
      {
        head = node;
      }
      else
      {
        Node currentNode = head;
        while (currentNode.next != null)
        {
          currentNode = currentNode.next;
        }
        currentNode.next = node;
      }
      length++;
    }

    public void InsertAtStart(int data)
    {
      Node node = new Node(data);
      node.next = head;
      head = node;
      length++;
    }

    public void InsertAt(int index, int data)
    {
      if (index == 0)
      {
        InsertAtStart(data);
      }
      else
      {
        Node node = new Node(data);
        Node currentNode = head;
        for (int i = 0; i < index - 1; i++)
        {
          currentNode = currentNode.next;
        }

        node.next = currentNode.next;
        currentNode.next = node;
        length++;
      }
    }

    public void Delete()
    {
      head = null;
      length = 0;
    }

    public void DeleteAt(int index)
    {
      Node currentNode = head;
      if (index == 0)
      {
        head = currentNode.next == null ? null : currentNode.next;
        length--;
        return;
      }
      for (int i = 0; currentNode.next != null && i < index - 1; i++)
      {
        currentNode = currentNode.next;
      }
      if (currentNode.next != null && currentNode.next.next != null)
      {
        currentNode.next = currentNode.next.next;
        length--;
      }
    }

    public void Delete(int key)
    {
      if (head == null)
        return;

      Node currentNode = head;

      if (head.data == key)
      {
        head = currentNode.next == null ? null : currentNode.next;
        length--;
        return;
      }

      while (currentNode.next != null && currentNode.next.data != key)
      {
        currentNode = currentNode.next;
      }
      if (currentNode.next != null && currentNode.next.data == key)
      {

        currentNode.next = currentNode.next.next;
        length--;
      }
    }

    public void DeleteAll(int key)
    {
      if (head == null)
        return;

      Node currentNode = head;
      while (currentNode != null && currentNode.next != null)
      {
        if (currentNode.next.data == key)
        {
          currentNode.next = currentNode.next.next;
        }
        if (currentNode.next.data != key)
        {
          currentNode = currentNode.next;
        }
      }
      if (head.data == key)
      {
        head = head.next == null ? null : head.next;
        length--;
      }
    }

    //public int length()
    //{
    //  int count = 0;
    //  Node currentNode = head;
    //  while (currentNode != null)
    //  {
    //    count++;
    //    currentNode = currentNode.next;
    //  }
    //  return count;
    //}

    public int LengthTortoiseHare()
    {
      // Uses of two pointers
      int count = 0;
      Node fast = head;
      Node slow = head;
      while (fast != null && fast.next != null)
      {
        slow = slow.next;
        fast = fast.next.next;
        count++;
      }

      if (fast == null)
      {
        return count * 2;
      }
      else
      {
        return count * 2 + 1;
      }
    }

    public bool Search(int key)
    {
      Node currentNode = head;
      while (currentNode != null)
      {
        if (currentNode.data == key)
          return true;
        currentNode = currentNode.next;
      }
      return false;
    }

    public int GetNth(int index)
    {
      int i = 0;
      Node currentNode = head;
      while (currentNode != null)
      {
        if (i == index)
          return currentNode.data;
        currentNode = currentNode.next;
        i++;
      }
      return -1;
    }
    
    public void PrintNthFromLast(int N)
    {
      Node main_ptr = head;
      Node ref_ptr = head;

      int count = 0;
      if (head != null)
      {
        while (count < N)
        {
          if (ref_ptr == null)
          {
            Console.WriteLine(
                    N + " is greater than the no "
                            + " of nodes in the list");
            return;
          }
          ref_ptr = ref_ptr.next;
          count++;
        }

        if (ref_ptr == null)
        {

          if (head != null)
            Console.WriteLine("Node no. " + N
                    + " from last is "
                    + head.data);
        }
        else
        {

          while (ref_ptr != null)
          {
            main_ptr = main_ptr.next;
            ref_ptr = ref_ptr.next;
          }
          Console.WriteLine("Node no. " + N
                  + " from last is "
                  + main_ptr.data);
        }
      }
    }

    public int SumFactorialsOfPrimeNumbers()
    {
      int sum = 0;
      Node currentNode = head;
      while (currentNode != null)
      {
        if (MyNumber.IsPrime(currentNode.data))
        {
          sum = sum + MyNumber.Factorial(currentNode.data);
        }
        currentNode = currentNode.next;
      }
      return sum;
    }

    public void MadeLastNodeToFront()
    {
      Node currentNode = head;
      while (currentNode.next != null && currentNode.next.next != null)
      {
        currentNode = currentNode.next;
      }
      if (currentNode.next != null)
      {
        Node lastNode = currentNode.next;
        currentNode.next = null;
        lastNode.next = head;
        head = lastNode;
      }
    }

    public void MakeCycle(int nthElement)
    {
      if (head == null || nthElement == 1)
      {
        return;
      }

      int i = 1;
      Node cycleNode = null;
      Node currentNode = head;
      while (currentNode.next != null)
      {
        i++;
        currentNode = currentNode.next;
        if(i == nthElement)
        {
          cycleNode = currentNode;
        }
      }

      currentNode.next = cycleNode;

    }

    public bool HasCycle()
    {
      if (head == null) return false;
      Node slow = head;
      Node fast = head.next;
      while(fast != null && fast.next != null && slow != null)
      {
        if(fast == slow)
        {
          return true;
        }
        fast = fast.next.next;
        slow = slow.next;
      }
      return false;
    }
    public void ShowRecursively()
    {
      PrintRecursively(head);
      Console.WriteLine("\n");
    }

    public void Show()
    {
      if (head == null)
      {
        Console.WriteLine("The linklist is empty");
      }
      else
      {
        Node currentNode = head;
        while (currentNode != null)
        {
          Console.Write(currentNode.data);
          currentNode = currentNode.next;
          if (currentNode != null)
          {
            Console.Write(" -> ");
          }
        }
      }

      Console.WriteLine("\n");
    }

    public void ShowAlternativeHeadToEndAndEndToHead()
    {
      PrintAlternativeHeadToEndAndEndToHead(head);
      Console.WriteLine("\n");
    }
    
    private void PrintAlternativeHeadToEndAndEndToHead(Node currentNode)
    {
      if (currentNode == null)
      {
        return;
      }
      Console.WriteLine(currentNode.data);
      if (currentNode.next != null)
      {
        Console.WriteLine(" -> ");
      }
      else
      {
        Console.WriteLine(",");
      }

      if (currentNode.next != null)
      {
        PrintAlternativeHeadToEndAndEndToHead(currentNode.next.next);
      }
      Console.WriteLine(currentNode.data);
      if (currentNode != head)
        Console.WriteLine(" -> ");
    }
   
    private void PrintRecursively(Node currentNode)
    {
      if (currentNode == null)
      {
        return;
      }
      PrintRecursively(currentNode.next);
      Console.WriteLine(currentNode.data);
      if (currentNode != head)
        Console.WriteLine(" -> ");
    }
  }
}
