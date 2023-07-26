namespace CodeChallenge13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validateBrackets("{}")); // TRUE
            Console.WriteLine(validateBrackets("{}(){}")); // TRUE
            Console.WriteLine(validateBrackets("()[[Extra Characters]]")); // TRUE
            Console.WriteLine(validateBrackets("(){}[[]]")); // TRUE
            Console.WriteLine(validateBrackets("{}{Code}[Fellows](())")); // TRUE
            Console.WriteLine(validateBrackets("[({}]")); // FALSE
            Console.WriteLine(validateBrackets("(](")); // FALSE
            Console.WriteLine(validateBrackets("{(})")); // FALSE
        }

        public static bool validateBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false; // Unmatched closing bracket
                    }

                    char top = stack.Pop();
                    if ((ch == ')' && top != '(') ||
                        (ch == ']' && top != '[') ||
                        (ch == '}' && top != '{'))
                    {
                        return false; // Closing bracket doesn't match the top of the stack
                    }
                }
            }

            return stack.Count == 0; // Check if all opening brackets are matched
        }
    }
}
