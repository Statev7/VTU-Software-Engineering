public abstract class Person {

    int age;
    String name;

    public Person(String name, int age){
        this.setName(name);
        this.setAge(age);
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String toString() {
        return "Name:" + this.name + " " + "Age:" + this.age + " ";
    }
}
