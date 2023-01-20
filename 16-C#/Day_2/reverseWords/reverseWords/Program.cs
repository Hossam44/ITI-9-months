namespace reverseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Massege:");
            string str = Console.ReadLine();        //read the massage
            string[] words = str.Split(' ');        //split into Words
            Array.Reverse(words);                   //Revese Words
            str = string.Join(" ",words);           //concatinate Words 
            Console.WriteLine("Reversed Massege:");

            Console.WriteLine(str);                
        }
    }
}