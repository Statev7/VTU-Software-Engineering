public class Student extends Person {

    private String fn;
    private ListOfMarks marks;

    public  Student(String fn, String name){
        super(name);
        this.fn = fn;
        this.marks = new ListOfMarks();
    }

    public void passCourse(double mark){
        this.marks.addMark(mark);
    }

    public double average(){
        return  this.marks.average();
    }

    public String getFn() {
        return fn;
    }

    public void setFn(String fn) {
        this.fn = fn;
    }

    public ListOfMarks getMarks() {
        return marks;
    }

    public void setMarks(ListOfMarks marks) {
        this.marks = marks;
    }

    @Override
    public String toString() {
        return "Fn:" + fn + " " + this.marks.toString();
    }
}
