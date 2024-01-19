namespace RefOut;

public class CalculatorWithoutRefAndOut {

    public static void Triple(int x) {
        x *= 3; // The value of the variable isn't changed because it's turns scoped
    }
}
