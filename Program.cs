using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace SchoolApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Adding classes 
            List<Class> ClassesToSchool = new List<Class>();
            
            Class class1 = new Class(1,"XA");
            Class class2 = new Class(2,"XB");
            Class class3 = new Class(3,"XIA");
            Class class4 = new Class(4,"XIB");
            Class class5 = new Class(5,"XIIA");
            Class class6 = new Class(6,"XIIB");
            

            ClassesToSchool.Add(class1);
            ClassesToSchool.Add(class2);
            ClassesToSchool.Add(class3);
            ClassesToSchool.Add(class4);
            ClassesToSchool.Add(class5);
            ClassesToSchool.Add(class6);

            List<School> listOfSchools = new List<School>();

            //create first school object;
            School school1 = new School(1, "DPS Public School");
            listOfSchools.Add(school1);
            school1.manipulateClasses = ClassesToSchool; //during this school id of added class: will print
            school1.getSchoolDetails();
            Console.WriteLine();

            //create second school objects;
            School school2 = new School(2, "Ryan International School");
            listOfSchools.Add(school2);
            school2.manipulateClasses = ClassesToSchool; //here the x.schoolId becomes 2
            school2.getSchoolDetails();
            Console.WriteLine();

            //staff creation;
            List<staff> staffToSchool = new List<staff>();

            staff staff1 = new staff(1, "James Cameron");
            staff staff2 = new staff(2, "Ryan Reynolds");
            staff staff3 = new staff(3, "John Sinha");


            staffToSchool.Add(staff1);
            staffToSchool.Add(staff2);
            staffToSchool.Add(staff3);



            school1.manipulatestaffs = staffToSchool;
            school1.getSchoolDetails();
            Console.WriteLine("The number of staff " + staffToSchool.Count);
            Console.WriteLine();

            //creating of student and student mapping

            Student student1 = new Student(1, "Steven");
            Student student2 = new Student(2, "Harish");
            Student student3 = new Student(3, "Sam");

            Student student4 = new Student(4, "Rohit");
            Student student5 = new Student(5, "Virat");
            Student student6 = new Student(6, "Dhoni");

            Student student7 = new Student(7, "Ben");
            Student student8 = new Student(8, "Mark");
            Student student9 = new Student(9, "Andrew");

            Student student10 = new Student(10, "Kane");
            Student student11= new Student(11, "Tin");
            Student student12= new Student(12, "Grame");
            Student student13 = new Student(13, "shawn");

            //adding them in different class of a particular school
            var school1Classes = school1.classList.Take(school1.classList.Count);
            foreach(var item in school1Classes)
            {
                if (item.className == "XA")
                {
                    item.AddStudent(student1); 
                    item.AddStudent(student2);
                    item.AddStudent(student3);
                    
                }
                else if(item.className == "XB")
                {
                    item.AddStudent(student4);
                    item.AddStudent(student5);
                    item.AddStudent(student6);
                    
                }
                else if(item.className == "XIA")
                {
                    item.AddStudent(student7); 
                    item.AddStudent(student8);
                    
                }
                else if(item.className == "XIB")
                {
                    item.AddStudent(student9);
                }
                else if(item.className == "XIIA")
                {
                    item.AddStudent(student10);
                    item.AddStudent(student11);
                }
                else if(item.className == "XIIB")
                {
                    item.AddStudent(student12);
                    item.AddStudent(student13);
                    
                }
                
                student1.SchoolId = school1.schoolId;
                student2.SchoolId = school1.schoolId;
                student3.SchoolId = school1.schoolId;
                student4.SchoolId = school1.schoolId;
                student5.SchoolId = school1.schoolId;
                student6.SchoolId = school1.schoolId;
                student7.SchoolId = school1.schoolId;
                student8.SchoolId = school1.schoolId;
                student9.SchoolId = school1.schoolId;
                student10.SchoolId = school1.schoolId;
                student11.SchoolId = school1.schoolId;
                student12.SchoolId = school1.schoolId;
                student13.SchoolId = school1.schoolId;
                


            }

            //Retrive the list of student in the class XIA of first school
            Console.WriteLine("\nRetrive the list of student in the class XIA of first school");
            foreach(var item in school1Classes)
            {
                if (item.className == "XA")
                {
                    item.showListOfStudent(item.studentList);
                    
                }
            }
            
            //who is the staff for andrew
            Console.WriteLine("\nwho is the staff for andrew: ");
            var staffsofSchool = listOfSchools[student10.SchoolId - 1].manipulatestaffs;
            foreach(var item in staffsofSchool.Take(staffsofSchool.Count()))
                {
                Console.WriteLine(item.staffName);
            }


            //kane is addmitted to which

            Console.WriteLine("\nkane is addmitted to which");
            Console.WriteLine(listOfSchools[student10.SchoolId-1].schoolName) ;
            
            
        }




    }

}
