package Day010.LemonadeChange;

public class Solution {
    public static boolean lemonadeChange(int[] bills){
       int five = 0, ten = 0;
        for (int bill : bills) {
            if (bill == 5)  
                five++;
            else if (bill == 10) { 
                five--; ten++;
            }
            else if (ten > 0 && five>=1) {
                ten--; five--;
            }
            else       
                five -= 3;
            if (five < 0) 
                return false;
        }
        return true;
    }
    
    public static void main(String[] args){
        int[] exampleBills = {5,5,5,10,20};
        boolean example = lemonadeChange(exampleBills);
        System.out.println(example);

        int[] exampleBills2 = {5,5,10,10,20};
        example = lemonadeChange(exampleBills2);
        System.out.println(example);
    }
}
