public class Airplane {

    private int id;
    private int year;
    private int capacity;
    private String name;

    public Airplane(int id, int year, int capacity, String name){
        this.id = id;
        this.year = year;
        this.capacity = capacity;
        this.name = name;
    }

    public int getId() {return id;}

    private void setId(int id) {this.id = id;}

    public int getYear(){return year;}

    private void setYear(int year) {this.year = year;}

    public int getCapacity() {return capacity;}

    private void setCapacity(int capacity) {this.capacity = capacity;}

    public String getName() {return name;}

    private void setName(String name) {this.name = name;}

    @Override
    public String toString() {
        return '\n' + "id=" + id + ", year=" + year + ", capacity=" + capacity + ", name=" + name;
    }
}
