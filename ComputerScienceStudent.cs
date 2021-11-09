using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    internal class ComputerScienceStudent : UniversityStudent, IRules // UniversityStudent sınıfından ve IRules interfaceinden miras alır.
    {
        public char Computer { get; set; } //bilgisayar olup olmaması 

        public ComputerScienceStudent() { }
        public ComputerScienceStudent(string name,string lastName, char gender, int age, string university, string departmant, long no, char computer)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Gender = gender;
            this.Age = age;
            this.University = university;
            this.Departmant = departmant;
            this.No = no;
            this.Computer = computer;
        }
        
        public void GetStudent() // Öğrencinin bilgilerini ekrana bastırır. 
        {
            Console.WriteLine("AD           : {0} ", Name);
            Console.WriteLine("SOYAD        : {0} ", LastName);
            Console.WriteLine("Cinsiyet     : {0} ", Gender);
            Console.WriteLine("Yaş          : {0} ", Age);
            Console.WriteLine("Üniversite   : {0} ", University);
            Console.WriteLine("Bölüm        : {0} ", Departmant);
            Console.WriteLine("Okul numarası: {0} ", No);
        }
        public bool GetComputer(char answer)// bilgisayar getirdiğinin kontrolu 
        {
            if (answer == 'e' || answer == 'E') // bilgisayar yanındaysa e veya E kullanılacağından koşul sağlandığında ife girer.
            {
                Console.WriteLine("Tebrikler bugünkü gibi bilgisayarını her zaman getirmelisin :D");
                return true;
            }
            else
                Console.WriteLine("Okula gelirken bilgisayarını getirmelisin!.");
            return false;
        }

        public void  Learn(string languages) // Programlama öğrenme fonksiyonnu parametre olara bir programlama dili alır ve bunu öğretmeni sağlar
        {
             Console.WriteLine("{0} Programlama dilini öğrendin",languages);
        }
    }
}
