using System;
using System.Collections.Generic;
using BLL.ServiceRepository.Concrete;
using DataAccess.Entity;

namespace Presantation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            List<Subject> subject = new List<Subject>();
            Service service = new Service();

            subject = service.getAllSubject();
            students = service.ServiceSubject();

            foreach (var item in students)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + "  :  " + subject[item.SubjectId].KonuAdı );
            }

            Console.ReadLine();
        }
    }
}
