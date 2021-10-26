public class Bus extends AbstractVehicle {

    private static final String BUS_DRIVE_MESSAGE = "Driving a bus";

    private int numPassengers;

    public Bus(String name, String color, int wheels, int numPassengers) {
        super(name, color, wheels);
        this.numPassengers = numPassengers;
    }

    public int getNumPassengers() {return numPassengers;}

    @Override
    public String drive() {
        return BUS_DRIVE_MESSAGE;
    }
}
