using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public Light myLight;

    void Update()
    {
        if (Random.value > 0.99) //a random chance
        {
            if (myLight.enabled == true) //if the light is on...
            {
                myLight.enabled = false; //turn it off
            }
            else
            {
                myLight.enabled = true; //turn it on
            }
        }
    }
}
