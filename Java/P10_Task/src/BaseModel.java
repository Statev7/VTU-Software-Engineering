import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

public abstract class BaseModel implements Sensor{

    String name;
    List<Float> values;
    Calendar calendar;

    public  BaseModel(String name){
        this.name = name;
        this.values = new ArrayList<>();
        this.calendar = Calendar.getInstance();
    }

    @Override
    public abstract Float measure();

    @Override
    public String getName(){
        return this.name;
    };

    @Override
    public  List<Float> getValues(){
      return this.values;
    };
}
