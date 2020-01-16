using System;
					
public class Program
{
	public static void Main()
	{
		Calculator calc=new Calculator();
		while(true){
			Console.WriteLine("\n\nEnter operation no. :\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Modulus\n6.Exit ");
			int op=Convert.ToInt32(Console.ReadLine());
			if(op==6)	break;
			Console.WriteLine("Enter first number :");
			double x=Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter second number :");
			double y=Convert.ToDouble(Console.ReadLine());
			double res=0;
			switch(op){
				case 1:
					res=calc.Add(x,y);
					break;
				case 2:
					res=calc.Subtract(x,y);
					break;
				case 3:
					res=calc.Multiply(x,y);
					break;
				case 4:
					res=calc.Divide(x,y);
					break;
				case 5:
					res=calc.Modulus(x,y);
					break;
			}
			Console.WriteLine("Result :"+res);
		}
	}
}

class Calculator{
	public double Add(double a,double b){ return a+b; }
	public double Subtract(double a,double b){ return a-b; }
	public double Multiply(double a,double b){ return a*b; }
	public double Divide(double a, double b){ return a/b; }
	public double Modulus(double a,double b){ return a%b; }
}