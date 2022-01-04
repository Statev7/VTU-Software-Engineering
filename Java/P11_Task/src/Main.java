import java.io.FileWriter;
import java.io.IOException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws Exception {

        LocalDate d1 = LocalDate.now();
        LocalDate d2 = d1.minusYears(2);
        LocalDate d3 = d1.minusYears(3).minusMonths(4);

        Employee employee1 = new Employee("Pesho", 20, 0, d1, 1000, 30);
        Employee employee2 = new Employee("Gosho", 25, 1, d2, 750, 10);
        Employee employee3 = new Employee("Ivan", 30, 2, d3, 800, 10);

        ArrayList<Employee> list = new ArrayList();
        list.add(employee1);
        list.add(employee2);
        list.add(employee3);

        for (int index = 0; index < list.size(); index++) {
            boolean result = list.get(index).goOnVacation(index);
            System.out.println(result);
        }

        employeeWithTheLeastLeave(list);

        //Sort
        sort(list);

        //printToFile
        Scanner scanner = new Scanner(System.in);
        System.out.println("Въведете име на файл: ");
        String fileName = scanner.nextLine();
        printToFile(fileName, list);

    }

    public static void printToFile(String fileName, ArrayList<Employee> list){
        try (FileWriter writer = new FileWriter(fileName)) {
            for (int index = 0; index < list.size(); index++) {
                writer.write(list.get(index).toString() + "\r");
            }
            writer.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void sort(ArrayList<Employee> list){
        Collections.sort(list, new CustomComparator());

        for (int i = 0; i < list.size(); i++) {
            System.out.println(list.get(i));
        }
    }

    public static void employeeWithTheLeastLeave(ArrayList<Employee> list){
        Employee employee4 = null;
        int min = Integer.MAX_VALUE;
        for (int i = 0; i < list.size(); i++) {

            if (min > list.get(i).vacation){
                min  = list.get(i).vacation;
                employee4 = list.get(i);
            }
        }

        System.out.println("Най-малко дни отпуск: " +  employee4);
    }
}
