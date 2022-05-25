using System;
using HashTable;
class program
{
    public static void Main(string[] args)
    {
        MyMapNode<string, int> hash = new MyMapNode<string, int>(5);
        string words = "to be or not to be";
        string[] arr = words.Split(' ');
        LinkedList<string> checkforduplication = new LinkedList<string>();
        foreach (string element in arr) // to -> be
        {
            int count = 0;
            foreach (string match in arr) //to->be->or->not->to-> be-> 
            {
                if (element == match)
                {
                    count++;//1->2
                    if (checkforduplication.Contains(element))
                    {
                        break;
                    }
                }

            }

            if (!checkforduplication.Contains(element))
            {
                checkforduplication.AddLast(element);
                hash.Add(element, count);//(to,2)
            }
        }
        hash.Display();
    }
}