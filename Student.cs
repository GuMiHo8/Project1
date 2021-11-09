using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    class Student:Person // Person sınıfından türetilmiş bir sınıftır.
    {
        protected string Class { get; set; } // Class değişkenini, yalnızca bu sınıfta ve bu sınıftan türetilmiş sınıflarda erişimine izin vermek için protected kullandım.
        public long No { get; set; }

        public Student()
        {
            // 
        }
        public Student(string name, string lastname, char gender, int age, string classs1, int no, string city) //yapıcı metot (constructure)
        {
            this.Name = name; //Student sınıf içindeki değişkenlere erişimi için kullanılır. (Burda constructor dan name parametresini gelen değişkeni Name parametresine atadık.)
            this.LastName = lastname;
            this.Gender = gender;
            this.Age = age;
            this.Class = classs1;
            this.No = no;
            this.City = city;
        }
        public override void Sleep() // Person sınıftaki aynı addaki metot yerine bu sınıftaki metodu kullanmak için override kullandık.
        {
            base.Sleep();
            Console.WriteLine("Öğrenci olarak bugün de güzel uyudum :D");
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Yemeğimi yedim");
        }
        public override void DrinkWater()
        {
            base.DrinkWater();
            Console.WriteLine("Suyumu içildi(Student)");
        }
        public virtual void JoinClass(string lesson) // Derse katıldığını gösteren fonksiyon
        {
            Console.WriteLine("Bugün " + lesson + " dersine girdim.(Student)");
        }
        public virtual void  StudyLesson(string lesson) // Ders çalıştığını gösteren Fonksiyon
        {
            Console.WriteLine("{0} dersine çalıştım", lesson);
        }

    }
}
