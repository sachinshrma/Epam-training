class Example{
    public void foo() {
        System.out.println("Example class method");
    }
}

public class DefaultConstructor{
    public static void main(String[] args) {
        Example obj=new Example();  //Default constructor executed during object creation
        obj.foo();
    }
}
