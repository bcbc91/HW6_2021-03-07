using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lectures.Models;

namespace Lectures.DataAccess.Bases
{
    public interface OperationBase
    {
        List<Lecture> GetLectures();
        void AddLectures(Lecture lecture);
        int IncreaseId(List<Lecture> lectures);
    }
}
