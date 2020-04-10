public class Solution {
    public bool IsPalindrome(string s) {
        if (s==String.Empty) {return true;}
        string lowString = s.ToLower();
        string cleanString = lowString.Replace(",", "").Replace(":","").Replace(" ","").Replace(".","").Replace("@","").Replace("#","").Replace("$","").Replace("%","").Replace("^","").Replace("&","").Replace("*","").Replace("-","").Replace("!","").Replace("?","").Replace("\"","").Replace("\"","").Replace("\'","").Replace(";","").Replace("(","").Replace(")","").Replace("`","");      
        Console.WriteLine(cleanString);
        return cleanString==Reverse(cleanString);
    }
    
public static string Reverse( string s ) {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
    }
}