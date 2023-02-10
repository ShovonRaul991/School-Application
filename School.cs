using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SchoolApplication
{
    public class School
    {
        public byte schoolId;
        public string schoolName;
        public School(byte schoolId, string schoolName)
        {
            this.schoolId = schoolId;
            this.schoolName = schoolName;
        }

        public List<Class> classList = new List<Class>();
        public List<staff> staffList= new List<staff>();
        
        public List<Class> manipulateClasses
        {
            get { return classList; }
            set { 
                    classList = value;
                    classList.ForEach(x => { 
                                            x.schoolIdsForClass.Add(this.schoolId);
                                            });   //multiple school can have same class
                }
        }
        

        public List<staff> manipulatestaffs
        {
            get { return staffList; }
            set { staffList = value;
                staffList.ForEach(x => {
                    x.schoolId = this.schoolId;    //staff can be allocated to one school
                });
            }
        }

        public void getSchoolDetails()
        {
            Console.WriteLine("School ID:- "+schoolId);
            Console.WriteLine("School Name:- " + schoolName);
            Console.WriteLine("Classes own:- ");
            for(var i=0;i<classList.Count;i++)
            {
                Console.WriteLine(classList[i].className+"\t");
            }
            Console.WriteLine("staffs own:- ");
            for (var i = 0; i < staffList.Count; i++)
            {
                Console.WriteLine(staffList[i].staffName + "\t");
            }
        }

    }

    public class Class
    {
        public byte classId;
        public string className;
        public List<byte> schoolIdsForClass = new List<byte>();

        public Class(byte classId,string className)
        {
            this.classId = classId;
            this.className = className;
        }
        public List<Student> studentList= new List<Student>();

        public List<Student> manipulateStudents
        {
            get { return studentList; }
            set { studentList = value; }
        }
        public void AddStudent(Student student)
        {
            studentList.Add(student);
            student.classId = this.classId;
        }
        public void showListOfStudent(List<Student> studentList)
        {
            var studentnames = studentList.Take(studentList.Count);
            foreach (var student in studentnames)
            {
                Console.WriteLine(className+ "\t" + student.FirstName);
            }
        }

    }

    public class Student{
        public string FirstName;
        public string LastName;
        public byte StudentId;
        public Byte classId;
        public byte SchoolId;
        public Student(byte studentId, string FirstName)
        {
            this.StudentId = studentId;
            this.FirstName = FirstName;
            //this.LastName = LastName;
        }
        
    }

    public class staff
    {
        public byte staffId;
        public string staffName;
        public byte schoolId;

        public staff(byte staffId, string staffName)
        {
            this.staffId = staffId;
            this.staffName = staffName;
        }
    }


}