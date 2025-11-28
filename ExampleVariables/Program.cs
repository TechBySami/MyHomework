using System.Collections.Concurrent;

internal class Program
{
    static string StringMethodTest()
    {
        string result = " string type : ";
        int j = 0;
        for (int i = 0; i <= 10; i++)
        {
            //  Console.WriteLine(i);
            j += i;
            result += Convert.ToString(i);
        }
        return result + " | " + "sum = (" + j + ")";
    }
    private static void Main(string[] args)
    {
               //همه متغییرا رو باید بیارم

        //-----string and casting
        string resultValue = StringMethodTest();
        string[] reurnValueSplited = resultValue.Split('|') ;
        Console.WriteLine(reurnValueSplited[0]);
        Console.WriteLine(reurnValueSplited[1]);

        //dif btw valueType and refrenceType



        Console.ReadKey();
    }
   
}