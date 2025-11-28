using System.Reflection;
using System.Threading.Channels;

internal class Program
{

    //example for typeOf
    class Preson
    {
    public string name1 {  get; set; }
    public void sayHi1() => Console.WriteLine("hi");
    }

    private static void Main(string[] args)
    {
        //همه عمگرا


        //------- :?  (ternary)
        int age = 20;
        string resultTernary = (age >= 18) ? "adult" : "child";


        //------- ??  (null coalescing operator
        string name = null;
        string displayName = name ?? "Unknown";
        Console.WriteLine(displayName);//name doesn't change

        //------- =?? (null coalescing assigment operator
        string title = null;
        title ??= "Unknown";
        Console.WriteLine(title);//title changed(update)

        //------- =>  (lambda expression)|| (arrow operator) || (lambda operator)
        Func<int, int> squre = x=> x*x;
        Console.WriteLine(squre(5));//25
        //or
        int squre2(int a)
        {
            return a*a;
        }
        //example for  Func
        //func can 0-16 input and 1 output
        Func<int> getRandom = () => 42;
        Console.WriteLine("func : "+getRandom());
        //action
        //action can 0-16 input and 1 output  but without  output 
        Action greet = () =>
        {
            Console.WriteLine("Hi!");
        };

        //------- is   (Checking the variable type) 
        object obj = 123;
        if (obj is int)//just check
        {
            Console.WriteLine("obj is int");
        }
        else
        {
            Console.WriteLine("obj not int");
        }
        //example 2
        object obj2 = 123;
        if (obj is int num2) { Console.WriteLine("num2 : "+num2); }


        //-------- as (operator for cast)
        object obj3 = "hello";  
        string? str = obj3 as string;//success
        if (str != null)
        {
            Console.WriteLine(str);
        }

        /*
         Differences Between As and Is
         The is operator is used to check if the run-time type of an object is
         compatible with the given type or not, 
         whereas the as operator is used to perform conversion between
         compatible reference types or nullable types. The is operator is of Boolean type, 
         whereas the as operator is not.
         */



        //-------- sizeOf
        //(used to determine the size in bytes occupied by a data type or a variable in memory.)
        //for value type 
        Console.WriteLine(sizeof(int));
        unsafe
        {
            Console.WriteLine(sizeof(double));
        }//for double!!
        /*
         the unsafe context is your gateway 
        to working with pointers and direct memory manipulation,
        which is generally restricted for safety reasons.
         */
        //example for unsafe
        unsafe
        {
            int x = 10;
            int *ptr = &x;//point x
            Console.WriteLine(*ptr);//10
        }
        Console.WriteLine("unsafe test");

        //-------- typeOf  (type information)
        Type t1=typeof(int);
        Console.WriteLine(t1);
        Console.WriteLine("type of test");
        //example for typeOf
        Type personType = typeof(Preson);
        Console.WriteLine("properties : ");
        foreach (var prop in personType.GetProperties())
        {
            Console.Write(prop.Name);
        }
        Console.WriteLine();
        Console.WriteLine("method : ");
        foreach (var meth in personType.GetMethods())
        {
            Console.Write(meth.Name);
        }
        Console.WriteLine("typeof test");
        //example2
        string text1 = "hello";
        Console.Write(typeof(string));//compile
        Console.WriteLine(text1.GetType());//runtime
        object obj4 = "hello";
        Console.WriteLine(typeof(object));
        Console.WriteLine(obj4.GetType());
        Console.WriteLine("dif btw GetType  and  typeof ");

        //-------- checked/unchecked  
        /* 
         The checked and unchecked statements specify 
         the overflow-checking context for integral-type arithmetic
         operations and conversions. 
        */
        int maxVal=int.MaxValue;
        maxVal = maxVal + 1;
        Console.WriteLine(maxVal);//output: -2147483648
        try
        {
            int maxVal2 = int.MaxValue;
            int maxVal3 = checked( maxVal2 + 1);
            Console.WriteLine(maxVal3);
        }
        catch (OverflowException  ex)
        {
            Console.WriteLine("error : " + ex);
        }

    }
}