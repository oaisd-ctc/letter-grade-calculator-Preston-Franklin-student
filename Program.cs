using System;

public class Program
{
    public static void Main(string[] args)
    {
        int grade;
        Console.WriteLine("Enter the grade your have in class");
        string classGrade = Console.ReadLine();
        grade = Int32.Parse(classGrade);
        while(grade !< 0 || grade !> 100){
        Console.WriteLine("Enter the grade your have in class");
        classGrade = Console.ReadLine();
        grade = Int32.Parse(classGrade);
        }
        if(grade >= 100){
            Console.WriteLine("A+");
            Console.WriteLine("Wow! 100... That's impressive!");
        }
        else if(grade >= 90){
            Console.WriteLine("A");
            Console.WriteLine("Very Nice!");
        }
        else if(grade >= 80){
            Console.WriteLine("B");
            Console.WriteLine("Keep it up!");
        }
        else if(grade >= 70){
            Console.WriteLine("C");
            Console.WriteLine("You got this, keep working!");
        }
        else if(grade >= 60){
            Console.WriteLine("D");
            Console.WriteLine("Keep trying!");
        }
        else{
            Console.WriteLine("E");
            Console.WriteLine("Don't give up!");
        }
    }

    
}
