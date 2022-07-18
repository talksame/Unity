using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string name;
    public string sound;

    public void Playsound(string name)
    {
        Debug.Log( name + sound);
    }
}
