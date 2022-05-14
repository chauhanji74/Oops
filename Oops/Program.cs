using System;

namespace Oops
{
    //internal class abc
    //{
    //    public int age;
    //    public string name;
    //    public static string clg = "Rit";

    //}

    //internal class Program
    //{
    //    int num ;
    //    public void getNum(int num)
    //    {
    //        this.num = num;
    //    }
    //    public void setNum()
    //    {
    //        Console.WriteLine(this.num);
    //    }


    //    static void Main(string[] args)
    //    {
    //        abc lalit = new abc();
    //        lalit.age = 21;
    //        lalit.name = "Lalit Singh Chauhan";
    //        Console.WriteLine(lalit.age);
    //        Console.WriteLine(lalit.name);
    //        Console.WriteLine(abc.clg);

    //        abc prince = new abc(); 
    //        prince.age = 22;
    //        prince.name = "Prince Kaushik";
    //        Console.WriteLine(prince.age);
    //        Console.WriteLine(prince.name);
    //        Console.WriteLine(abc.clg);

    //    }
    //}



    // Copy Constructor ---------------------------------------------------------

    //class Example
    //{
    //    public string name;
    //    public int age;

    //    public Example(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //    public Example(Example e)
    //    {
    //        this.name = e.name;
    //        this.age = e.age;
    //    }
    //    public void getN()
    //    {
    //        Console.WriteLine(name);
    //        Console.WriteLine(age);
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Example obj = new Example("lalit", 21);
    //        obj.getN();
    //        Example obj2 = new Example(obj);
    //        obj2.getN();
    //    }
    //}


    //private Constructor--------------------------------------------------------------
    //class Example
    //{
    //    private Example()
    //    {

    //    }

    //    public static int inc(int a)
    //    {
    //        return ++a;
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine(Example.inc(20));
    //    }
    //}


    //static class -----------------------------------------------------------

    //static class Example
    //{
    //    public static string name;
    //    public static int age;
    //    public static int salary;

    //    static Example()
    //    {
    //        name = "lalit";
    //        age = 21;
    //        salary = 1500;
    //    }
    //    public static void getData()
    //    {
    //        Console.WriteLine("name: {0}", name);
    //        Console.WriteLine("age: {0}", age);
    //        Console.WriteLine("salary: {0}", salary);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Example.getData();
    //    }
    //}


    //Destructor -----------------------------
    //class dstr
    //{
    //    public string name;
    //    public int age;

    //    public dstr(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //    public void getDstr()
    //    {
    //        Console.WriteLine(name);
    //        Console.WriteLine(age);
    //    }
    //    ~dstr()
    //    {
    //        Console.WriteLine("destructor invoked");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        dstr d1 = new dstr("lalit",21);
    //        d1.getDstr();
    //        dstr d2 = new dstr("anshul", 14);
    //        d2.getDstr();
    //    }
    //}


    //inheritance ----------------------------------------------
    //class employee
    //{
    //    public int empId;
    //    public string name;
    //    public int age; 
    //}
    //class Vemployee : employee
    //{
    //    public int salary;
    //}
    //class Pemployee : employee
    //{
    //    public int salary;
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Vemployee v = new Vemployee();
    //        v.empId = 100;
    //        v.name = "abhishek";
    //        v.age = 25;
    //        v.salary = 15000;
    //        Pemployee p = new Pemployee();
    //        p.empId = 200;
    //        p.name = "lalit";
    //        p.age = 21;
    //        p.salary = 25000;
    //        Console.WriteLine("{0}\n{1}\n{2}\n{3}",v.empId,v.name,v.age,v.salary);
    //        Console.WriteLine("{0}\n{1}\n{2}\n{3}", p.empId, p.name, p.age, p.salary);
    //    }
    //}


    //constructor in Inheritance ----------------------------------------------------
    //class Baseclass
    //{
    //    public Baseclass(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}
    //class Derivedclass : Baseclass
    //{
    //    public Derivedclass() :base("hi i am base")
    //    {
    //        Console.WriteLine("Constructor of derived class");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Derivedclass d = new Derivedclass();    
    //    }
    //}

    //Access Specifires OR Access Modifiers-------------------------------------
    //public class class1
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("show");
    //    }
    //}
    //class Program : class1
    //{
    //    static void Main(string[] args)
    //    {
    //        Program c = new Program();
    //        c.show();
    //    }
    //}


    //Encapsulation -------------------------------------------
    //class person
    //{
    //    private string name;
    //    private int age;

    //    public void setName(string name)
    //    {
    //        if( string.IsNullOrEmpty(name) == true)
    //        {
    //            Console.WriteLine("please enter name ");
    //        }
    //        else
    //        {
    //            this.name = name;
    //        }
    //    }
    //    public void getName()
    //    {
    //        Console.WriteLine("Name: {0}",name);
    //    }
    //    public void setAge(int age)
    //    {
    //        if (age <= 0)
    //        {
    //            Console.WriteLine("enter valid age");
    //        }
    //        else
    //        {
    //            this.age = age; 
    //        }
    //    }
    //    public void getAge()
    //    {
    //        Console.WriteLine("Age: {0}",age);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[]arg)
    //    {
    //        person p = new person();
    //        p.setName("Lalit singh chauhan");
    //        p.getName();
    //        p.setAge(21);
    //        p.getAge();
    //    }
    //}


