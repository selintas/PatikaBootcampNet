using GenericMethodsV2;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

public class Program
{

    public static void Main(string[] args)
     {
        //int[] array = { 1, 2, 3 };

        //string[] array2 = { "A", "B", "C" };

        //PrintArray(array2);

        //DisplayClasstype(array);

        //Point p = new Point();
        //DisplayStructType(p);


        //Circle circle = new Circle();
        ////Shape circle = new Circle(); // shapeten türedği için böyle de yazılabılır.
        //DisplayShapeType(circle);

        //CreateInstance<Point>();

        //DisplayComparableType("deneme");

        //DisplayType(circle);

        ////class sonrası 
        //GenericClassV<int> genericClassV = new GenericClassV<int>(4);
         
        GenericStack<int> stack = new GenericStack<int>();

        Console.WriteLine(stack.IsEmpty());

        stack.Push(1);
        stack.Push(2); 
        stack.Push(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());

        GenericStack<string> strStack = new GenericStack<string>();

        strStack.Push("A");
        strStack.Push("B");
        strStack.Push("C");

        Console.WriteLine(strStack.Pop());
        Console.WriteLine(strStack.Peek());
        Console.WriteLine(strStack.Pop());

        Repository<Student> student = new Repository<Student>();
    }
    public abstract class Shape { } 
    public class Circle : Shape, IEntity { }
    public struct Point { }

    

    public static void PrintArray<T>(T[] array)
    {
        foreach (T item in array) { Console.WriteLine(item); }
    }

    public void GenericMethods<T>(T i)
    {
        Console.WriteLine(i);
    }

    public static void DisplayClasstype<T>(T item) where T : class {  } 
     
    public static void DisplayStructType<T>(T item) where T : struct { } 
     
    public static void DisplayShapeType<T>(T item) where T : Shape { }

    public static T CreateInstance<T>() where T : new()
    {
        return new T();

    }
    public static void DisplayComparableType<T>(T item) where T : IComparable<T> { }

    public static void DisplayType<T>(T item) where T : class, IEntity, new()
    {

    }
     
    public interface IEntity { }
}
       
