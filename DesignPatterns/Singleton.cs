using System;

class Singleton{
    private static Singleton obj=new Singleton();
    //   private constructor is accessible in its own class where defined. 
    //   A class with private constructor cannot be inherited by other classes
    private Singleton(){}
    public static Singleton getInstance(){
        return obj;
    }
    public void foo(){
        Console.WriteLine("Singleton class method");
    }
}

public class Program{
    public static void Main() {
       //   Singleton obj =new Singleton();   Error!!
       Singleton obj=Singleton.getInstance();
       obj.foo();
    }
}