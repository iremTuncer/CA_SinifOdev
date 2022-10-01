using DataAccess.Container;
using DataAccess.Entity;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BLL.ServiceRepository.Absract;

namespace BLL.ServiceRepository.Concrete
{
    public class Service
    {
        public List<Student> ServiceSubject()
        {
            BaseService<Student> _service= new BaseService<Student>();
            
            List<Student> studentList = _service.GetAll();
            List<Subject> subjectList = getAllSubject();
            Random random = new Random();

            for (int i = 0; i < studentList.Count; i++)
            {
                int rnd = random.Next(0, subjectList.Count - 1);

                studentList[i].SubjectId = subjectList[rnd].Id;

                subjectList.RemoveAt(rnd);

            }

            return studentList;
        }

        public List<Subject> getAllSubject()
        {
            BaseService<Subject> _subject = new BaseService<Subject>();
            List<Subject> subjectList = _subject.GetAll();

            return subjectList;
        }
    }

}
