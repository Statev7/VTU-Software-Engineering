public class WordChanger {

    public String replace(String text, String wordToReplace, String newWord){

        //String result = text.replace(wordToChange, newWord);
        String[] textAsArray = text.split(" ");
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < textAsArray.length; i++) {

            if (textAsArray[i].equals(wordToReplace)){
                textAsArray[i] = newWord;
            }
        }

        for (int i = 0; i < textAsArray.length; i++) {

            result.append(textAsArray[i] + " ");
        }

        return result.toString();
    }
}
