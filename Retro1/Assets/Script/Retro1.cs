using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retro1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity");
        GetDistance(1, 2);
        GetLove(70);
        GetLove(69);
        GetLove(71);

    }

    void GetDistance(float a, float b)
    {
        Debug.Log(a + b);
    }

    void GetLove(float c)
    {
        if (c > 70)
        {
            Debug.Log("C2");
        }
        else if ( c >= 70)
        {
            Debug.Log("C3");
        }

        if (c >= 70)
        {
            Debug.Log("C3");
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
