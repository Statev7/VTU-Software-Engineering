public class Main {
    public static void main(String[] args) {

        Cylinder cylinder = new Cylinder("cylinder", 5, 5);

        System.out.println(cylinder.area());

        VehichleInterface[] vehichleInterfaces = new VehichleInterface[3];

        Car car = new Car("Car", "Red", 4, 5);
        Bus bus = new Bus("Bus", "Black", 8, 12);
        Truck truck = new Truck("Truck", "White", 4, 3);

        vehichleInterfaces[0] = car;
        vehichleInterfaces[1] = bus;
        vehichleInterfaces[2] = truck;

        for (int index = 0; index < vehichleInterfaces.length; index++) {
            System.out.println(vehichleInterfaces[index].drive());
        }
    }
}
