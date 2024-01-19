namespace RefOut;

public class CalculatorWithRefAndOut {

    // Now, the value has changed, because x is a ref to the real variable (in the main Program)
    public static void TripleRef(ref int x) {
        x *= 3;
    }

    public static void TripleOut(int x, out int result) {
        result = x * 3;
    }
}
