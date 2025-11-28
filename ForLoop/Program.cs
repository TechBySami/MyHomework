internal class Program
{
    //add if  شرطای سخت
    static void ForLoop(int i)//for
    {
        for (i = 0; i > 0; i++)
        {
            Console.Write(i + "/");
        }
        Console.WriteLine();
        Console.WriteLine("___For___");
    }
    static void ForeachLoop(int i)//foreach and array
    {
        int[] number = new int[i];
        number[0] = 1;
        foreach (var item in number)
        {
            Console.Write(item + "-");
        }
        Console.WriteLine();
        Console.WriteLine("___foreach___");
    }
    static void WhileLoop(int i)//while
    {
        int b = i;
        while (b > 0)
        {
            Console.Write(b + "*");
            b--;
        }
        Console.WriteLine();
        Console.WriteLine("___while___");

    }
    static void DoWhileLoop(int i)// do while
    {
        int c = i;
        do
        {
            Console.Write(c + "@");
            c--;
        } while (c > 0);
        Console.WriteLine();
        Console.WriteLine("___do while___");

    }
    static void SwitchLoop(int i)//switch
    {
        int d = i;
        switch (d)
        {
            case 1:
                Console.Write("a#");
                break;
            case 2:
                Console.Write("B#");
                break;
            case 3:
                Console.Write("C#");
                break;
            case 4:
                Console.Write("D#");
                break;
            default:
                Console.WriteLine("nothing#");
                break;
        }
        Console.WriteLine();
        Console.WriteLine("___switch___");

    }
    private static void Main(string[] args)
    {

        ForLoop(10);
        ForeachLoop(4);
        WhileLoop(3);
        DoWhileLoop(40);
        SwitchLoop(10);

        Console.ReadKey();
    }
}