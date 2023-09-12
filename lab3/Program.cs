using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ass3;

namespace assimblydifferent
{   // Q3 program
    class Pro : Question_3
    {
        public static void Main(String[] vs)
        {
            Pro e1 = new Pro();
            e1.name = "rohit";
            e1.course = "bca";
            Console.WriteLine(e1.Detail());
            Console.ReadKey();

        }
    }

    //Question 5
    class Question_5A : Question_5
    {
        static void Main()
        {
            Question_5A c1 = new Question_5A();
            c1.Display();
            Console.ReadLine();
        }
    }

    //Question 10
    class pro10 : Question_10
    {
        static void Main()
        {
            Question_10 instance = new Question_10();
            instance.publiMethod();
        }
    }
}

