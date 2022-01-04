import java.util.Comparator;

public class CustomComparator implements Comparator<Employee> {
    @Override
    public int compare(Employee o1, Employee o2) {
        return o1.signedDate.compareTo(o2.signedDate);
    }
}
