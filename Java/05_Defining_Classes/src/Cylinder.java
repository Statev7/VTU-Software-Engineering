public class Cylinder extends Figure {

    private  double r;
    private  double h;

    public  Cylinder(String name, double r, double h){
        super(name);
        this.r = r;
        this.h = h;
    }

    @Override
    public double area() {
        double sum = 2 * Math.PI * this.r * (this.h + this.r);

        return sum;
    }
}
