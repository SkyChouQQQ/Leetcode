public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Count()==0) {return "";}
        string firstString = strs[0];
        string commonPrefix = "";
        
        for(int i=0;i<firstString.Length;++i) {
            string currentCommonPrefix = commonPrefix;
            commonPrefix+=Convert.ToString(firstString[i]);
            foreach(string item in strs) {
                if(!item.StartsWith(commonPrefix)) {return currentCommonPrefix;}
            }
        }
        return commonPrefix;
    }
}