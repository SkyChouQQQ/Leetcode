public class Solution {
    public int RomanToInt(string s) {
        int res=0;
        Dictionary<char,int> mapping = new Dictionary<char,int>()
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
        
        for(int i=0;i<s.Length;++i) {
            int n1 = mapping[s[i]];
            int n2;
            if(i+1<s.Length) {n2=mapping[s[i+1]];}
            //i+1 exceeds s boundary
            else {n2=0;}
            if(n1>=n2) {
                res+=n1;
            } else {
                res = res+n2-n1;
                ++i;
            }
            
        }
        
        return res;
    }
}