using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static empty.Program;

namespace _10._Linq_Methods_Task
{
    public static class Class_Extention
    {
        public static int method(this int a) {
            return a  =  a<0 ? a:a*(-a) ;
        } 
    }
}
