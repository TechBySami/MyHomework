internal class Program
{
    private static void Main(string[] args)
    {
		//ExceptionHandling


		//--------try + catch + finally
		/*
		 
		try
		{
			//code maybe error
			int a = 10;
			int b = 0;
			int result1 = a / b;
			Console.WriteLine("try : " + result1);
		}
		catch (DivideByZeroException ex)  //handle
		{
			Console.WriteLine("catch : You cant DivideByZero");
			Console.WriteLine("Details ToString : " + ex.ToString());
			Console.WriteLine("Details Message : " + ex.Message);
			throw;
		}
		finally // always run
		{
			Console.WriteLine("You Handle it");
		}

		*/


		//--------- throw

		/*
		  
		void divideZero(int c , int d) 
		{
			if (d==0)
			{
				throw new ArgumentException("cant be Zero");//throw the error if correct
            }
            Console.WriteLine(c/d);

		}
		try { divideZero(10, 0); } catch(Exception ex) { Console.WriteLine("Error : "+ex.Message); }

		*/




		//---------diferent ------------

		//-------Error

		//int e = "Hello"; //Cannot implicitly convert type 'string' to 'int' //or syntax error


		//-------Bug
		/*
		  
		int add(int f, int g)
		{ 
		return f - g; 
		}//the result is not correct 

		*/

		//------Exception 

		/*
		int h = 10;
		int  i=0;
		int result3 = h / i; //Exception:DivideByZeroException
		*/

		//-------Crash 
		
		//when error not handle the program was stop


    }
}