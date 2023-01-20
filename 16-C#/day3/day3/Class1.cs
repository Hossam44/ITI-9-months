using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class EmployeeSearch
    {
        public static int count = 0;
        Emplouyee[] E;
        int[] nationalID;
        readonly int Size;

        public EmployeeSearch(int _size)
        {
            Size = _size;
            E = new Emplouyee[Size];
            nationalID= new int[Size];
        }
        public void insert_Employee(Emplouyee Emp)
        {
            E[count++] = Emp;
        }
        public Emplouyee this[string name] 
        {
            get
            {
                Emplouyee e = new Emplouyee();
                for(int i=0; i<Size; i++)
                {
                    if (E[i].Name==name)
                    {
                        e= E[i];
                    }
                }
                return e;
            }
        
        }
        public Emplouyee this[hirringDate hirring_date]
        {
            get
            {
                Emplouyee e = new Emplouyee();
                for (int i = 0; i < Size; i++)
                {
                    if (E[i].Date.Day == hirring_date.Day && E[i].Date.Year == hirring_date.Year && E[i].Date.Month == hirring_date.Month)
                    {
                        e = E[i];
                    }
                }
                return e;
            }

        }

        public Emplouyee this[int ID]
        {
            get
            {
                Emplouyee e = new Emplouyee();
                for (int i = 0; i < Size; i++)
                {
                    if (nationalID[i] == ID)
                    {
                        e = E[i];
                    }
                }
                return e;
            }

        }
        public Emplouyee this[int ID,string name]
        {
            get
            {
                Emplouyee e = new Emplouyee();
                for (int i = 0; i < Size; i++)
                
                    if (nationalID[i] == ID && E[i].Name == name)
                    {
                        e = E[i];
                    }
                
                return e;
            }
        }
    }
}