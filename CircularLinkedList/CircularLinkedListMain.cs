namespace DataStructureAlgorithm.CircularLinkedList
{
    public class CircularLinkedListMain
    {
        //1. Add at head
        //2. Add at Tail
        //3. Add at index
        //4. Delete at head
        //5. Delete at Tail
        //6. Delete at index
        //7. Print

        //static void Main(string[] args)
        static void main(string[] args)
        {
            CircularLL myCSLL = new CircularLL();
            myCSLL.AddAtHead(50);
            myCSLL.AddAtHead(40);
            myCSLL.AddAtHead(30);
            myCSLL.AddAtHead(20);
            myCSLL.AddAtHead(10);
            myCSLL.Print();
            myCSLL.AddAtTail(60);
            myCSLL.AddAtTail(70);
            myCSLL.AddAtTail(80);
            myCSLL.AddAtTail(90);
            myCSLL.AddAtTail(100);
            myCSLL.Print();
            myCSLL.AddAtIndex(5, 0);
            myCSLL.Print();
            myCSLL.AddAtIndex(15, 2);
            myCSLL.Print();
            myCSLL.AddAtIndex(25, 4);
            myCSLL.Print();
            myCSLL.AddAtIndex(35, 6);
            myCSLL.Print();
            myCSLL.AddAtIndex(105, 14);
            myCSLL.Print();
            myCSLL.DeleteAtHead();
            myCSLL.Print();
            myCSLL.DeleteAtHead();
            myCSLL.Print();
            myCSLL.DeleteAtHead();
            myCSLL.Print();
            myCSLL.DeleteATail();
            myCSLL.Print();
            myCSLL.DeleteATail();
            myCSLL.Print();
            myCSLL.DeleteATail();
            myCSLL.Print();
            myCSLL.DeleteAtIndex(0);
            myCSLL.Print();
            myCSLL.DeleteAtIndex(1);
            myCSLL.Print();
            myCSLL.DeleteAtIndex(6);
            myCSLL.Print();




        }
    }
}