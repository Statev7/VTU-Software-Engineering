import java.util.Scanner;

public class P02_PrintAsciiCode {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        char character = input.charAt(0);

        System.out.println((int) character);

    }
}
