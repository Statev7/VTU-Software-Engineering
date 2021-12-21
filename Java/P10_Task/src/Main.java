import java.io.IOException;

public class Main {
    public static void main(String[] args) throws InterruptedException, IOException {

        TemperatureSensor temperatureSensor = new TemperatureSensor("temperature");
        AtmosphericPressureSensor atmosphericPressureSensor = new AtmosphericPressureSensor("atmospheric");
        HumiditySensor humiditySensor = new HumiditySensor("humidity");

        MeteoStation meteoStation = new MeteoStation();
        meteoStation.addSensor(temperatureSensor);
        meteoStation.addSensor(atmosphericPressureSensor);
        meteoStation.addSensor(humiditySensor);

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
