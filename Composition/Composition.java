class Job{
    private String employer;
    private String designation;
    private int salary;

    public Job(String employer, String designation, int salary) {
        this.employer = employer;
        this.designation = designation;
        this.salary = salary;
    }

    //getters and setters
    public String getEmployer() {return employer;}

    public void setEmployer(String employer) {this.employer = employer;}

    public String getDesignation() {return designation;}

    public void setDesignation(String designation) {this.designation = designation;}

    public int getSalary() {return salary;}

    public void setSalary(int salary) {this.salary = salary;}   
}

class Person{
    private String name;
    private String gender;
    private int age;

    
    private Job job;    //composition

    public Person(String name, String gender, int age, Job job) {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.job = job;
    }

    //getters and setters
    public String getName() {return name;}

    public void setName(String name) {this.name = name;}

    public String getGender() {return gender;}

    public void setGender(String gender) {this.gender = gender;}

    public int getAge() {return age;}

    public void setAge(int age) {this.age = age;}

    public Job getJob() {return job;}

    public void setJob(Job job) {this.job = job;}
   
 }
 
 
 public class Composition{
     public static void main(String[] args) {
         Job internJob=new Job("Epam", "Intern", 15000);
         Person person=new Person("Sachin", "Male", 21, internJob);

         //details display
         System.out.println("Name: "+person.getName());
         System.out.println("Gender: "+person.getGender());
         System.out.println("Age: "+person.getAge());
         System.out.println("Employer: "+person.getJob().getEmployer());
         System.out.println("Designation: "+person.getJob().getDesignation());
         System.out.println("salary: "+person.getJob().getSalary());
     }
 }