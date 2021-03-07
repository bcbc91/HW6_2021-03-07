using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lectures.DataAccess.Bases;
using Lectures.Models;

namespace Lectures.DataAccess
{
    
    public class FileOperations:OperationBase
    {
        private readonly string _path;
        private const char _seperator = ';';

        public FileOperations(string path)
        {
            _path = path;
        }

        
        public List<Lecture> GetLectures()
        {
            List<Lecture> lectures = new List<Lecture>();
            StreamReader streamReader = new StreamReader(_path, Encoding.UTF8);
            string line;
            Lecture lecture;
            while ((line=streamReader.ReadLine())!=null)
            {
                var lectureData = line.Split(_seperator);
                lecture = new Lecture()
                {
                    Id = Convert.ToInt32(lectureData[0]),
                    LectureName = lectureData[1],
                    Category = (Enums.Category) Convert.ToInt32(lectureData[2]),
                    Content = lectureData[3],
                    Credit = (Enums.Credit)Convert.ToInt32(lectureData[4])
                };
                lectures.Add(lecture);
            }
            streamReader.Close();
            return lectures;
        }

        public void AddLectures(Lecture lecture)
        {
            List<Lecture> lectures = GetLectures();
            lecture.Id = IncreaseId(lectures);
            StreamWriter streamWriter = new StreamWriter(_path, true, Encoding.UTF8);
            string line = "\n" + lecture.Id + _seperator.ToString() + lecture.LectureName + _seperator.ToString() +
                        (int)lecture.Category + _seperator.ToString() + lecture.Content + _seperator.ToString() +(int)lecture.Credit;
            streamWriter.Write(line);
            streamWriter.Close();
        }

        public int IncreaseId(List<Lecture> lectures)
        {
            int id;
            if (lectures != null && lectures.Count > 0)
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
