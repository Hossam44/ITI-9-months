using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day3
{
    public struct Emplouyee
    {
        int id;
        string name;
        security_priviledge security_level;
        double salary;
        hirringDate date;
        Gender gen;

        public Emplouyee(int _id,string _name, double _salary, security_priviledge _security_level, hirringDate _Date, Gender _Gen)
        {
            id = _id;
            name = _name;
            security_level = _security_level;
            salary = _salary;
            date = _Date;
            gen = _Gen;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public security_priviledge Security_level
        {
            get { return security_level; }
            set { security_level = value; }
        }
        public hirringDate Date
        {
            get { return date; }
            set { date = value; }
        }


        public Gender Gen
        {
            get { return gen; }
            set { gen = value; }
        }

        public override string ToString()
        {
            string sal = salary.ToString("C", new CultureInfo("en-US"));
            return $"id:{id}\n Securty :{security_level}\n Salary :{sal}\n Date :{date.Year} {date.Month} {date.Day}\n GEnder :{Gen}";
        }
    }
    public enum Gender
    {
        Male, Female
    }
    public enum security_priviledge
    {
        guest=8,Developer=4,security=2,DBA=1,officer=15
    }
}
