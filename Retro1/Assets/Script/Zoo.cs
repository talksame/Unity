using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "Tom";
        tom.sound = "WHOO";

        tom.Playsound(tom.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
