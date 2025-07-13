using  System;
public class Student {
    public string Name;
    public int Age;
    public double Grade;

    //default constucor 
    public Student()
    {
        Name= "kushal";
        Age = 21;
        Grade= 10;
    }
//parameterized constructor
public Student(string name, int age, double grade)
{
    Name = name;
    Age = age;
    Grade = grade;
}
public void Display()
{
    Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
}

static void Main()
{
    Student student1 = new Student();
    Student student2 = new Student("kumar", 19, 9.99);

    student1.Display();
    student2.Display();

}
}





