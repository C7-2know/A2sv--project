using System;
using System.Collections;

public class Calculator
{
    public static void Main(){
        Console.WriteLine("Welcome Please Enter your name");
        var name= Console.ReadLine();
        Console.WriteLine("How many subjects do you take?");
        var number=int.Parse(Console.ReadLine());
        Dictionary<string,int> grades=new Dictionary<string, int>();
        while (grades.Count<number){
            try
            {
                Console.WriteLine("Enter the subject name");
                var nam=Console.ReadLine();
                Console.WriteLine($"Enter your mark for {nam} subject");
                var subj=Console.ReadLine();
                grades.Add(nam,int.Parse(subj));
            }
            catch (System.Exception)
            {   
                Console.WriteLine("invalid input please use appropriate type for each task!");
            }  
        }
        
        var total=0;
        Console.WriteLine($"Hello {name}, here is your marks for each subject and your average");
        foreach(KeyValuePair<String,int> pair in grades){
            Console.WriteLine($"        {pair.Key} : {pair.Value}");
            total+=pair.Value;
        };
        double average=total/grades.Count;
        Console.WriteLine($"your average mark is: {average}");
    }
}
