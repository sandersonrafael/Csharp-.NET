using Params;

/* Very bad solution */

int s1 = CalculatorVeryBadSolution.Sum(2, 3);
int s2 = CalculatorVeryBadSolution.Sum(2, 3, 4);
int s3 = CalculatorVeryBadSolution.Sum(2, 3, 4, 5);

Console.WriteLine($"{s1} {s2} {s3}");


/* Bad solution */

int s4 = CalculatorBadSolution.Sum(new int[] {2, 3});
int s5 = CalculatorBadSolution.Sum(new int[] { 2, 3, 4 });
int s6 = CalculatorBadSolution.Sum([2, 3, 4, 5, 1, 4, 6, 1]);

Console.WriteLine($"{s4} {s5} {s6}");

/* Good solution -> params modifier */

int s7 = CalculatorGoodSolutionParams.Sum(2, 3);
int s8 = CalculatorGoodSolutionParams.Sum(2, 3, 4);
int s9 = CalculatorGoodSolutionParams.Sum(2, 3, 4, 5, 1, 4, 6, 1);

Console.WriteLine($"{s4} {s5} {s6}");
