public class P01_KmToMsConverter {
    public static void main(String[] args) {

        final double MULTIPLIER = 3.6;

        System.out.println("K/H..........M/S");

        for (int i = 20; i < 200; i+=10) {

            double sum = i / MULTIPLIER;

            String result = String.format("%3d..........%.2f", i, sum);
            System.out.println(result);
        }
    }
}
