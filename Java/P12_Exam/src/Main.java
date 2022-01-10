import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {

        List<Product> products =  new ArrayList<Product>();

        SmartPhone smartPhone = new SmartPhone("Brand1", "Model1", 2010, "red", 250);
        SmartPhone smartPhone1 = new SmartPhone("Brand2", "Model2", 2015, "red", 150);
        SmartPhone smartPhone2 = new SmartPhone("Brand3", "Model3", 2020, "red", 550);

        products.add(smartPhone);
        products.add(smartPhone1);
        products.add(smartPhone2);

        Collections.sort(products);
        printProducts(products);

        SmartPhone theMostExpensivePhone = (SmartPhone)products.get(products.size() - 1);
        printToFile(theMostExpensivePhone);
    }

    private static void printProducts(List<Product> products) {
        for (int index = 0; index < products.size(); index++) {
            System.out.println(products.get(index));
        }
    }

    private static void printToFile(SmartPhone theMostExpensivePhone) throws IOException {
        System.out.println("Enter a file name:");
        Scanner scanner = new Scanner(System.in);
        String fileName = scanner.nextLine();
        FileWriter writer = new FileWriter(fileName);

        String fileResult = "Model:" + " " + theMostExpensivePhone.getModel() + " " + "Year:" + " " + theMostExpensivePhone.getYear();
        writer.write(fileResult);
        writer.close();
    }
}
