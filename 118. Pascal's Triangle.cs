public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        IList<IList<int>> triangle = new List<IList<int>>();
        triangle.Add(new List<int>(){1});
        if(numRows==1) return triangle;
        
        triangle.Add(new List<int>(){1,1});
        if(numRows==2) return triangle;
        
        for(int rowNum = 2;rowNum < numRows;++rowNum)
        {
           IList<int> row = new List<int>(); 
           IList<int> preRow = triangle[rowNum-1];
           
           row.Add(1);
            
           for(int j = 1; j<rowNum; ++j)
           {
               row.Add(preRow[j-1]+preRow[j]);
           }
            
            row.Add(1);
            
            triangle.Add(row);
        }
        
        return triangle;
    }
}