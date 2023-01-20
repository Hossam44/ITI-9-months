namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id,day,month,year;
            Gender G;
            security_priviledge S;
            double salary;
            string name;
            string[] Date;
            string temp;
            EmployeeSearch All_emp = new EmployeeSearch(6);
            Emplouyee[] E = new Emplouyee[6];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter id Of {i + 1} Emloyee"); 
                id = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Name Of {i + 1} Emloyee");
                name = Console.ReadLine()??"Empty";

                Console.WriteLine($"Enter Date Of {i + 1} Emloyee");
                Date = (Console.ReadLine()).Split(" ");                     //Take all Date

                day= int.Parse(Date[0]);
                month = int.Parse(Date[1]);
                year = int.Parse(Date[2]);

                Console.WriteLine($"Enter salary Of {i + 1} Emloyee");      
                salary = double.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"Enter Gender Of {i + 1} Emloyee");
                    temp = Console.ReadLine();
                } while (temp != "Male" && temp != "Female");
                G = (Gender)Enum.Parse(typeof(Gender), temp);
                


                Console.WriteLine($"Enter Security Level Of {i + 1} Emloyee");
                S = (security_priviledge)Enum.Parse(typeof(security_priviledge), Console.ReadLine());
                
                E[i] = new Emplouyee(id,name ,salary, S, new hirringDate(year, month, day), G);
                Console.WriteLine("------------------------------------");

                Console.WriteLine(E[i].ToString());
                Console.WriteLine("------------------------------------");
                All_emp.insert_Employee(E[i]);

            }
            E[3] = new Emplouyee(1, "hossam", 10000,security_priviledge.guest, new hirringDate(2000, 12, 1), Gender.Male);
            E[4] = new Emplouyee(2, "ali", 10000, security_priviledge.Developer, new hirringDate(2001, 12, 1), Gender.Male);
            E[5] = new Emplouyee(3, "amr", 10000, security_priviledge.DBA, new hirringDate(2002, 12, 1), Gender.Male);
            
            All_emp.insert_Employee(E[3]);
            All_emp.insert_Employee(E[4]);
            All_emp.insert_Employee(E[5]);

        }
    }
}