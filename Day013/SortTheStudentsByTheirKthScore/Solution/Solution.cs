using System;

class Solution{
    public int[][] SortTheStudents(int[][] score, int k) 
    {
        var list = score.ToList();
        list.Sort((x,y) => y[k] - x[k]);
        return list.ToArray();
    }
}