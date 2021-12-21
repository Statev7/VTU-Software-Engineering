import java.util.Calendar;
import java.util.List;

public class AtmosphericPressureSensor extends BaseModel {

    public AtmosphericPressureSensor(String name) {
        super(name);
    }

    @Override
    public Float measure() {
        this.calendar = Calendar.getInstance();
        float result = this.calendar.get(Calendar.SECOND) + this.calendar.get(Calendar.MILLISECOND);

        this.values.add(result);
        return  result;
    }

}
