using HashAndTrees;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HashTable and trees!");
        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
        hash.Add("5", "five");
        hash.Add("4", "four");
        hash.Add("3", "three");
        hash.Add("2", "two");
        hash.Add("1", "one");
        hash.Add("0", "zero");
        string hash5 = hash.Get("5");
        Console.WriteLine("5th index value : "+ hash5);
        hash.Remove("2");
        string hash2 = hash.Get("2");
        Console.WriteLine("2th index value : " + hash2);




    }
}