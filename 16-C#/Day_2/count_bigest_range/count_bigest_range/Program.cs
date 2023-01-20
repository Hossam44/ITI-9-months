namespace count_bigest_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read size of array
            Console.WriteLine("Enter Size OF Numbers");
            int n = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("------------------------");

            Console.WriteLine("Enter Numbers");

            bool isTheSameNumber = true;       // for Equal numbers
            int largestLengh = -1;             // Take largest range
            int[]arr= new int[n];              // array of numers

            //get array
            arr[0] = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
                if (arr[i] != arr[i-1])
                    isTheSameNumber = false;
            }
            Console.WriteLine("------------------------");

            if (!isTheSameNumber)
            {
                //calculate Largest length
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j] && j-i > largestLengh)
                        {
                            largestLengh = j - i;
                        }
                    }
                }
                if(largestLengh == -1 )
                {
                    Console.WriteLine("NOT Found Same Number");
                }
                else
                {
                    Console.WriteLine($"Largest Range Equal:{largestLengh-1}");
                }
            }
            else
            {
                Console.WriteLine($"Largest Range Equal: {arr.Length-2}");
            }

        }
    }
}