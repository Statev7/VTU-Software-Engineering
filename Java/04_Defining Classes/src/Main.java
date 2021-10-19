public class Main {

    public static void main(String[] args) {

        Student student = new Student("321321", "Ivan");
        Student student1 = new Student("321351", "Gosho");

        student.passCourse(5);
        student.passCourse(6);
        student.passCourse(3);

        student1.passCourse(4);
        student1.passCourse(6);
        student1.passCourse(6);

        System.out.println(student.average());
        System.out.println(student1.average());

        Group group = new Group("Test", 2);

        group.addStudent(student);
        group.addStudent(student1);

        System.out.println(group.toString());


    }
}
