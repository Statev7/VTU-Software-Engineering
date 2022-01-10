import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.List;

public class MeteoStation {

    List<Sensor> sensors;

    public  MeteoStation(){
        this.sensors = new ArrayList<>();
    }

    public void addSensor(Sensor sensor){
        this.sensors.add(sensor);
    }

    public void measureValues(){
        for (Sensor s : sensors)
        {
            s.measure();
        }
    }

    public float getMaxValueByName(String name){

        Float result = 0.0f;

        for (int index = 0; index < sensors.size(); index++) {

            if (sensors.get(index).getName().equalsIgnoreCase(name)){

                result = Collections.max(sensors.get(index).getValues());
                break;
            }
        }

        return  result;
    }

    public void sortValuesOfSensor(String name){

        for (int index = 0; index < sensors.size(); index++) {

            if (sensors.get(index).getName().equalsIgnoreCase(name)){

                Sensor sensor = sensors.get(index);
                Collections.sort(sensor.getValues(), Collections.reverseOrder());
                break;
            }
        }
    }

    public void  printToFile(String fileName)throws IOException {

        FileWriter writer = new FileWriter(fileName);

        for (int index = 0; index < sensors.size(); index++) {
            String senserName = this.sensors.get(index).getName();

            writer.write(senserName + " " + this.sensors.get(index).getValues() + "\r");
        }

        writer.close();
    }
}
