using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataStructuresWithAlgorithms.MySingleLinkedList;

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

    public Node Head
    {
      get
      {
        return head;
      }
    }

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

    public void DeleteDuplicates()
    {
      if (head == null) return;
      Node currentNode = head;

      while(currentNode != null && currentNode.next != null)
      {
        if (currentNode.data == currentNode.next.data)
        {
          currentNode.next = currentNode.next.next;
        }
        else
        {
          currentNode = currentNode.next;
        }
      }
    }

    public void DeleteDuplicates2()
    {
      if (head == null) return;
      Node fakeHead = new Node(0);
      fakeHead.next = head;
      Node pre = fakeHead;
      Node cur = head;
      while (cur != null)
      {
        while (cur.next != null && cur.data == cur.next.data)
        {
          cur = cur.next;
        }
        if (pre.next == cur)
        {
          pre = pre.next;
        }
        else
        {
          pre.next = cur.next;
        }
        cur = cur.next;
      }
      head =  fakeHead.next;
    }

    public void RemoveNthFromEnd(int n)
    {
      Node dummyHead = new Node(-1);
      dummyHead.next = head;

      Node slow = dummyHead;
      Node fast = dummyHead;

      for(int i = 1;i <= n+1; i++)
      {
        fast = fast.next;
      }

      while(fast != null)
      {
        slow = slow.next;
        fast = fast.next;
      }

      slow.next = slow.next.next;

      head = dummyHead.next;

    }

    public void AddTwoNumbers(Node nod1, Node node2)
    {
      Node firstHead = nod1;
      Node secondHead = node2;
      int total = 0;
      int firstOperand = 0;
      int secondOperand = 0;
      int tempTotal = 0;
      int reminder = 0;

      while(firstHead != null || secondHead != null)
      {
        firstOperand = firstHead == null ? 0 : firstHead.data;
        secondOperand = secondHead == null ? 0 : secondHead.data;

        tempTotal = firstOperand + secondOperand + reminder;
        reminder = 0;
        if (tempTotal >= 10)
        {
          total = tempTotal % 10;
          reminder = tempTotal / 10;
        }
        else
        {
          total = tempTotal;
        }

        firstHead = firstHead == null ? null : firstHead.next;
        secondHead = secondHead == null ? null : secondHead.next;

        Insert(total);
      }
      if(reminder > 0)
      {
        Insert(reminder);
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

    public void ReverseList()
    {
      Node pre = null;
      while(head != null)
      {
        Node next = head.next;
        head.next = pre;
        pre = head;
        head = next;
      }

      head = pre;
    }

    public void ReorderList()
    {
      Node l1 = head;
      Node pre = null;
      Node slow = head;
      Node fast = head;

      while (fast != null && fast.next != null)
      {
        pre = slow;
        slow = slow.next;
        fast = fast.next.next;
      }

      pre.next = null;
      pre = null;

      while (slow != null)
      {
        Node next = slow.next;
        slow.next = pre;
        pre = slow;
        slow = next;
      }
      slow = pre;

      Node dumy = new Node(-1);
      Node currentNode = dumy;

      while (l1 != null && slow != null)
      {
        currentNode.next = l1;
        l1 = l1.next;

        currentNode.next.next = slow;
        slow = slow.next;

        currentNode = currentNode.next.next;
      }

      if (l1 != null)
      {
        currentNode.next = l1;
        l1 = l1.next;
      }

      if (slow != null)
      {
        currentNode.next = slow;
        slow = slow.next;
      }

      head = dumy.next;
    }

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

    public void MergeTwoLists(Node list1, Node list2)
    {
      Node dumy = new Node(-1);
      Node currentNode = dumy;

      while(list1 != null && list2 != null)
      {
        if (list1.data < list2.data)
        {
          currentNode.next = list1;
          list1 = list1.next;
        }
        else
        {
          currentNode.next = list2;
          list2 = list2.next;
        }
        currentNode = currentNode.next;
      }

      if(list1 != null)
      {
        currentNode.next = list1;
        list1 = list1.next;
      }

      if (list2 != null)
      {
        currentNode.next = list2;
        list2 = list2.next;
      }

      head = dumy.next;
    }

    public Node MergeKListsPrority(Node[] lists)
    {
      Node current = null;

      PriorityQueue<Node, int> pq = new PriorityQueue<Node, int>();

      for (int i = 0; i < lists.Count(); i++)
      {
        if (lists[i] != null)
        {
          pq.Enqueue(lists[i], lists[i].data);
        }
      }

      while (pq.TryDequeue(out Node queueItem, out int priority))
      {
        if (head == null)
        {
          head = queueItem;
          current = queueItem;
        }
        else
        {
          current.next = queueItem;
          current = current.next;
        }

        //add next List Node to priority queue
        if (queueItem.next != null)
        {
          pq.Enqueue(queueItem.next, queueItem.next.data);
        }
      }
      return head;
    }

    public Node MergeKListsMerge(Node[] lists)
    {
      // Base condition
      if (lists == null || lists.Count() == 0)
      {
        return null;
      }
      return MergeKLists(lists, 0, lists.Count() - 1);
    }

    private Node MergeKLists(Node[] lists, int start, int end)
    {
      if (start == end)
      {
        return lists[start];
      }
      // Mid of list of lists
      int mid = start + (end - start) / 2;
      // Recursive call for left sublist
      Node left = MergeKLists(lists, start, mid);
      // Recursive call for right sublist
      Node right = MergeKLists(lists, mid + 1, end);
      // Merge the left and right sublist
      return Merge(left, right);
    }

    private Node Merge(Node left, Node right)
    {
      // Create a dummy node
      Node dummy = new Node(-1);
      // Temp node
      Node temp = dummy;
      // Loop until any of the list becomes null
      while (left != null && right != null)
      {
        // Choose the value from the left and right which is smaller
        if (left.data < right.data)
        {
          temp.next = left;
          left = left.next;
        }
        else
        {
          temp.next = right;
          right = right.next;
        }
        temp = temp.next;
      }

      // Take all nodes from left list if remaining
      while (left != null)
      {
        temp.next = left;
        left = left.next;
        temp = temp.next;

      }
      // Take all nodes from right list if remaining
      while (right != null)
      {
        temp.next = right;
        right = right.next;
        temp = temp.next;
      }

      head = dummy.next;
      return dummy.next;
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

    public void MakeCycle(int pos)
    {
      if (head == null || pos < 0)
      {
        return;
      }

      int i = 0;
      Node cycleNode = head;
      Node currentNode = head;
      while (currentNode.next != null)
      {
        i++;
        currentNode = currentNode.next;
        if(i == pos)
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
      Node fast = head;

      while (fast != null && fast.next != null)
      {
        slow = slow.next;
        fast = fast.next.next;
        if (fast == slow)
        {
          return true;
        }
      }
      return false;
    }

    public Node DetectCycle()
    {
      if (head == null) return null;
      Node slow = head;
      Node fast = head;

      bool found = false;
      while (fast != null && fast.next != null)
      {
        slow = slow.next;
        fast = fast.next.next;
        if (fast == slow)
        {
          found = true;
          break;
        }    
      }

      slow = head;
      if (found)
      {
        while(slow != fast)
        {
          slow = slow.next;
          fast = fast.next;
        }
        return slow;
      }

      return null;
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
