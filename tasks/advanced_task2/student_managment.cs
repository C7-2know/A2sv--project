using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Student
{
    public string Name {get;set;} 
    public int Age {get;set;} 
    public double Grade {get;set;} 
    public readonly int RollNumber;

    public Student() { }

    public Student(int rollNumber,string name, int age= 30, double grade=86.0)
    {
        Name = name;
        Age = age;
        Grade = grade;
        RollNumber = rollNumber;
    }
    
}

public class StudentList<T> where T:Student{
    public List<T> studentList {get;}=new List<T>();
    public void addStudent(T stud){
        studentList.Add(stud);
    }
    public List<T> filterStudent(string name){
        List<T> filtered= (from st in this.studentList
                            where st.Name==name select st).ToList();
        return filtered;
    }

    public string serializeStudentList(){
        string serialized=JsonSerializer.Serialize(this.studentList);
        Console.WriteLine(serialized);
        return serialized;
    }

    public void deSerializeStudentList(string serialized){
        List<T> deserialized=JsonSerializer.Deserialize<List<T>>(serialized);
        foreach (Student student in studentList)
        {
            Console.WriteLine($"{student.Name}");
        }
    }

}
public class Program{
    public static void Main(){
        Student st1=new Student(1,"bill");
        Student st2=new Student(2,"barel");
        Student st3=new Student(3,"ppll");
        Student st4=new Student(4,"delbin");

        StudentList<Student> stdList=new StudentList<Student>();
        stdList.addStudent(st1);
        stdList.addStudent(st2);
        stdList.addStudent(st3);
        stdList.addStudent(st4);
        string serialized=stdList.serializeStudentList();
        stdList.deSerializeStudentList(serialized);

    }
}
