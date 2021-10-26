public class Truck extends AbstractVehicle {

    final String TRUCK_DRIVE_MESSAGE = "Driving a truck";

    private double load;

    public Truck(String name, String color, int wheels, double load) {
        super(name, color, wheels);
        this.load = load;
    }

    public double getLoad() { return load;}

    @Override
    public String drive() {
        return TRUCK_DRIVE_MESSAGE;
    }
}
