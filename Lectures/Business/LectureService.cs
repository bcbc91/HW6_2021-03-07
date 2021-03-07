using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lectures.DataAccess.Bases;
using Lectures.Models;

namespace Lectures.Business
{
    public class LectureService
    {
        private readonly OperationBase _operationBase;

        public LectureService(OperationBase operationBase)
        {
            _operationBase = operationBase;
        }

        public List<Lecture> Get()
        {
           return _operationBase.GetLectures();
        }

        public void Add(Lecture lecture)
        {
            _operationBase.AddLectures(lecture);
        }
    }
}
