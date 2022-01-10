import java.util.Comparator;

public class SmartPhone implements Product{

    private String brand;
    private String model;
    private Integer year;
    private String color;
    private Double price;

    public SmartPhone(String brand, String model, Integer year, String color, double price){
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.color = color;
        this.price = price;
    }

    public void setPrice(Double price) {
        this.price = price;
    }

    public String getBrand() {
        return brand;
    }

    public String getModel() {
        return model;
    }

    public Integer getYear() {
        return year;
    }

    public String getColor() {
        return color;
    }

    @Override
    public String getName() {
        return this.model + this.brand;
    }

    @Override
    public Double getPrice(double price) {
        return this.price;
    }


    @Override
    public int compareTo(Object o) {

        SmartPhone other = (SmartPhone)o;
        return this.price.compareTo(other.price);
    }

    @Override
    public String toString() {

        String result = "Name:" + this.getName() + " "
                + "Brand:" + this.brand + " "
                + "Model:" + this.model + " "
                + "Year:" + this.year + " "
                + "Color:" + this.color + " "
                + "Price:" + this.price;

        return result;
    }
}
