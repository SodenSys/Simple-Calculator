public class Program
{
	public static void Main(string[] args)
	{
		for (int i = 0; i < 49; i++)
		{
			Write(".");
			Thread.Sleep(10);
		}
		
		WriteLine("\nSimple, but painfully precise, calculator loaded!");
		Thread.Sleep(600);
		WriteLine("(Press Ctrl-C at any time to exit program.)");
		Thread.Sleep(600);
		
		calcStart:
		WriteLine("\nOperators: +  -  *  /\n");
		Write("Enter an operator: ");
		
		opChoice:
		string calcOp = ReadLine()!;
		
		if (calcOp == "+" || calcOp == "-" || calcOp == "*" || calcOp == "/")
		{
			Write("Enter operand (number), separate with comma: ");
			opOneStart:
			if (double.TryParse(ReadLine()!, out double opOne))
			{
				Write("Now enter a second operand (number), separate with comma: ");
				opTwoStart:
				if (double.TryParse(ReadLine()!, out double opTwo))
				{
					double opRes;
					switch (calcOp)
					{
						case "+":
							opRes = opOne + opTwo;
							Write($"\n{opOne} + {opTwo} = {opRes}\n");
							break;
						case "-":
							opRes = opOne - opTwo;
							Write($"\n{opOne} - {opTwo} = {opRes}\n");
							break;
						case "*":
							opRes = opOne * opTwo;
							Write($"\n{opOne} * {opTwo} = {opRes}\n");
							break;
						case "/":
							opRes = opOne / opTwo;
							Write($"\n{opOne} / {opTwo} = {opRes}\n");
							break;
					}
				}
				else
				{
					Write("\nInvalid number, please enter a second operand: ");
					goto opTwoStart;
				}
			}
			else
			{
				Write("\nInvalid number, please enter an operand: ");
				goto opOneStart;
			}
		}
		else
		{
			Write("\nInvalid operator, please enter a valid operator: ");
			goto opChoice;
		}
		Thread.Sleep(200);
		
		Write("\nRestarting\n");
		for (int i = 0; i < 10; i++)
		{
			Write(".");
			Thread.Sleep(50);
		}
		goto calcStart;
	}
}