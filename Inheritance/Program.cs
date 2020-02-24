using System;
using System.Collections;

namespace FundamentalRules
{
    #region Inheritance Rules
    //class Customere
    //{
    //    public int CustomerId { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public void Details()
    //    {
    //        Console.WriteLine("CustomerId" + CustomerId);
    //    }
    //}

    //class BankCustomer : Customer
    //{
    //    public int AccountNumber { get; set; }
    //    public double Balance { get; set; }
    //    public void BankCustomerDetails()
    //    {
    //        Console.WriteLine("\nCustomerId" + CustomerId);
    //        Console.WriteLine("Balance" + Balance);
    //    }
    //}

    //class LoanCustomer : BankCustomer
    //{
    //    public int MyProperty { get; set; }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Customer C = new Customer()
    //        {
    //            CustomerId = 1,
    //            Name = "Michal",
    //            Email = "michal@o2.pl"
    //        };

    //        BankCustomer B = new BankCustomer()
    //        {
    //            CustomerId = 2,
    //            Name = "Monika",
    //            Email = "monika@p2.pl", 
    //            AccountNumber = 432432,
    //            Balance = 65700
    //        };

    //        C.Details();

    //        B.Details();
    //        B.BankCustomerDetails();

    //        LoanCustomer LC = new LoanCustomer()
    //        {
    //            CustomerId = 3,
    //            Name = "Ania"
    //            //etc.
    //        };

    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region Base Inheritance
    //class Customer
    //{
    //    //public int CustomerId { get; set; }
    //    //private string Name { get; set; }
    //    //protected string Email { get; set; }
    //    protected int CustomerId;
    //    protected string Name;
    //    protected string Email;

    //    public Customer(int CustomerId, string Name, string Email)
    //    {
    //        Console.WriteLine("Customer Constructor");
    //        this.CustomerId = CustomerId;
    //        this.Name = Name;
    //        this.Email = Email;
    //    }

    //    //public void Details()
    //    //{
    //    //    Console.WriteLine("CustomerId" + CustomerId);
    //    //}
    //}

    //class BankCustomer : Customer
    //{
    //    protected int AccountNumber { get; set; }
    //    protected double Balance { get; set; }

    //    public BankCustomer(int CustomerId, string Name, string Email, int AccountNumber, double Balance) 
    //        : base(CustomerId, Name, Email)
    //    {
    //        Console.WriteLine("Bank Customer Constructor");
    //        this.CustomerId = CustomerId;
    //        this.Name = Name;
    //        this.Email = Email;
    //        this.AccountNumber = AccountNumber;
    //        this.Balance = Balance;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Customer C = new Customer();
    //        //BankCustomer BC = new BankCustomer();

    //        var BC = new BankCustomer(123, "Michal", "xxxx", 7687, 5000);

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Inheritance, Constructor, Chaining
    //class A
    //{
    //    public A()
    //    {
    //        Console.WriteLine("Default constructor A");
    //    }

    //    public A(int a)
    //    {
    //        Console.WriteLine("Constructor A with param");
    //    }
    //}

    //class B : A
    //{
    //    public B() : base(1)
    //    {
    //        Console.WriteLine("Default constructor B");
    //    }

    //    public B(int x)
    //    {
    //        Console.WriteLine("Constructor B with param");
    //    }
    //}

    //class C : B
    //{
    //    public C():base(67)
    //    {
    //        Console.WriteLine("Default constructor C");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //B b = new B();
    //        C c = new C(); 

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Overriding
    //class Customer
    //{
    //    public int CustomerId { get; set; }
    //    public string Name { get; set; }

    //    //public void GetDetails()
    //    public virtual void GetDetails()
    //    {
    //        Console.WriteLine("CustomerId: " + CustomerId);
    //        Console.WriteLine("Name: " + Name);
    //    }
    //}

    //class BankCustomer : Customer
    //{
    //    public double Bal { get; set; }

    //    //public void GetBankDetails()
    //    public override void GetDetails()
    //    {
    //        Console.WriteLine("CustomerId: " + CustomerId);
    //        Console.WriteLine("Name: " + Name);
    //        Console.WriteLine("Bal: " + Bal);
    //    }

    //    public void Deposite(double amt)
    //    {
    //        Bal += amt;
    //        this.GetDetails();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BankCustomer BC = new BankCustomer() { CustomerId = 1, Name = "Michas", Bal = 63000 };
    //        //BC.GetBankDetails();
    //        BC.GetDetails();
    //        BC.Deposite(5000);

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Sealed class
    //class A
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("Show A");
    //    }
    //}

    //class B : A
    //{
    //    public override sealed void Show()
    //    {
    //        Console.WriteLine("Show B");
    //    }
    //}

    //sealed class C : B
    //{
    //    //public override void Show()
    //    //{
    //    //    Console.WriteLine("Show C");
    //    //}
    //}

    //class D 
    //{

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //C c = new C();
    //        //c.Show();

    //        //D d = new D();
    //        //d.Show();


    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Abstract
    //abstract class A
    //{
    //    public void Show()
    //    {
    //        Console.WriteLine("This is A");
    //    }

    //    public abstract void Display();
    //}

    //class B : A
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("This is B");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A a;// = new A(); //tworzenie referencji do klasy
    //        a = new B();

    //        a.Show();
    //        a.Display();

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Abstrac, Dynamic polymorphis

