import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class Main {
    public static void main(String[] args) throws InterruptedException, IOException {

        Sensor sensor = null;
        MeteoStation meteoStation = new MeteoStation();

        BufferedReader bufferreader = new BufferedReader(new FileReader("input.txt"));
        String line = bufferreader.readLine();
        while (line != null){

            String sensorName = line;

            switch (line){
                case "temperature":
                    sensor = new TemperatureSensor(line);
                    break;
                case "atmospheric":
                    sensor = new AtmosphericPressureSensor(line);
                    break;
                case "humidity":
                    sensor = new HumiditySensor(line);
                    break;
            }

            meteoStation.addSensor(sensor);
            line = bufferreader.readLine();
        }
        bufferreader.close();

        //TemperatureSensor temperatureSensor = new TemperatureSensor("temperature");
        //AtmosphericPressureSensor atmosphericPressureSensor = new AtmosphericPressureSensor("atmospheric");
        //HumiditySensor humiditySensor = new HumiditySensor("humidity");

        meteoStation.measureValues();
        Thread.sleep(1000);
        meteoStation.measureValues();
        Thread.sleep(1000);
        meteoStation.measureValues();
        Thread.sleep(1000);

        Float result = meteoStation.getMaxValueByName("atmospheric");
        System.out.println(result);

        meteoStation.sortValuesOfSensor("atmospheric");
        meteoStation.printToFile("text.txt");
    }
}
