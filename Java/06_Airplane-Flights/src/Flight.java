import java.util.Date;
import java.util.Locale;

public class Flight {

    private String flightFrom;
    private String flightTo;
    private int numPassengers;
    private double price;
    private Date  date;
    private Airplane airplane;
    private double duration;
    private String status;

    public Flight(String flightFrom, String flightTo, int numPassengers, double price, Airplane airplane, Date date, double duration, String status){
        this.setFlightFrom(flightFrom);
        this.setFlightTo(flightTo);
        this.setNumPassengers(numPassengers);
        this.setPrice(price);
        this.setAirplane(airplane);
        this.setDate(date);
        this.setDuration(duration);
        this.setStatus(status);
    }

    public String getFlightFrom() {return flightFrom;}

    private void setFlightFrom(String flightFrom) {this.flightFrom = flightFrom;}

    public String getFlightTo() {return flightTo;}

    private void setFlightTo(String flightTo) {this.flightTo = flightTo;}

    public int getNumPassengers() {return numPassengers;}

    private void setNumPassengers(int numPassengers) {this.numPassengers = numPassengers;}

    public double getPrice() {return price;}

    private void setPrice(double price) {this.price = price;}

    public Airplane getAirplane() {return airplane;}

    private void setAirplane(Airplane airplane) {this.airplane = airplane;}

    public Date getDate() {return date;}

    private void setDate(Date date) {this.date = date;}

    public double getDuration() {return duration;}

    private void setDuration(double duration) {this.duration = duration;}

    public String getStatus() {return status;}

    private void setStatus(String status) {

        status = status.toLowerCase(Locale.ROOT);

        Boolean isInvalid = status != FlightStatus.inair.toString() && status !=  FlightStatus.delayed.toString() && status != FlightStatus.landed.toString();
        if (isInvalid){
            this.status = FlightStatus.landed.toString();
            return;
        }
        this.status = status;
    }

    @Override
    public String toString() {
        return "Flight: " + '\n' +
                "FlightFrom: " + flightFrom + '\n' +
                "FlightTo: " + flightTo + '\n' +
                "NumPassengers: " + numPassengers + '\n' +
                "Price: " + price + '\n' +
                "Date: " + date + '\n' +
                "Airplanes: " + airplane + '\n' +
                "Duration: " + duration + '\n' +
                "Status: " + status;
    }
}
