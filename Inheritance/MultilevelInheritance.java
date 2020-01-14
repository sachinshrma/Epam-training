class person
{
    protected String name;
    person(String name){  
        this.name=name;
    }
    public String getName(){ return name; }
}
class Employee extends person{  
    private int empid;
    Employee(String name,int id){
        super(name);
        this.empid=id;
    }
    public int getEmpid(){ return empid; }
}
class PartTimeEmployee extends Employee{
    private double hourlyRate;
    private int hoursWorked;
    PartTimeEmployee(String name,int id,double hr,int hw)
    {     
        super(name,id);
        hourlyRate = hr;
        hoursWorked = hw;
    }
    public double Getpay(){ return (hourlyRate * hoursWorked); }
}
class MultilevelInheritance{
    public static void main(String[] args){
        PartTimeEmployee partTimeEmployee=new PartTimeEmployee("Sachin", 560238, 500, 32);
        System.out.println("\nName: "+partTimeEmployee.getName());
        System.out.println("Empid: "+partTimeEmployee.getEmpid());
        System.out.println("Salary: Rs"+partTimeEmployee.Getpay());
        
    }
}