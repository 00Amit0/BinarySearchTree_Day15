namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's check what's binary search tree");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);

            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
        }
    }
}
