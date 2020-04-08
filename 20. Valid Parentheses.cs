public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> mapping = new Dictionary<char,char>()
        {
            {')','('},
            {'}','{'},
            {']','['}
        };
        
        Stack<char> stack = new Stack<char>();
        
        for(int i=0;i<s.Length;++i) {
            char current = s[i];
              // If the current character is a closing bracket.
                if(mapping.ContainsKey(current)) {
                // Get the top element of the stack. If the stack is empty, set a dummy value of '#'
                    char topElement = stack.Count==0 ? '#' : stack.Pop();
                    Console.WriteLine("pop "+current);
                // If the mapping for this bracket doesn't match the stack's top element, return false.
                    if(topElement!=mapping[current]) {
                        Console.WriteLine(topElement+" is not match "+current);
                        return false;
                    }
                } else {     
                // If it was an opening bracket, push to the stack.
                    Console.WriteLine("push "+current);
                    stack.Push(current);
                }        
        }
        // If the stack still contains elements, then it is an invalid expression.
        return stack.Count==0;
    }
}