abstract class Computer{
    protected int ramCapacity;
    protected int romCapacity;
    protected int HDDcapacity;
    
    public Computer(int ramCapacity, int romCapacity, int HDDcapacity) {
        this.ramCapacity = ramCapacity;
        this.romCapacity = romCapacity;
        this.HDDcapacity = HDDcapacity;
    }
    //Getter and Setters
    public int getRamCapacity() { return ramCapacity; }

    public void setRamCapacity(int ramCapacity) { this.ramCapacity = ramCapacity; }

    public int getRomCapacity() { return romCapacity; }

    public void setRomCapacity(int romCapacity) { this.romCapacity = romCapacity; }

    public int getHDDcapacity() { return HDDcapacity; }

    public void setHDDcapacity(int hDDcapacity) { HDDcapacity = hDDcapacity; }
}

class Desktop extends Computer{
    private boolean isPowerSupplyOn;

    public Desktop(int ramCapacity, int romCapacity, int hDDcapacity, boolean isPowerSupplyOn) {
        super(ramCapacity, romCapacity, hDDcapacity);
        this.isPowerSupplyOn = isPowerSupplyOn;
    }

    //Getter and Setters
    public boolean isPowerSupplyOn() { return isPowerSupplyOn; }

    public void setPowerSupplyOn(boolean isPowerSupplyOn) { this.isPowerSupplyOn = isPowerSupplyOn; }
}

class Laptop extends Computer{
    private double chargedPercentage;

    public Laptop(int ramCapacity, int romCapacity, int hDDcapacity, double chargedPercentage) {
        super(ramCapacity, romCapacity, hDDcapacity);
        this.chargedPercentage = chargedPercentage;
    }

    //Getter and Setters
    public double getChargedPercentage() { return chargedPercentage; }

    public void setChargedPercentage(double chargedPercentage) { this.chargedPercentage = chargedPercentage; }
}

public class HierarchicalInheritance{
    public static void main(String[] args) {
        Desktop desktop=new Desktop(2048, 4096, 8192, true);
        Laptop laptop=new Laptop(2560, 4608, 10240,80);

        //Desktop class usage
        System.out.println("\n*Desktop info*");
        System.out.println("RAM: "+desktop.getRamCapacity()+"Kb");
        System.out.println("ROM: "+desktop.getRomCapacity()+"Kb");
        System.out.println("HDD: "+desktop.getHDDcapacity()+"Kb");
        System.out.println("Power : "+(desktop.isPowerSupplyOn()?"On Power Supply":"On UPS"));

        //Laptop class usage
        System.out.println("\n*Laptop info*");
        System.out.println("RAM: "+laptop.getRamCapacity()+"Kb");
        System.out.println("ROM: "+laptop.getRomCapacity()+"Kb");
        System.out.println("HDD: "+laptop.getHDDcapacity()+"Kb");
        System.out.println("Charged: "+laptop.getChargedPercentage()+"%");

    }
}

   