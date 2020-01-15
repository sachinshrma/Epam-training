package UtilPackage;
import ProtectedConstructorPackage.*;
class Subclass extends ProtectedConstructor{
    public Subclass(){
        //  Subclass of other package can access protected constructor 
        super("From util package"); //Protected constructor call
    }
}
public class UtilClass{
    public static void main(String[] args) {
        //  Error! Protected constructor can't be accessed from non-subclass of other package
        //  ProtectedConstructor obj=new ProtectedConstructor();


        Subclass obj=new Subclass();
        
    }
}