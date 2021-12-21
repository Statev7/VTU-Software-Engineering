import java.util.List;

public interface Sensor {

    Float measure();
    String getName();
    List<Float> getValues();
}
