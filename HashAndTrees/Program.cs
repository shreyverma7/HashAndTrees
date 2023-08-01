using HashAndTrees;
using HashAndTrees.BinaryTree;

internal class Program
{
    private static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter input \n1.HashTable \n2.BinarySearchTree\n");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("HashTable \n!");
                    MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
                    hash.Add("0", "To");
                    hash.Add("1", "be");
                    hash.Add("2", "or");
                    hash.Add("3", "not");
                    hash.Add("4", "to");
                    hash.Add("5", "be");
                    string hash5 = hash.Get("5");
                    Console.WriteLine("5th index value : " + hash5);
                    hash.Remove("2");
                    string hash2 = hash.Get("2");
                    Console.WriteLine("2th index value : " + hash2);
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.WriteLine("HashTable \n!");
                    BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Display();
                    Console.WriteLine("\n");
                    break;
                case 3:
                    flag = false;
                    break;
            }

        }
       
    }
}