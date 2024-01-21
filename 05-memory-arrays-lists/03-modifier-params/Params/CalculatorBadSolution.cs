namespace Params;

public class CalculatorBadSolution {

    public static int Sum(int[] numbers) {
        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }
        return sum;
    }
}
