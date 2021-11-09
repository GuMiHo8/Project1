using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    abstract class Person // Person sınıfı, başka sınıflara base classı olması için abstract class yapılmıştır. (sadece türetiebilir)
    {
        public string Name { get; set; } // public tüm sınıflardan erişim sağlanması için public değişken kullanılmıştır.
        public string LastName { get; set; }
        public char Gender { get; set; } // char değişkeni yapıldı bu yüzden Erkek ise 'E' , Kadın ile 'K' ile belirtilsi .
        public int Age { get; set; } // Age parametresi int değerinde yapıldı çünkü işlem Period() da Age ile işlem yapılıyor.
        public string City { get; set; }

        public Person() { } //yapıcı metot (new ile nesne oluşturulduğunda arka planda çalışır)

        public void Period(int age)// Sokağa çıkıp çıkmamak için fonksiyon 
        {
            
            if (age < 18 && age >=65 ) // eğer 18 yaş altı ve 65 yaş üstüysen sokağa sadece belirli saatlerde çıkabilirsin
                Console.WriteLine("13-16 saattleri dışında sokağa çıkamazsınız, bu saatlerde dışardaysanız sosyal mesafeye dikkat ediniz");
          
            else
                Console.WriteLine("Sosyal mesafe ve temizliğe dikkat ediniz, işiniz olmadıkça dışarı çıkmayınız.");
        }

        public virtual void Sleep() // Daha sonrasında içeriği değiştirilebilsin diye sanal metot kullanıyoruz. Diğer sınıflarda değiştirmek için override ile kulanılır.
        {
            Console.WriteLine("Günde ortalama 8 saat uyumalısın (Person)");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Öğünlerini aksatmamalısın (Person)");
        }
        public virtual void DrinkWater()
        {
            Console.WriteLine("Ortalama 1.5 litre su içmelisin (Person)");
        }
    }
}
