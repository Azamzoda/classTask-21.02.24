var per=new Person();
System.Console.WriteLine("Enter employee's FirstName: ");
per.FirstName = Console.ReadLine();
System.Console.WriteLine($"Enter employee's LastName: ");
per.LastName =Console.ReadLine();
System.Console.WriteLine($"Enter employee's Age:  ");
per.Age = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine($"Enter employee's Position: ");
 per.Position = Console.ReadLine();
 System.Console.WriteLine($"Enter employee's Salary: ");
 per.Salary = Convert.ToInt32(Console.ReadLine());
 
 
 System.Console.WriteLine();
 per.GetInfo();
 per.GetSalary();
 

public class Person
{
    public string FirstName; 
    public string LastName;
    public int Age;
    public string Position;
    public decimal Salary;

    public void SetSalary (decimal salary)
    {
        Salary=salary;
    }
    public float GetSalary()
    {
        return (float)Salary;
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"FirsName: {FirstName}");
        System.Console.WriteLine($"LastName: {LastName}");
        System.Console.WriteLine($"Age : {Age}");
        System.Console.WriteLine($"Position : {Position}");
        System.Console.WriteLine($"Salry: {Salary}");
    } 

}