Imports System
Public Module Program
    Class Calculator
        public Function Add(ByVal a As Double,ByVal b As Double) As Double
			Return a+b
        End Function
        public Function Subtract(ByVal a As Double,ByVal b As Double) As Double
			Return a-b
        End Function
        public Function Multiply(ByVal a As Double,ByVal b As Double) As Double
			Return a*b
        End Function
        public Function Divide(ByVal a As Double,ByVal b As Double) As Double
			Return a/b
        End Function
        public Function Modulus(ByVal a As Double,ByVal b As Double) As Double
			Return a MOD b
        End Function
    End Class

    Sub Main()
		Dim calc as Calculator = new Calculator()
		Dim op as Integer
		Dim x,y,res as Double
		
		While True
            'Calcualtor menu
			Console.WriteLine("{0}Enter operation no. :{0}1.Add{0}2.Subtract{0}3.Multiply{0}4.Divide{0}5.Modulus{0}6.Exit ",Environment.NewLine)
			If (Integer.TryParse(Console.ReadLine(),op) = False) 
				Console.WriteLine("Enter Valid operator number")
				Continue While
			End If
			
			If (op = 6) Then
				Exit While
			End If
				
			Console.WriteLine("Enter first number :")
			While (Double.TryParse(Console.ReadLine(),x) = False) 
						Console.WriteLine("Enter Valid number")
			End While
				
			Console.WriteLine("Enter second number :")
			While (Double.TryParse(Console.ReadLine(),y) = False) 
					Console.WriteLine("Enter Valid number :")
			End While
				
			Select op
					Case 1
						res=calc.Add(x,y)
					Case 2
						res=calc.Subtract(x,y)
					Case 3
						res=calc.Multiply(x,y)
					Case 4
						res=calc.Divide(x,y)
					Case 5
						res=calc.Modulus(x,y)
					Case Else
						Console.WriteLine("Invalid operation")
					Continue While
			End Select
					
				Console.WriteLine("Result :"&res)
		End While
		
    End Sub
End Module
