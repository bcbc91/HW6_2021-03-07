using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lectures.Enums;

namespace Lectures.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string LectureName { get; set; }
        public Enums.Category Category { get; set; }
        public string Content { get; set; }
        public Enums.Credit Credit { get; set; }
    }
}
