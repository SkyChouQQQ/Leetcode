public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(n==0) {return;}
        int[] result = new int[m+n];
        int index1=0;
        int index2=0;
        int index=0;
        while(index1<m && index2<n) {
            if(nums1[index1]<=nums2[index2]) {
                result[index] = nums1[index1];
                ++index1;
                ++index;
            } else {
                result[index] = nums2[index2];
                ++index2;
                ++index;
            }
        }
        if(index1==m){
            while(index<m+n) {
            result[index] = nums2[index2];
            ++index2;
            ++index;
            
           }
        }
        
        if(index2==n){
         while(index<m+n) {
            result[index] = nums1[index1];
            ++index1;
            ++index;
        }
        }
        
        for(int i=0;i<m+n;++i) {
            nums1[i]= result[i];
        }
        
    }
}

