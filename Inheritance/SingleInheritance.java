class Person{
   protected String name;
   protected String gender;
   protected int age;

   public Person(String name,String gender,int age){
       this.name=name;
       this.gender=gender;
       this.age=age;
   }

   //getters and setters
   public String getName() {return name;}

   public void setName(String name) {this.name = name;}

   public String getGender() {return gender;}

   public void setGender(String gender) {this.gender = gender;}

   public int getAge() {return age;}

   public void setAge(int age) {this.age = age;}
}

class Student extends Person{
    int rollNo;
    int classNo;

    public Student(String name,String gender,int age,int rollNo,int classNo){
        super(name,gender,age);

        this.rollNo=rollNo;
        this.classNo=classNo;
    }

    //getters
    public int getRollNo(){ return rollNo; }

    public int getClassNo(){ return classNo; }
}

public class SingleInheritance{
    public static void main(String[] args) {
        Student student=new Student("Sachin", "Male", 21, 1234, 12);

        System.out.println(student.getName());
        System.out.println(student.getGender());
        System.out.println(student.getAge());
        System.out.println(student.getRollNo());
        System.out.println(student.getClassNo());
    }
}