using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    interface ILessonRegistration // UniversityStudent sınıfı için interface
    {
        void LessonRegistration(string number, string name, string lastname, string lesson); // Derse yazılım yapmak için 
        void LessonDelete(string number, string lesson);// Dersten kaydını onaylamazsa silmek için
    }
}