    //abstract class Employee
    //{
    //    public int EmpId { get; set; }
    //    public string Name { get; set; }
    //    public int SalPerHour { get; set; }
    //    public virtual void Details()
    //    {
    //        Console.WriteLine("EmpI: " + EmpId);
    //        Console.WriteLine("Name: " + Name);
    //        Console.WriteLine("SalPerHour: " + SalPerHour);
    //    }
    //    public abstract void CalculateSalary(int NumberOfWorkingHours);
    //    public abstract void CalculateLeaves();
    //}

    //class SoftwareEngineer : Employee
    //{
    //    public string Technology { get; set; }
    //    public override void Details()
    //    {
    //        base.Details();
    //        Console.WriteLine("Technology: " + Technology);
    //    }
    //    public override void CalculateSalary(int NumberOfWorkingHours)
    //    {
    //        double BS = (SalPerHour * NumberOfWorkingHours);
    //        double HRA = BS * 15 / 100;
    //        double GS = BS + HRA;
    //        Console.WriteLine("Gross Salary Of Software Engineer is :" + GS);
    //    }
    //    public override void CalculateLeaves()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class TeamLeader : Employee
    //{
    //    public int Size { get; set; }
    //    public override void Details()
    //    {
    //        base.Details();
    //        Console.WriteLine("Size: " + Size);
    //    }
    //    public override void CalculateSalary(int NumberOfWorkingHours)
    //    {
    //        double BS = (SalPerHour * NumberOfWorkingHours);
    //        double HRA = BS * 30.5 / 100;
    //        double GS = BS + HRA;
    //        Console.WriteLine("Gross Salary Of Team Leader is :" + GS);
    //    }
    //    public override void CalculateLeaves()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee E;
    //        Console.WriteLine("1. SE, 2. TL, 3. HR");
    //        int type = int.Parse(Console.ReadLine());
    //        do
    //        {
    //            switch (type)
    //            {
    //                case 1:
    //                    E = new SoftwareEngineer() { EmpId = 100, Name = "Ania", SalPerHour = 45, Technology = ".Net Core" };
    //                    break;
    //                case 2:
    //                    E = new TeamLeader() { EmpId = 200, Name = "Jack", SalPerHour = 46, Size = 12 };
    //                    break;
    //                default:
    //                    E = new SoftwareEngineer() { EmpId = 100, Name = "Peter", SalPerHour = 45, Technology = ".Net Core" };
    //                    break;
    //            }
    //            E.Details();
    //            E.CalculateSalary(40);
    //        } while (Console.ReadLine() != "n");

    //    }
    //}
    #endregion
    #region Interfaces - Multiple Int.

    //interface IDeleteOperation
    //{
    //    void DeleteAll();
    //}
    //interface IOperations
    //{
    //    void GetAll();
    //    void GetByID();
    //    void Create();
    //    void Update();
    //    void Delete();
    //}

    //class Employees : IOperations, IDeleteOperation
    //{
    //    public void Create()
    //    {
    //        Console.WriteLine("Create Employee");
    //    }

    //    public void Delete()
    //    {
    //        Console.WriteLine("Delete Employee");
    //    }

    //    public void GetAll()
    //    {
    //        Console.WriteLine("Get All Employee");
    //    }

    //    public void GetByID()
    //    {
    //        Console.WriteLine("Get Employee By Id");
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("Update Employee");
    //    }

    //    public void DeleteAll()
    //    {
    //        Console.WriteLine("Delete Operations");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IDeleteOperation deleteOperation = new Employees();
    //        deleteOperation.DeleteAll();

    //        IOperations operations;
    //        operations = new Employees();

    //        operations.Create();

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Partial Classes
    ////another file
    //partial class A
    //{
    //    public void Show()
    //    {
    //        Console.WriteLine("Show");
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A a = new A();
    //        a.Show();
    //        a.Display();

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Collection Classes
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Stack S = new Stack(3);
    //        S.Push(4);
    //        S.Push(32);
    //        S.Push(14);

    //        //while (S.Count != 0)
    //        //{
    //        //    Console.WriteLine(S.Pop().ToString());
    //        //}

    //        int sum = 0;
    //        while (S.Count != 0)
    //        {
    //            sum = sum + int.Parse(S.Pop().ToString());
    //        }
    //        Console.WriteLine(sum);

    //        Queue Q = new Queue();
    //        Q.Enqueue("Michal");
    //        Q.Enqueue("Mateusz");
    //        Q.Enqueue("Joanna");

    //        //while (Q.Count != 0)
    //        //{
    //        //    Console.WriteLine(Q.Dequeue());
    //        //}

    //        string name = null;

    //        while(Q.Count != 0) 
    //        {
    //            name = name + " " + Q.Dequeue();
    //        }
    //        Console.WriteLine(name);

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Exception and Assignment
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            int[] A = new int[2];
    //            A[0] = 10;
    //            A[1] = 15;
    //            A[2] = 20;
    //        }
    //        catch (Exception E)
    //        {
    //            Console.WriteLine(E.Message);
    //        }

    //        //catch (FormatException FE)
    //        //{
    //        //    Console.WriteLine(FE.Message);
    //        //}
    //        //catch(DivideByZeroException DE)
    //        //{
    //        //    Console.WriteLine(DE.Message);
    //        //}

    //        //for (int i = 0; i < A.Length; i++)
    //        //{
    //        //    Console.WriteLine(A[i]);
    //        //}
    //        finally
    //        {
    //            Console.ReadLine();
    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] argc)
        {
            try
            {
                var result = Calculate.Divide(15, 0);
                Console.WriteLine("Result is " + result);
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadLine();
        }
    }
    #endregion
}