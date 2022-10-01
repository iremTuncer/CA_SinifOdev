using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Container
{
    public class ListeDb
    {
        public static List<Student> students = new List<Student>()
        {
            new Student{Ad ="Berkay", Soyad ="Yıldırım"},
            new Student{Ad ="Bilal", Soyad ="Kara"},
            new Student{Ad ="Doğukan", Soyad ="Blknc"},
            new Student{Ad ="Emir", Soyad ="Güven"},
            new Student{Ad ="Emre", Soyad ="Gözke"},
            new Student{Ad ="Fatih", Soyad ="Şallı"},
            new Student{Ad ="Ferhat", Soyad ="Harun"},
            new Student{Ad ="İbrahim", Soyad ="Sarıkaya"},
            new Student{Ad ="İrem", Soyad ="Tunçer"},
            new Student{Ad ="Kürşat", Soyad ="Mezireli"},
            new Student{Ad ="M.Can", Soyad ="Bozbuğa"},
            new Student{Ad ="Meriç", Soyad ="Aydoğan"},
            new Student{Ad ="Özgür", Soyad ="Okumuş"},
            new Student{Ad ="Sadık", Soyad ="Akgedik"},
            new Student{Ad ="Sait", Soyad ="Sait47"},
            new Student{Ad ="Strano", Soyad ="Artista"},
            new Student{Ad ="Umut", Soyad ="Yılbaş"},
            new Student{Ad ="Enes", Soyad ="Albayrak"},
        };
        public static List<Subject> subjects = new List<Subject>()
        {
            new Subject{KonuAdı="Aggregate Fonksiyonlar, Like, Where"},
            new Subject{KonuAdı="SQL- DML ve DDL Komutları"},
            new Subject{KonuAdı="Operatörler- Atama, Mantıksal, İlişkisel, Aritmatik, Birleşik Operatörler"},
            new Subject{KonuAdı="Karar Yapıları-If, Else, Elseif, Switch Case"},
            new Subject{KonuAdı="Döngüler-While, Do While, For, Foreach- ArrayList"},
            new Subject{KonuAdı="OOP-Encapsulation"},
            new Subject{KonuAdı="OOP-Inheritance"},
            new Subject{KonuAdı="OOP-Constructor"},
            new Subject{KonuAdı="OOP-Polymorphism"},
            new Subject{KonuAdı="OOP-Abstraction"},
            new Subject{KonuAdı="OOP-Interface ve Enum"},
            new Subject{KonuAdı="Entity Framework Db First-Code First"},
            new Subject{KonuAdı="Katmanlı Mimari"},
            new Subject{KonuAdı="SOLID Single Responsibility Principle"},
            new Subject{KonuAdı="SOLID Open/Closed Principle"},
            new Subject{KonuAdı="SOLID Liskov's Substitution Principle"},
            new Subject{KonuAdı="SOLID Interface Segregation Principle"},
            new Subject{KonuAdı="SOLID Dependency Inversion Principle"},
            new Subject{KonuAdı="Singleton"},
            new Subject{KonuAdı="Factory Pattern"},
        };

    }
}