    //Properties - get,set ----------------------------------------------------
    //class student
    //{
    //    int sId;
    //    //string sName;

    //    public int SId
    //    {
    //        set
    //        {
    //            this.sId = value;
    //        }
    //        get
    //        {
    //            return this.sId;
    //        }
    //    }
    //    public string sName { get; private set; }
    //    public student(string SName)
    //    {
    //        this.sName = SName;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        student s = new student("Lalit singh chauhan");
    //        s.SId = 54;
    //        Console.WriteLine("Sid: {0}",s.SId);
    //        //s.sName = "lalit singh";
    //        Console.WriteLine(s.sName);

    //    }
    //}


    // Static Properties --------------------------------------------------------------
    //class university
    //{
    //    private static string universityName;

    //    public static string _universityName
    //    {
    //        set
    //        {
    //            universityName = value;
    //        }
    //        get
    //        {
    //            return universityName;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        university._universityName = "RIT";
    //        Console.WriteLine("University: {0}",university._universityName);
    //    }
    //}


    //Polymorphism ----------------------------------------------------------------------------
    //class Program
    //{
    //    public void add(int a, int b)
    //    {
    //        int c = a + b;
    //        Console.WriteLine(c);
    //    }
    //    public void add(string a, string b)
    //    {

    //        string c = a + b;
    //        Console.WriteLine(c);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program p = new Program();
    //        p.add("la", "lit");
    //        p.add(11, 10);
    //    }
    //}

    //Count Composite no. ----------------------------------------------------------------------
    //class program
    //{
    //    public void composite(int num)
    //    {
    //        int count2 = 0;
    //        for (int a = 1; a <= num; a++)
    //        {
    //            int count = 0;
    //            for (int i = 2; i <= a / 2; i++)
    //            {
    //                if (a % i == 0)
    //                {
    //                    count++;
    //                    break;
    //                }
    //            }

    //            if (count == 0 && a != 1)
    //            {
    //                count2++;
    //                //Console.WriteLine(a);
    //            }
    //        }
    //        Console.WriteLine(num - (count2 + 1));
    //        //Console.WriteLine(count);   
    //    }
    //    static void Main(string[] args)
    //    {
    //        program p = new program();
    //        p.composite(15);
    //    }
    //}

    //operator Overloading ----------------------------------------------
    // class NewCLass
    // {
    //     public string str;
    //     public int num;
    //     public static NewCLass operator +(NewCLass obj1, NewCLass obj2)
    //     {
    //         NewCLass obj3 = new NewCLass();
    //         obj3.str = obj1.str + " " + obj2.str;   
    //         obj3.num = obj1.num + obj2.num;
    //         return obj3;
    //     }
    // }
    //class Program
    //{
    //     static void Main(string[] args)
    //     {
    //         NewCLass obj1 = new NewCLass();
    //         obj1.str = "lalit";
    //         obj1.num = 20;

    //         NewCLass obj2 = new NewCLass();
    //         obj2.str = "singh";
    //         obj2.num = 1;

    //         NewCLass obj3 = new NewCLass();
    //         obj3 = obj1 + obj2;

    //         Console.WriteLine(obj3.str);
    //         Console.WriteLine(obj3.num);
    //     }
    //}

    //Method Hiding -------------------------------------------------------------------
    //class Base
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("i am base class");
    //    }
    //}
    //class Child : Base
    //{
    //    public new void show()
    //    {
    //        base.show();
    //        Console.WriteLine("i am child class ");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Base b = new Child();
    //        b.show();
    //        //((Base)c).show();
    //        //c.show();
    //    }
    //}


    //Method Overriding ------------------------------------------------------------
    //class Parent
    //{
    //    public virtual void show()
    //    {
    //        Console.WriteLine("Parent class");
    //    }
    //}
    //class Child : Parent
    //{
    //    public override void show()
    //    {
    //        //base.show();
    //        Console.WriteLine("Child class");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Parent parent = new Child();
    //        parent.show();
    //    }
    //}

    //Sealed Class ---------------------------------
    //sealed class A
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("A");
    //    }
    //}
    //class B : A
    //{
    //    public void show2()
    //    {
    //        Console.WriteLine("B");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        B b = new B();
    //        b.show2();
    //    }
    //}


    //Sealed Method ------------------------------------------------
    //class Parent
    //{
    //    public virtual void show()
    //    {
    //        Console.WriteLine("Parent class");
    //    }
    //}
    //class Child : Parent
    //{
    //    public sealed override void show()
    //    {
    //        //base.show();
    //        Console.WriteLine("Child class");
    //    }
    //}
    //class Child2 : Child
    //{
    //    public override void show()
    //    {
    //        Console.WriteLine("Child 2");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Parent parent = new Child();
    //        parent.show();
    //    }
    //}


