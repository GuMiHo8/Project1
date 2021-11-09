using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    class UniversityStudent:Student,ILessonRegistration, IGrade // hem Student sınıfından hem de ILessonRegistration,IGrade interfacelerinden miras aldığını gösterir.
    {
        public string University { get; set; }
        public string Departmant { get; set; }
        private int GradeAvarage { get; set; } // Sadece bu sınıftan erişim olmasını istediğimiz için GradeAvarage değeri private yaptık. (Not ortalamasını gösterir)
        public int SumInternship { get; set; } // Staj günlerinin toplamını belirtir

        public UniversityStudent()
        {
            // yapıcı metot
        }
        public UniversityStudent(string name, string lastname, char gender, int age, string university, string departmant, int no) //yapıcı metot (constructure)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Gender = gender;
            this.Age = age;
            this.University = university;
            this.Departmant = departmant;
            this.No = no;
        }

        public override void JoinClass(string lesson) // Student sınıfındaki metotdan farklı işlevde kullanılması için ovveriding yapıldı.
        {
            base.JoinClass(lesson); // Bu sınıftan Student sınıfının üyelerine erişmek için kullnıldı.

            Console.WriteLine("{0} dersine girdim ve not aldım. (UniversityStudent)",lesson);
        }

        public void LessonRegistration(string number, string name, string lastname, string lesson) //Derse kayıt yapma fonksiyonu
        {

            Console.WriteLine("{0} numaralı {1} {2} , {3} dersine kayıt yapıyorsunuz......", number, name, lastname, lesson);
            Console.Write("Kaydedip çıkmak istiyorsanız <Enter> tuşuna tıklayınız....");

            if(Console.ReadKey().Key != ConsoleKey.Enter) // enter tuşuna basmadığında ders kaydı olmamış sayılacak.
            {
                LessonDelete(number, lesson);
            }
            else
                Console.WriteLine("{0} numaralı {1} {2} , {3} dersine kaydınız alınmıştır", number, name, lastname, lesson);

        }

        public void LessonDelete(string number, string lesson) // Ders kaydının onaylanmama fonksiyonu
        {
            Console.WriteLine("Ders kaydınız alınamamıştır tekrar kayıt yapınız.");
        }

        bool IGrade.GradeAvarage(int gradeAvarage) // ortalamaya göre karar verme fonksiyonu
        {
            this.GradeAvarage = gradeAvarage;
            if (GradeAvarage >= 2) // ortalama 2 ve üstünde değerse true değerini döner (Belki başka fonksiyon yapıp burdaki dönen bool değerini orda parametre kullanırım diye böyle yapıldı.)
            {
                Console.WriteLine("Üst sınıftan ders seçebilir veya mezun olabilirsin.");
                return true;
            }
            else   // ortalama 2 nin altındaysa false döndür.
                return false;

        }

        public void Internship(int day) // staj gününe göre karar verme fonksiyonu
        {
            this.SumInternship = day;

            if (SumInternship >= 30) // staj günün en az 30 ise stajın tamamlandığı yazısını bastırır.
            {
                Console.WriteLine("Stajını tamamladın.");
                
            }
            else
                Console.WriteLine("Stajının tamamlanması için {0} gün daha staj yapmalısın!", (30-day));
        }

        public void Continuity(int percent)//Devamsızlık için fonksiyon
        {
            if (percent <= 70)
                Console.WriteLine("Dersten devamsızlıktan kaldınız.");
            
            else
                Console.WriteLine("Devamsızlık sıkıntınız gözükmüyor, yine de derse devam etmeyi ihmal etmeyin.");
        }

        public void Exam(int examAvarage, int finalGrade) // Dersten geçip geçmeme olasılığı için bir fonsiyon
        {
            if ((finalGrade >= 45) || (examAvarage >= 60)) // final notu 45 ve üstü ve sınav ortalaması 60 ve üstü olduğu durumlarda bu ife girer.
                Console.WriteLine("Dersi başarıyla geçtiniz. ");

            if (finalGrade < 45 ) //final notu 45 altındaysa bu ife girer ve başarısız olduğunu ekrana bastırır.
                Console.WriteLine("final barajını geçemediniz bütte tekrar deneyiniz");
           
            else
                Console.WriteLine("Ortalamanız 60 altındadır bütte tekrar şansınızı deneyin.");
                                
        }
    }
}
