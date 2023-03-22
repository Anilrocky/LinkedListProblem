using System;
namespace DataStructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedList list = new LinkedList();
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Add elements to Linked list \n2.Add in Reverse order \n3.Display elements \n4.Insert element at particular position"+
                    "\n5.Delete first element \n6.Delete last element \n7.Search element \n8.Insert 40 after 30 \n9.Delete element 40 \n10.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.AddInReverseOrder(70);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(56);
                        break;
                    case 3:
                        list.Display();
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(70);
                        list.InsertAtParticularPosition(1, 30);
                        break;
                    case 5:
                        list.DeleteFirstElement();
                        break;
                    case 6:
                        list.DeleteLastElement();
                        break;
                    case 7:
                        list.SearchElement(30);                        
                        break;
                    case 8:
                        int searchAdd = list.SearchElement(30);
                        list.InsertAtParticularPosition(searchAdd+1, 40);
                        break;
                    case 9:
                        int searchRemove = list.SearchElement(40);
                        list.DeleteElementAtParticularPosition(searchRemove);
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }                      
        }
    }
}
