class PublicParameterisedConstructor{
    String field1;
    String field2;

    //public contructor with two parameters
    //public constructor can be accessible from anywhere.
    public PublicParameterisedConstructor(String field1,String field2){
        this.field1=field1;
        this.field2=field2;
    }

    public String getField1() {
        return field1;
    }

    public void setField1(String field1) {
        this.field1 = field1;
    }

    public String getField2() {
        return field2;
    }

    public void setField2(String field2) {
        this.field2 = field2;
    }
    
}

public class PublicConstructor{
    public static void main(String[] args) {
        //creating object passing two reqiured parameters
        PublicParameterisedConstructor obj=new PublicParameterisedConstructor("Sachin", "Sharma");
        System.out.print(obj.getField1());
        System.out.println(" "+obj.getField2());
    }
}