using System;

public class Encapsulation
{
    private String studentName;
    private int studentAge;
    public String Name
    {
        get
        {
            return studentName;
        }

        set
        {
            studentName = value;
        }

    }
    public int Age
    {

        get
        {
            return studentAge;
        }

        set
        {
            studentAge = value;
        }

    }
}
class EncapDemo
{
    static public void Main()
    {
        Encapsulation obj = new Encapsulation();
        obj.Name = "Ankita";
        obj.Age = 21;
        Console.WriteLine("Name: " + obj.Name);
        Console.WriteLine("Age: " + obj.Age);
    }
}