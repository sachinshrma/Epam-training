class Employee{

	private String UID;
	private String name;
	private String designation;
	private int salary;

	//constructor
	public Employee(String UID,String name,String designation,int salary){
		this.UID=UID;
		this.name=name;
		this.designation=designation;
		this.salary=salary;
	}
	
	//getters
	public String getUID(){	return UID;}
	public String getName(){ return name;}
	public String getDesignation(){	return designation;}
	public int getSalary(){return salary;}
	
	//setters
	public void setUID(String UID){
		this.UID=UID;
	}	
	public void setName(String name){
		this.name=name;
	}
	public void setDesignation(String designation){
		this.designation=designation;
	}

	//uitility methods
	public void displayDetails(){
		System.out.println("UID:"+getUID());
		System.out.println("Name:"+getName());
		System.out.println("Designation:"+getDesignation());
		System.out.println("Salary:"+getSalary()+"\n");
		
	}
	public void incrementSalaryByPercentage(int incrementPercentage){
		salary+=(incrementPercentage*salary)/100;
	}
	public void promote(String designation,int incrementPercentage){
		setDesignation(designation);
		incrementSalaryByPercentage(incrementPercentage);		
	}	


}



public class Encapsulation{


	
	public static void main(String[] arg){
		
		Employee employee=new Employee("560238","Sachin Sharma","Intern",15000);
		employee.displayDetails();

		
		//Promotion
		System.out.println("**Promoting to Junior software engineer**\n");
		employee.promote("Junior Software Engineer",200);
		System.out.println("*Details after promotion*");
		employee.displayDetails();

		//Salary increment
		employee.incrementSalaryByPercentage(10);
		System.out.println("*Salary after 10% increment*");
		System.out.println(employee.getSalary()+"\n");

		
	}
}