namespace GenericStack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();
            stack.push(10);
            stack.push(20);
            stack.push(30);

            while (!stack.IsEmpty())
            {
                int item = stack.pop();
                Console.WriteLine(item);
            }

            Stack<char> stack1 = new Stack<char>();
            stack1.push('n');
            stack1.push('a');
            stack1.push('m');
            stack1.push('h');
            stack1.push('r');
            stack1.push('l');
            stack1.push('e');
            stack1.push('d');
            stack1.push('b');
            stack1.push('a');
            
            while (!stack1.IsEmpty())
            {
                char item = stack1.pop();
                Console.Write(item);
            }
            
            
        }
    }
}