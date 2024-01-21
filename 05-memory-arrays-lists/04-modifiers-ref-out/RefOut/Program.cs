using RefOut;

/* Attention -> the ref and out are a code smells -> isn't recommended to use them */

/* The value of a isn't changed with the operation */
int a = 10;
CalculatorWithoutRefAndOut.Triple(a);
Console.WriteLine(a);

/* Now, the value has changed because a ref is passed */
CalculatorWithRefAndOut.TripleRef(ref a);
Console.WriteLine(a);


/* Using out, isn't necessary to initialize the variable, just declare */
int result;
CalculatorWithRefAndOut.TripleOut(a, out result);
Console.WriteLine(result);
