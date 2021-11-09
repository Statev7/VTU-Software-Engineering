public class WordCounter {

    public int count(String text, String wordToCount){

        String[] textAsArray = text.split(" ");
        int count = 0;

        for (int i = 0; i < textAsArray.length; i++) {

            if (textAsArray[i].equals(wordToCount)){
                count++;
            }
        }

        return count;
    }

}
