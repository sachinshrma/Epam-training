class Singleton{
    private static Singleton obj;
    //   private constructor is accessible in its own class where defined. 
    //   A class with private constructor cannot be inherited by other classes
    private Singleton(){}
    public static Singleton getInstance(){
        if(obj==null){
            obj=new Singleton();
        }
        return obj;
    }
    public void foo(){
        System.out.println("Singleton class method");
    }
}

public class PrivateConstructor{
    public static void main(String[] args) {
       //   private constructor restricts direct object creation
       //   Singleton obj =new Singleton();   Error!!
       Singleton obj=Singleton.getInstance();
       obj.foo();
    }
}