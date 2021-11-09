
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student st1 = new ComputerScienceStudent { Name = "Mustafa", LastName = "İSKENDEROĞLU", No = 19770300028, City = "TRABZON", Departmant = "Yazılım", SumInternship = 15 };
            //st1.DrinkWater();
            //st1.StudyLesson("C++");


            ///////////////////////////////////////////////////////////////////////////////////////////////////

            // ComputerScienseStudent sınıfından nesne oluşturma

            ComputerScienceStudent compstudent1 = new ComputerScienceStudent();
            compstudent1.Name = "Güler";
            compstudent1.LastName = "İskenderoğlu";
            compstudent1.Age = 23;
            compstudent1.Gender = 'K';
            compstudent1.City = "Trabzon";
            compstudent1.University = "KTÜ";
            compstudent1.Departmant = "Bilgisayar Mühendisliği";
            compstudent1.No = 348303;
            compstudent1.Computer = 'E';

            //ComputerScienseStudent sınıfından fonksiyon çağırma işlemleri
            Console.WriteLine("************************************************************************************************************************");
           // compstudent1.GetStudent(); // compstudent1 öğrencisinin bilgilerini ekrana bastırma
            compstudent1.GetComputer('e'); //bilgisayar olduğunu parametre alan fonsiyon çağırma
            Console.WriteLine("************************************************************************************************************************");
            compstudent1.Learn("c#"); // c# dilini öğrenmek için Parametre alan fonsiyonu çağırma
            Console.WriteLine("************************************************************************************************************************");
            compstudent1.JoinClass("Görsel Programlama");

            Console.WriteLine("************************************************************************************************************************");
            //aynı sınıftan farklı biçimde başka bir nesne oluşturma
            ComputerScienceStudent compstudent2 = new ComputerScienceStudent("Mustafa","İskenderoğlu",'E',20,"Ordu Üniversitesi","Bilgisayar Programcılığı 1. Öğretim",11111222222, 'H');
            compstudent2.GetStudent();
            Console.WriteLine("************************************************************************************************************************");
            compstudent2.LessonRegistration("111111111", "Mustafa","İskenderoglu", "OOP"); // Derse kayıt olma örneği
            Console.WriteLine("************************************************************************************************************************");
            compstudent2.Internship(32); // staj gün sayısı parametre alır
            Console.WriteLine("************************************************************************************************************************");
            compstudent2.Continuity(85);// Ders devam yüzdesini parametre alır
            Console.WriteLine("************************************************************************************************************************");
            compstudent2.Exam(60, 45); //sınavdan başarılı olduğunu belirten örnek(ilk parametre iki sınavın ortalaması, 2. si final notu )
            Console.WriteLine("************************************************************************************************************************");
            compstudent2.Exam(24, 60);



            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //// UniversityStudent sınıfındn nesne oluşturma
            ///
            //UniversityStudent student2 = new UniversityStudent();
            //student2.Name = "Gumiho";
            //student2.LastName = "Güler";
            //student2.Age = 24;
            //student2.Gender = 'K';
            //student2.City = "Trabzon";
            //student2.University = "Karadeniz Teknik Üniversitesi";
            //student2.Departmant = "Bilgisayar Mühendisliği";
            //student2.No = 61616161;

            //student2.LessonRegistration("123468", "Mutas", "Güler", "Nesne Yönelimli Programlama");
            //student2.JoinClass("Görsel Programlama");
            //student2.Internship(25);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////Student sınıfından nesne oluşturma

            //Student student = new Student();
            //student1.LastName = "İskenderoğlu";
            //student1.Age = 15;
            //student1.Gender = 'E';
            //student1.No = 126;
            //student1.Class = 2;

            //student1.StudyLesson("Matematik");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////Academician sınıfından nesne oluşturma

            //Academician academician1 = new Academician();
            //academician1.Name = "Güler";
            //academician1.LastName = "Gumiho";
            //academician1.Mail = "gumiho@ktu.edu.tr";
            //academician1.City = "Trabzon";
            //academician1.Departmant = "Bilgisayar Bilimi";

            //academician1.LessonPresentation("Nesne Yönelimli Programlama II");
            //academician1.Exam(lesson);



            Console.ReadLine(); 
        }
    }
}
