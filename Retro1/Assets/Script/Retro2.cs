using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retro2 : MonoBehaviour
{
    void makeStudent()
    {
        int[] student = new int[5];

        for (int i = 0; i < 5; i++)
        {
            student[i] = i + 1;
        }

        for ( int i = 0; i < 5; i++)
        {
            Debug.Log("학생의 수는 " + student[i]);
        }
    }
    
    void Start()
    {
        makeStudent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
