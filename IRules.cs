using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVize
{
    interface IRules //ComputerScienceStudent sınıfı için bir interface
    {
        void Learn(string Languages);//  programlama dili öğrenmesi için
        bool GetComputer(char answer); // okula bilgisayar getirmesi için

    }
}
