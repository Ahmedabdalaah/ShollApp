// See https://aka.ms/new-console-template for more information
using ShollApp;
Person p = new Person();
Teacher t = new Teacher();
Student s = new Student();
Employee e = new Employee();
Department d = new Department();
Course c = new Course();
Console.WriteLine("choose : ");
Console.WriteLine(" a: add new teacher : ");
Console.WriteLine(" b: add new student ");
Console.WriteLine(" c: add new employee ");
Console.WriteLine(" d: add new department");
Console.WriteLine(" e: add new course");
try
{

    string choose = Console.ReadLine();
     if(choose == "a")
    {
        Console.WriteLine("Enter fisrt name ");
        string first = Console.ReadLine();
        t.firstName = first;
        Console.WriteLine("Enter last name ");
        string last = Console.ReadLine();
        t.lastName = last;
        Console.WriteLine("Enter Address ");
        string addr = Console.ReadLine();
        t.addres = addr;
        Console.WriteLine("Enter age ");
        string ag = Console.ReadLine();
        int age = Convert.ToInt32(ag);
        t.age = age;
        Console.WriteLine("Enter salary ");
        string sal = Console.ReadLine();
        double salary = Convert.ToDouble(sal);
        t.salary = salary;
        Console.WriteLine("Enter email ");
        string mail = Console.ReadLine();
        t.email = mail;
        t.addTeacher();
    }
    else if (choose == "b")
    {
        Console.WriteLine("Enter fisrt name ");
        string first = Console.ReadLine();
        s.firstName = first;
        Console.WriteLine("Enter last name ");
        string last = Console.ReadLine();
        s.lastName = last;
        Console.WriteLine("Enter Address ");
        string addr = Console.ReadLine();
        s.addres = addr;
        Console.WriteLine("Enter age ");
        string ag = Console.ReadLine();
        int age = Convert.ToInt32(ag);
        s.age = age;
        Console.WriteLine("Enter grade ");
        string grade = Console.ReadLine();
        s.grade = grade;
        s.addStudent();
    }
    else if (choose == "c")
    {
        Console.WriteLine("Enter fisrt name ");
        string first = Console.ReadLine();
        e.firstName = first;
        Console.WriteLine("Enter last name ");
        string last = Console.ReadLine();
        e.lastName = last;
        Console.WriteLine("Enter Address ");
        string addr = Console.ReadLine();
        e.addres = addr;
        Console.WriteLine("Enter age ");
        string ag = Console.ReadLine();
        int age = Convert.ToInt32(ag);
        e.age = age;
        Console.WriteLine("Enter department ");
        string dept = Console.ReadLine();
        e.department = dept;
        e.addEmployee();
    }
    else if (choose == "d")
    {
        Console.WriteLine("Enter department name ");
        string name = Console.ReadLine();
        d.name = name;
        d.addDept();
    }
    else if (choose == "e")
    {
        Console.WriteLine("Enter course name ");
        string name = Console.ReadLine();
        c.name = name;
        c.addCourse();
    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}