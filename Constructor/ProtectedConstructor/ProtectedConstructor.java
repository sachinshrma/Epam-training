package ProtectedConstructorPackage;

public class ProtectedConstructor{
    //  protected constructor can be accessed from its own class, its subclasses, 
    //  all other classes belonging to the same package and subclasses of other packages.
    protected ProtectedConstructor(String arg){
        System.out.println("Protected constructor executed with argument: "+arg);
    }
}



