abstract class Car{
	protected String color;
	protected String brand;
	protected String model;

	public abstract void shiftGear();
	public abstract void applyBrakes();
}

class CarType1 extends Car{
	public CarType1(String color,String brand,String model){
		this.color=color;
		this.brand=brand;
		this.model=model;
	}

	public void shiftGear(){
		System.out.println("Auto gear shifting");
	}
	public void applyBrakes(){
		System.out.println("Applying disc brakes");
	}	
}

class CarType2 extends Car{
	public CarType2(String color,String brand,String model){
		this.color=color;
		this.brand=brand;
		this.model=model;
	}

	public void shiftGear(){
		System.out.println("Manual gear shifting");
	}
	public void applyBrakes(){
		System.out.println("Applying drum brakes");
	}	
}

public class Abstraction{

	public static void main(String[] arg){
		Car car1=new CarType1("Black","Audi","A3");
		Car car2=new CarType2("White","Honda","Civic");
		
		System.out.println("\n*Car1*");
		car1.shiftGear();
		car1.applyBrakes();

		System.out.println("\n*Car2*");
		car2.shiftGear();
		car2.applyBrakes();
	}
}