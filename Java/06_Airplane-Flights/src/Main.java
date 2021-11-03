import java.util.Date;

public class Main {
    public static void main(String[] args) {

        Airplane airplane = new Airplane(1, 2001, 80, "Test");
        Date date = new Date();

        Flight flight = new Flight("fromTest", "toTest", 10, 5, airplane, date, 10, "test");

        System.out.println(flight);
    }
}
