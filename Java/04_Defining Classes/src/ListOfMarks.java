public class ListOfMarks {

    private double[] markList;
    private int numMarks;

    public static final int MAX_NUMBER_OF_MARKS = 40;

    public ListOfMarks(){
        this.markList = new double[MAX_NUMBER_OF_MARKS];
        this.numMarks = 0;
    }

    public void addMark(double mark){
        this.markList[numMarks++] = mark;
    }

    public double average(){

        double sum = 0;
        for (int index = 0; index < this.numMarks; index++) {
            sum += this.markList[index];
        }

        double result = sum / this.numMarks;
        return  result;
    }

    public double[] getMarkList() {
        return markList;
    }

    public void setMarkList(double[] markList) {
        this.markList = markList;
    }

    public int getNumMarks() {
        return numMarks;
    }

    public void setNumMarks(int numMarks) {
        this.numMarks = numMarks;
    }

    @Override
    public String toString() {

        String result = "";
        for (int index = 0; index < numMarks; index++) {
            result += this.markList[index] + " ";
        }

        return result;
    }
}
