using MotoApp;

var stack = new BasicStack<double>();
stack.Push(45.3);
stack.Push(124);
stack.Push(546.1);

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($" item {item}");
    sum += item;
}

Console.WriteLine($"Sum:{sum}");

var stackString = new BasicStack<string>();
stackString.Push("Company A");
stackString.Push("Company B");
stackString.Push("Company C");

while (stackString.Count > 0)
{
    string item = stackString.Pop();
    Console.WriteLine($" item {item}");
}
