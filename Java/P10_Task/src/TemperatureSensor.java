import java.util.Calendar;
import java.util.List;

public class TemperatureSensor extends BaseModel {

    public TemperatureSensor(String name) {
        super(name);
    }

    @Override
    public Float measure() {
        this.calendar = Calendar.getInstance();
        float result = this.calendar.get(Calendar.MINUTE);

        this.values.add(result);
        return result;
    }
}
