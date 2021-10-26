public abstract class AbstractVehicle implements VehichleInterface{

    private String name;
    private String color;
    private int wheels;

    public AbstractVehicle(String name, String color, int wheels){
        this.name = name;
        this.color = color;
        this.wheels = wheels;
    }

    public String getName() {
        return name;
    }

    public String getColor() {
        return color;
    }

    public int getWheels() {
        return wheels;
    }

}