    //Indexers----------------------------------------
    //class Employee
    //{
    //    private int[] Age = new int[3];
    //    public int this[int index]
    //    {
    //        set {
    //            Age[index] = value;
    //        }
    //        get { 
    //            return Age[index];  
    //        }

    //    }
    // }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee emp = new Employee();
    //        emp[0] = 5;
    //        Console.WriteLine(emp[0]);
    //    }
    //}


    //Deligates -----------------------------------------------------------
    //public delegate void Calculation(int a, int b);
    //class Program
    //{
    //    public static void Addition(int a, int b)
    //    {
    //        int result = a + b;
    //        Console.WriteLine(result);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Calculation obj = new Calculation(Program.Addition);
    //        obj.Invoke(20, 30);

    //    }
    //}


    //Abstraction---------------------------------------------------------------------------
    //class Calculate
    //{
    //    public int a;
    //    public int b;
    //    public Calculate(int a, int b)
    //    {
    //        this.a = a;
    //        this.b = b;
    //    }
    //    void Add()
    //    {
    //        int c = a+b;
    //        Console.WriteLine("sum: {0}",c);
    //    }
    //    public void ShowData()
    //    {
    //        this.Add();
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Calculate c = new Calculate(4, 6);
    //        c.ShowData();
    //    }
    //}


    //Abstract class -----------------------------------------------------------------------------
    //abstract class Person
    //{
    //    public string name;
    //    public int age;
    //    public abstract void Show();
    //}
    //class Student : Person
    //{
    //    public int rollNo;
    //    public int fee;
    //    public override void Show()
    //    {
    //        Console.WriteLine(name);
    //        Console.WriteLine(age);
    //        Console.WriteLine(rollNo);
    //        Console.WriteLine(fee);
    //    }
    //}
    //class Teacher : Person
    //{
    //    public int salary;
    //    public override void Show()
    //    {
    //        Console.WriteLine(name);
    //        Console.WriteLine(age);
    //        Console.WriteLine(salary);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student s = new Student();
    //        s.name = "prince";
    //        s.age = 22;
    //        s.rollNo = 63;
    //        s.fee = 100000;
    //        s.Show();
    //        Teacher t = new Teacher();
    //        t.name = "Lalit";
    //        t.age = 21;
    //        t.salary = 1000000;
    //        t.Show();  
    //    }
    //}


    //practice++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("enter first no.");
    //        string a = Console.ReadLine();
    //        Console.WriteLine("enter second no.");
    //        string b = Console.ReadLine();
    //        int res;
    //        Console.WriteLine("{0} {1}",string.TryParse(a, out res ),a);
    //        if(int.TryParse(a, out res) || int.TryParse(b, out res))
    //        {
    //            int.Parse(a);
    //            int.Parse(b);
    //            Console.WriteLine(a);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Please enter valid input");
    //        }
    //    }
    //}

    //ppeppe
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int count = 0;
    //        int n = int.Parse(Console.ReadLine());
    //        for (int i = 2; i <= n / 2; i++){
    //            if (n % i == 0)
    //            {
    //                count++;
    //                Console.WriteLine("no. is not Prime");
    //                break;
    //            }
    //        }
    //        if (count == 0)
    //        {
    //            Console.WriteLine("no. is Prime");
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string str, rev = "";
    //        str = Console.ReadLine();
    //        int n = str.Length - 1;
    //        while (n >= 0)
    //        {
    //            rev = rev + str[n];
    //            n--;
    //        }
    //        Console.WriteLine(rev);

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {


    //        int a = 1, b = 2, c;
    //        Console.WriteLine("enter length of series");
    //        int n = int.Parse(Console.ReadLine());
    //        Console.WriteLine(a);
    //        Console.WriteLine(b);
    //        for(int i = 2; i<n; i++)
    //        {
    //            c = a + b;
    //            Console.WriteLine(c);
    //            a = b;
    //            b = c;
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int rev = 0, r, temp;
    //        Console.WriteLine("enter no to check");
    //        int n = int.Parse(Console.ReadLine());
    //        temp = n;
    //        while(n > 0)
    //        {
    //            r = n % 10;
    //            rev = rev * 10 + r;
    //            n = n / 10;
    //        }
    //        if(temp == rev)
    //        {
    //            Console.WriteLine("no. is pallindrome");
    //        }
    //        else
    //        {
    //            Console.WriteLine("no pallindrome");
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args) {
    //        int fact=1 ;
    //        Console.WriteLine("enter no.");
    //        int n = int.Parse(Console.ReadLine());
    //        for(int i = 1; i<=n; i++)
    //        {
    //            fact = fact * i;
    //        }
    //        Console.WriteLine(fact);
    //    } 
    //}

    //class exam
    //{
    //    static exam()
    //    {
    //        Console.WriteLine("static constructor");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        exam e = new exam(); 
    //        exam e2 = new exam();   
    //    }
    //}

    // Copy Constructor ---------------------------------------------------------


}
