public class Group {

    private int course;
    private String spec;
    private Student[] students;
    private int numStudents;

    public static final int MAX_NUMBER_OF_STUDENTS = 40;

    public Group(String spec, int course){
        this.spec = spec;
        this.course = course;
        this.students = new Student[MAX_NUMBER_OF_STUDENTS];
        this.numStudents = 0;
    }

    public void addStudent(Student student){
        this.students[numStudents++] = student;
    }

    public double average(){

        double sum = 0;
        for (int index = 0; index < numStudents; index++) {
            sum += this.students[numStudents].average();
        }

        double result = sum / numStudents;
        return  result;
    }

    public int getCourse() {
        return course;
    }

    public void setCourse(int course) {
        this.course = course;
    }

    public String getSpec() {
        return spec;
    }

    public void setSpec(String spec) {
        this.spec = spec;
    }

    @Override
    public String toString() {

        String studentsInfo = "";
        for (int index = 0; index < this.numStudents; index++) {
            studentsInfo += this.students[index].toString() + "\n";
        }

        return "Spec:" + spec + "Course:" + " " + course + "\n" + studentsInfo;
    }
}
