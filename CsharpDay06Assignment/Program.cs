using System;

namespace CsharpDay06Assignment
{
    #region Problem 1

    //public struct Point1
    //{
    //    public int X;
    //    public int Y;

    //    public Point1(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"({X}, {Y})";
    //    }
    //}

    #endregion

    #region Problem 2

    //public class TypeA
    //{
    //    private int F = 10;
    //    internal int G = 20;
    //    public int H = 30;

    //    public void ShowF()
    //    {
    //        Console.WriteLine(F);
    //    }
    //}

    #endregion

    #region Problem 3

    //public struct Employee
    //{
    //    private int empId;
    //    private string name;
    //    private double salary;

    //    public Employee(int id, string name, double salary)
    //    {
    //        empId = id;
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public string GetName()
    //    {
    //        return name;
    //    }

    //    public void SetName(string newName)
    //    {
    //        if (!string.IsNullOrWhiteSpace(newName))
    //            name = newName;
    //    }

    //    public int EmpId
    //    {
    //        get { return empId; }
    //    }

    //    public double Salary
    //    {
    //        get { return salary; }
    //        set
    //        {
    //            if (value > 0)
    //                salary = value;
    //        }
    //    }

    //    public override string ToString()
    //    {
    //        return $"ID: {empId}, Name: {name}, Salary: {salary}";
    //    }
    //}

    #endregion

    #region Problem 4

    //public struct Point2
    //{
    //    public int X;
    //    public int Y;

    //    public Point2(int x)
    //    {
    //        X = x;
    //        Y = 0;
    //    }

    //    public Point2(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"({X}, {Y})";
    //    }
    //}

    #endregion

    #region Problem 5

    //public struct Point3
    //{
    //    public int X;
    //    public int Y;

    //    public Point3(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Point: X = {X}, Y = {Y}";
    //    }
    //}

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //Point1 p1 = new Point1();
            //Point1 p2 = new Point1(5, 10);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            //TypeA obj = new TypeA();
            //Console.WriteLine(obj.G);
            //Console.WriteLine(obj.H);
            //obj.ShowF();

            //Employee emp = new Employee(1, "Mohamed", 5000);
            //Console.WriteLine(emp);
            //emp.SetName("Ali");
            //emp.Salary = 8000;
            //Console.WriteLine(emp);

            //Point2 p3 = new Point2(7);
            //Point2 p4 = new Point2(7, 14);
            //Console.WriteLine(p3);
            //Console.WriteLine(p4);

            //Point3 p5 = new Point3(1, 2);
            //Point3 p6 = new Point3(3, 4);
            //Console.WriteLine(p5);
            //Console.WriteLine(p6);
        }
    }
}
