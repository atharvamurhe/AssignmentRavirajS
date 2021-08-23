using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentRavirajS
{
    public class CollectionsAssignment
    {
        public static void StackExample()
        {
            Stack<int> myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            PrintStack(myStack);

            myStack.Push(6);
            Console.WriteLine("Stack after push operation: ");
            PrintStack(myStack);

            //Checks if an element exists in stack
            Console.WriteLine("Does stack contain element '5': {0}", myStack.Contains(5));

            myStack.Pop();
            Console.WriteLine("Stack after pop operation: ");
            PrintStack(myStack);

            //Returns the top element from the stack
            Console.WriteLine("The Top most element in stack: {0}", myStack.Peek());

            //Returns the total count of elements in the Stack
            Console.WriteLine("Total elements in stack: {0}", myStack.Count);

            //Removes all items from the stack
            myStack.Clear();
            PrintStack(myStack);
        }

        public static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public static void QueueExample()
        {
            Queue<char> alphabets = new Queue<char>();
            alphabets.Enqueue('A');
            alphabets.Enqueue('B');
            alphabets.Enqueue('C');
            alphabets.Enqueue('D');
            alphabets.Enqueue('E');

            Console.WriteLine("Elements in Queue: ");
            foreach (var alphabet in alphabets)
                Console.WriteLine(alphabet);

            //Adds an item into the queue
            alphabets.Enqueue('F');

            Console.WriteLine("Dequeue element from queue: {0}", alphabets.Dequeue());

            Console.WriteLine("Queue after enqueue and dequeue operations: ");
            foreach (var alphabet in alphabets)
                Console.WriteLine(alphabet);

            //Removes all the items from the queue
            alphabets.Clear();
            Console.WriteLine("Queue after clear operation: ");
            foreach (var alphabet in alphabets)
                Console.WriteLine(alphabet);
        }

        public static void ListExamples()
        {
            List<string> employees = new List<string>();

            employees.Add("Vinayak");
            employees.Add("Veena");
            employees.Add("Atharva");
            employees.Add("Tanmay");
            employees.Add("Prajakta");

            Console.WriteLine("List: ");
            foreach(var employee in employees)
                Console.WriteLine(employee);

            //Returns the total number of elements in the List
            Console.WriteLine("Total elements in list: {0}", employees.Count);

            //Checks whether the element exists or not
            Console.WriteLine("Does the list contain ninad: {0}", employees.Contains("ninad"));

            employees.Remove("Atharva"); //removes the first 'Atharva' from a list
            employees.RemoveAt(2); //removes the 3rd element

            employees.Insert(2, "Ninad");

            Console.WriteLine("List after insert and remove operaions: ");
            foreach (var employee in employees)
                Console.WriteLine(employee);

            //Sorts list alphabetically
            employees.Sort();
            Console.WriteLine("List after sorting operaion: ");
            foreach (var employee in employees)
                Console.WriteLine(employee);
        }

        public static void DictionaryExample()
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();
            cities.Add(1, "Pune");
            cities.Add(2, "Mumbai");
            cities.Add(3, "Delhi");
            cities.Add(4, "Kolkata");
            cities.Add(5, "Banglore");

            Console.WriteLine("Elements in dictionary: ");
            foreach(var city in cities)
                Console.WriteLine("Key: {0} and Value: {1}", city.Key, city.Value);

            //Returns the count of dictionary
            Console.WriteLine("Element count in dictionary: {0}", cities.Count);

            //sets the value associated with the specified key
            cities[2] = "Bombay";

            //Removes the key value pair of the specified key
            cities.Remove(4);

            Console.WriteLine("Dictoinary after and remove update operations: ");
            foreach (var city in cities)
                Console.WriteLine("Key: {0} and Value: {1}", city.Key, city.Value);

            //Searches for the key and prints if found
            if (cities.ContainsKey(3))
            {
                Console.WriteLine("Value associated to key '3' : {0}", cities.ElementAt(3).Value);
            }
        }
    }
}
