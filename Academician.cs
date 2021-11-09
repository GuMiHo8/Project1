using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    class Academician: Person //Person sınıfından türetilmiş diğer sınıf.
    {
        public string  Departmant { get; set; }
        public string Mail { get; set; }
        private int Salary { get; set; }// Salary bilgisini sadece Academician sınıfında kullanmak istediğim için private yapıldı.
        public Academician()
        {
            //
        }
        public Academician(string name, string lastname, char gender, int age, string departmant, string city) //yapıcı metot (constructure)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Gender = gender;
            this.Age = age;
            this.Departmant = departmant;
            this.City = city;

        }
        public override void Sleep() //Sleep fonsiyonunun bu sınıftaki işlevini değiştirmek için override kullanışmıştır.
        {
            base.Sleep();
            Console.WriteLine("Akademisyen olarak 8 saat uyudum");
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Yemek Yenildi. (Acadecisian)");
        }
        public override void DrinkWater() 
        {
            base.DrinkWater();
            Console.WriteLine("Yeteri kadar su içildi. (Academcisian)");
        }
        public void LessonPresentation(string lesson) // Ders anlatımı yapıldığının fonksiyonu
        {
            Console.WriteLine("{0}  dersi yapılmıştır.", lesson);
        }
        public void Anouncment(string lesson) // Duyuruların yapıldığı fonksiyon
        {
            Console.WriteLine("{0} dersi bugün yapılmayacaktır. Sınavda ise slaytın 144. sayfasına kadar sorumlusunuz.",lesson);
        }
        public void Exam(string lesson) // sınavın hazırlandığını belirtmek için hazırlanan fonkiyon
        {
            Console.WriteLine("{0} sınavı hazırlanmıştır",lesson);
        }

    }
}
