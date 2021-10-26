public class Car extends AbstractVehicle {

    private static final String CAR_DRIVE_MESSAGE = "Driving a car";

    private  int numPassengers;

    public Car(String name, String color, int wheels, int numPassengers) {
        super(name, color, wheels);
        this.numPassengers = numPassengers;
    }

    public int getNumPassengers() { return numPassengers;}

    @Override
    public String drive() {
        return  CAR_DRIVE_MESSAGE;
    }
}
