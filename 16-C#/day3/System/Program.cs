using day3;

namespace System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id,day,month,year;
            Gender G;
            security_priviledge S;
            double salary;
            Emplouyee []E = new Emplouyee[3];

            for(int i=0;i<3;i++)
            {
                Console.WriteLine($"Enter id Of {i+1} Emloyee");
                id=int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter day Of {i + 1} Emloyee");
                day = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter month Of {i + 1} Emloyee");
                month = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter year Of {i + 1} Emloyee");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter salary Of {i + 1} Emloyee");
                salary= double.Parse(Console.ReadLine());
                //do
                
                    Console.WriteLine($"Enter Gender Of {i + 1} Emloyee");
                    G = (Gender) Enum.Parse(typeof(Gender),Console.ReadLine());
                
                //while(G=)
                Console.WriteLine(G);

                Console.WriteLine($"Enter Security Level Of {i + 1} Emloyee");
                S = (security_priviledge)Enum.Parse(typeof(security_priviledge), Console.ReadLine());
                E[i]=new Emplouyee(id,salary,S,new hirringDate(year, month, day), G);
                E[i].ToString();
            }

        }
    }
    
}

