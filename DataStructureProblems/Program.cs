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
                    "\n5.Delete first element \n6.Exit");
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
                        flag = false;
                        break;
                }
            }                      
        }
    }
}
