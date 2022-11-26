namespace LinkedListUCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList UCs");
            Console.WriteLine("Please choose as per the given options -\n" +
                "1: Adding elements by BuiltIn-LinkedList\n" +
                "2: Adding elements by using Custom LinkedList\n");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    DefaultLinkedList.AddingElements();
                    break;
                case 2:
                    CustomLinkedList customLinkedList= new CustomLinkedList();
                    customLinkedList.AddLast(56);
                    customLinkedList.AddLast(30);
                    customLinkedList.AddLast(70);
                    customLinkedList.Display();
                    break;
                default:
                    Console.WriteLine("Invalid option selected .Please try again !");
                    break;
            }
        }
    }
}