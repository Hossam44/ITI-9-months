using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class ListCars
    {
        public static List<car> Allcars = new List<car>()
        {
            new car{ID=1,Model="BMW i7",Color="Black",Manfacture="BMW"},
            new car{ID=2,Model="dodge nitro",Color="White",Manfacture="dodge"},
            new car{ID=3,Model="Bentley Flying Spur",Color="Black",Manfacture="Bentley"},
            new car{ID=4,Model="Mercedes-Benz A-Class",Color="Black",Manfacture="Mercedes"},
            new car{ID=5,Model="Nissan Maxima",Color="Black",Manfacture="Nissan"},  
        };
    }
}