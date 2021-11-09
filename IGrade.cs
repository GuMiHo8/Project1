using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    interface IGrade // interface, rehberlik ettiği tüm sınıflarda otomatik olarak olmasını istediğimiz metorları barındırır.
    {
        bool GradeAvarage(int gradeAvarage); // Ortalamasının 2 üstü olması için (interface public yapıda olduğu için metodun başında bu tür belirtilmez)
        void Internship(int day); // Staj yapması için
        void Continuity(int percent); // Derse devam zorunluluğu için 
        void Exam(int gradeAvarage, int finalGrade); //sınav ortalaması 60, final sınavı 45 üstü alması zorunluluğu olduğu için 

    }
}
