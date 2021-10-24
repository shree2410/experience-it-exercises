using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_in_c_sharp
{
    class Program
    {


        static void Main(string[] args)
        {
            //createing an object Create an object of the student Class (this will call the constructor)
            string[] subject = { "science", "math", "english" };
            Student raga = new Student("Raga", "virologist", subject, "dte", "ragav.com", "2482574098");
            raga.fullname = "ragavarshini";
            raga.myPrint();
            Student yash = new Student("yash", "veternerian", subject, "msu", "yash@.com", "2482764352");
            yash.myPrint();
            Student venk = new Student("venk", "softwareeng", subject, "wayne", "ram@.com", "2542565432");
            venk.myPrint();
            Student shree = new Student("shree", "healthcare", subject, "madras", "shree@.com", "248234267");
            shree.myPrint();
            

        }

    }

}
