using System;

namespace method_in_c_sharp
{
    class Student
    {
        //create field
        public string fullname; 
        public string course;
        public string[] subject;
        public string university;
        public string e_mail;
        public string phonenumber;
        //create Constructors with multiple parameters, which is used to initialize fields.
        public Student(string mfullname, string mcourse, string[] msubject, string muniversity, string me_mail, string mphonenumber)
        {
            fullname = mfullname;
            course = mcourse;
            subject = msubject;
            university = muniversity;
            e_mail = me_mail;
            phonenumber = mphonenumber;
        }
        //create method
        public void myPrint()
        {
            Console.WriteLine("fullname:" +fullname);
            Console.WriteLine("course:"+course);
            Console.WriteLine("subject:"+subject);
            Console.WriteLine("university:" + university);
            Console.WriteLine("course:" + course);
            Console.WriteLine("course:" + course);

        }



    }
}