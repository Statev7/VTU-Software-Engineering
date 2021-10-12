import java.util.Arrays;
import java.util.Scanner;

public class P01_BasicTypes {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        String[] array = new String[4];

        for (int i = 0; i < array.length; i++) {

            String str = scan.nextLine();
            array[i] = str;
        }

        printArray(reverseArray(array));
        String[] newArr = reverseArrayWithoutAnotherArray(array);
        printArray(newArr);
    }

    private static void printArray(String[] array){

        System.out.println(Arrays.deepToString(array));
    }

    private static String[] reverseArray(String[] array){

        String[] newArr = new String[array.length];
        int index = 0;

        for (int i = array.length - 1; i >= 0; i--) {

            newArr[index] = array[i];
            index++;
        }

        return newArr;
    }

    private static String[] reverseArrayWithoutAnotherArray(String[] array){

        int lastElementIndex = array.length - 1;

        for (int i = 0; i < array.length / 2; i++) {

            String firstElement = array[i];
            String lastElement = array[lastElementIndex];

            array[i] = lastElement;
            array[lastElementIndex] = firstElement;

            lastElementIndex--;
        }

        return  array;
    }
}
