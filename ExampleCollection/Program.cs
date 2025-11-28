internal class Program
{

    static int[] CounterArray(int start,int end)
    {
        //int size = end - start + 1;
        int[] result = new int[end];

        for (int i = start; i < end; i++)
        {
           result[i] = i;
        }
        return result;
    }//array
    private static void Main(string[] args)
    {
        Console.WriteLine("Collection ...");
        CounterArray(0, 10);
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine();
        //------------Array[]---------------------
        Console.WriteLine("___This is Array___");
        int[]  a=new int[10];//fix  +  simple 
        a[0]=1;
        a[1]=2;
        a[2] = 4;
        for (int i = 0; i < a.Count(); i++)//count is method
        {
            Console.WriteLine("a [" + i + "] = " + a[i]);
        }
        Console.WriteLine();
        Console.WriteLine("index of 4 : "+ Array.IndexOf(a,4));
        Console.WriteLine("min number in array : " + a.Min());
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("___This is List___");
        //------------List<T>---------------------
        List<int> b=new List<int>();//dynamic  + flexible
        b.Add(1);
        b.Add(2);
        b.Add(3);
        b.Add(4);
        for (int j = 0; j < b.Count; j++)//count is property
        {
            Console.WriteLine
                ("b["+j+"] = "+ b[j]);
        }
        Console.WriteLine();
        Console.WriteLine("index of 2 : " + b.IndexOf(2));
        Console.WriteLine("max in List : " + a.Max());
        Console.WriteLine();
        Console.ReadKey();       
        //---------Dictionary< Tkey , Tvalue >------------    
        Console.WriteLine("___This is Dictionary___");
        Dictionary<int,string> d =new Dictionary<int,string>();
        d.Add(1, "sami");//save data with key
        d.Add(2, "fari");
        d.Add(3, "mohsen");
        //Console.WriteLine(d[1]);
        foreach (var item in d)
        {
            Console.WriteLine(item.Value);
        }
        Console.WriteLine();
        Console.ReadKey();

    }
}