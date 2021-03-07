using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lectures.Data;
using Lectures.DataAccess.Bases;
using Lectures.Models;

namespace Lectures.DataAccess
{
    public class MemoryOperations : OperationBase
    {
        public List<Lecture> GetLectures()
        {
            return LectureData.Lectures;
        }

        public void AddLectures(Lecture lecture)
        {
            lecture.Id = IncreaseId(LectureData.Lectures);
            LectureData.Lectures.Add(lecture);
        }

        public int IncreaseId(List<Lecture> lectures)
        {
            int id;
            if (lectures!=null&& lectures.Count>0)
            {
                Lecture lecture;
                lecture = lectures.LastOrDefault();
                id = lecture.Id + 1;
            }
            else
            {
                id = 1;
            }

            return id;
        }
    }
}
