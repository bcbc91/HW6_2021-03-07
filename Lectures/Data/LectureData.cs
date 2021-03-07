using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Lectures.Models;
using Category = Lectures.Enums.Category;
using Credit = Lectures.Enums.Credit;

namespace Lectures.Data
{
    public static class LectureData
    {
        public static  List<Lecture> Lectures { get; set; }
        

        static LectureData()
        {
           
            Lectures = new List<Lecture>()
            {
                new Lecture(){Id = 1,LectureName = "Enerji",Category =Enums.Category.Sayısal,Content = "Enerji Teknolojileri",Credit =Credit.FiveCredits},
                new Lecture(){Id = 2, LectureName = "Medeniyetler Tarihi",Category = Enums.Category.Sözel,Content = "İlkçağ Medeniyetleri",Credit = Enums.Credit.ThreeCredits},
                new Lecture(){Id = 3,LectureName = "Felsefe",Category = Category.Sözel,Content = "Helenistik Felsefe",Credit = Enums.Credit.TwoCredits}
            };
        }
     
    }
}
