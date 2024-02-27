using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
        
        int result  = IsmaxPalindrone(n);
        Console.WriteLine(result);
        
        }
    }
    
    
    static int  IsmaxPalindrone(int n){
        
        int maxPalindrone = 0;
        for(int i=999;i>=100;i--){
            
            for(int j=i;j>=100;j++){
                int Product = j*i;
                if(Product<n && checkPalindrome(Product)){
                    maxPalindrone = Math.Max(maxPalindrone, Product);
                    break;
                }
            }
        
        }
        return maxPalindrone;
        
    }
    
    static bool checkPalindrome(int number){
        
        string strNumber = number.ToString();
        int length = strNumber.Length;
        for(int i=0;i<length/2;i++){
            if(strNumber[i]!=strNumber[length-i-1]){
                return false;
            }
        }
        return true;
        
        
    }
}
