using System;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<Student> students = new List<Student>();

    void Start()
    {
        Debug.Log("Start");
        students.Add(new Student("Kevin", 12));
        students.Add(new Student("Tracy", 15));
        students.Add(new Student("Oliver", 18));
        students.Add(new Student("Tania", 10));

        students.Sort();

        //foreach(Student stud in students)
        //{
            Debug.Log(message: $" L'élève le plus agé est {students[0].name} ");
        //}

        double[] ts = { 7, -10, 13, 8, 4, -7.2, -12, -3.7, 3.5, -9.6, 6.5, -1.7, -6.2, 7 };
        double result = Solution.ClosestToZero(ts);

        Debug.Log("Result: " + result);
    }


}


class Solution
{

    public static double ClosestToZero(double[] ts)
    {
        Array empty = new Array[0];

        if (ts == empty)
            return 0.0;

        double lastTemp = 5526; // -273
        int maxIndex = 0;
        
        for (int i = 0; i < ts.Length; i++)
        {

            if (ts[i] < 0 && Math.Abs(ts[i]) == lastTemp)
            {
                break;
            }

            if (Math.Abs(ts[i]) < lastTemp)
            {
                maxIndex = i;
                lastTemp = Math.Abs(ts[i]);
            }
            
        }
        return ts[maxIndex];
    }
}


