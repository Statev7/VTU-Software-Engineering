import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class Main {

    public static void main(String[] args) {

        FileWriter writer = null;
        try {
            writer = new FileWriter("text.txt");

            for (int i = 0; i < 10; i++) {
                String str = i + "s ";
                writer.write(str);
            }
            writer.close();
        }
        catch (IOException a){

        }

        FileReader reader = null;
        try {
            reader = new FileReader("text.txt");

            int date = reader.read();
            while (date != -1){

                System.out.print((char)date);
                date = reader.read();
            }


            reader.close();
        }
        catch (IOException a){

        }

    }

}
