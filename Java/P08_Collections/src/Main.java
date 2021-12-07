import java.util.*;

public class Main {
    public static void main(String[] args) {

        Integer[] array = new Integer[]{5, 1, 0, 5, 2, 1};

        List<Integer> firstList = new ArrayList<>();
        List<Integer> secondList = new ArrayList<>();
        Map<Integer, Integer> map = new HashMap<>();

        for (int index = 0; index < array.length; index++) {

            int count = 1;
            if (map.containsKey(array[index])){

                count = map.get(array[index]);
                count++;
            }

            map.put(array[index], count);
        }

        for (Map.Entry<Integer,Integer> entry : map.entrySet()){

            if (entry.getValue() > 1){
                secondList.add(entry.getKey());
            }
            else{
                firstList.add(entry.getKey());
            }
        }

        String firstListMessage = "Неповтарящи се елементи: ";
        String secondListMessage = "Повтарящи се елементи: ";

        PrintResult(firstListMessage, firstList);
        PrintResult(secondListMessage, secondList);
    }

    private static void PrintResult(String str, List<Integer> list){
        System.out.printf(str);
        for (Integer num:
                list) {
            System.out.printf(num + " ");
        }
        System.out.println();
    }
}
