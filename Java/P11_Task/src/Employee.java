import java.time.LocalDate;

public class Employee extends Person {

    int id;
    LocalDate signedDate;
    double salary;
    int vacation;

    public Employee(String name, int age, int id, LocalDate signedDate, double salary, int vacation) throws Exception {
        super(name, age);
        this.setId(id);
        this.signedDate = signedDate;
        this.setSalary(salary);
        this.vacation = vacation;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) throws Exception {
        if (id < 0){
            throw new Exception("Invalid id");
        }
        this.id = id;
    }

    public LocalDate getSignedDate() {
        return signedDate;
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) throws Exception {
        if (salary < 650){
            throw new Exception("Invalid salary");
        }

        this.salary = salary;
    }

    public int getVacation() {
        return vacation;
    }

    public boolean goOnVacation(int days){

        boolean result = false;

        if (this.vacation >= days){

            this.vacation -= days;
            result = true;
        }

        return result;
    }


    @Override
    public String toString() {
        String result = super.toString() +
                "Id:" + this.id + " " +
                "Date:" + this.signedDate + " " +
                "Salary:" + this.salary + " " +
                "Vacation:" + this.vacation;

        return  result;
    }
}
