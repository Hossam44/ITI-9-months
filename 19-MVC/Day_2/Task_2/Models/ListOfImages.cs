using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_2.Models
{
    public class ListOfImages
    {
        public static List<Image> imgSrcs = new List<Image>()
        {
            new Image(){ SrcOfImage = "1.jpg"},
            new Image(){ SrcOfImage = "2.jpg"},
            new Image(){ SrcOfImage = "3.jpg"},
            new Image(){ SrcOfImage = "4.jpg"},
            new Image(){ SrcOfImage = "5.jpg"},
            new Image(){ SrcOfImage = "6.jpg"},
            new Image(){ SrcOfImage = "7.jpg"}
        };
    }
}