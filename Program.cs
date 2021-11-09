//19770300028 - MUSTAFA İSKENDEROĞLU 
// NESNE YÖNELİMLİ PROGRAMLAMA II VİZE 

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
            compstudent1.Name = "Mustafa";
            compstudent1.LastName = "İskenderoğlu";
            compstudent1.Age = 20;
            compstudent1.Gender = 'E';
            compstudent1.City = "Trabzon";
            compstudent1.University = "Ordu Üniversitesi Ünye Meslek Yüksek Okulu";
            compstudent1.Departmant = "Bilgisayar Programcılığı";
            compstudent1.No = 19770300028;
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
            ComputerScienceStudent compstudent2 = new ComputerScienceStudent("Mustafa","İskenderoğlu",'E',20,"Ordu Üniversitesi","Bilgisayar Programcılığı 1. Öğretim",19770300028, 'E');
            compstudent2.GetStudent();
            Console.WriteLine("************************************************************************************************************************");
            compstudent2.LessonRegistration("19770300028", "Mustafa","İskenderoglu", "OOP"); // Derse kayıt olma örneği
            Console.WriteLine("************************************************************************************************************************");
            compstudent2.Internship(32); // stakj gün sayısı parametre alır
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
            //student2.Name = "Mustafa";
            //student2.LastName = "İskenderoğlu";
            //student2.Age = 24;
            //student2.Gender = 'E';
            //student2.City = "Trabzon";
            //student2.University = "karadeniz Teknik Üniversitesi";
            //student2.Departmant = "Bilgisayar Mühendisliği";
            //student2.No = 61616161;

            //student2.LessonRegistration("19770300028", "Mutas", "İskenderoğlu", "Nesne Yönelimli Programlama");
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
            //academician1.Name = "Furkan";
            //academician1.LastName = "Akın";
            //academician1.Mail = "furkanakin@odu.edu.tr";
            //academician1.City = "Ordu";
            //academician1.Departmant = "Bilgisayar Bilimi";

            //academician1.LessonPresentation("Nesne Yönelimli Programlama II");
            //academician1.Exam(lesson);



            Console.ReadLine(); 
        }
    }
}
