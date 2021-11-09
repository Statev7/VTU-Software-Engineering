public class Main {
    public static void main(String[] args) {

        WordCounter wordCounter = new WordCounter();

        int count = wordCounter.count("Test abv test asd test dsa test", "test");
        System.out.println(count);
        //WordChanger wordChanger = new WordChanger();
        //String result = wordChanger.replace("Test abv test asd test dsa test", "test", "newWord");

        //System.out.println(result);
    }
}
