import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class WordCounter {

    public int count(String text, String word){

        Pattern pattern = Pattern.compile(word);
        Matcher matcher = pattern.matcher(text);

        int count = 0;
        while (matcher.find()){
            count++;
        }

        return count;
    }

}
