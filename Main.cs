using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // * Linq needed


public class Main : MonoBehaviour
{
    public int[] grades = {1, 2, 75, 85};

    void Start()
    {
        var passingGrades = grades.Where(n => n > 65);

        foreach(var grade in passingGrades)
        {
            Debug.Log(grade);
        }
    }
}
