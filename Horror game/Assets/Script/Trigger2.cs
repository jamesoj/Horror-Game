using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public GameObject Zom;

    public float targetTime;

    private int Count = 0;

    bool Activated;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && Count < 1)
        {
            Zom.SetActive(true);
            targetTime = 1.8f;
            Activated = true;
            if (Count < 1)
            {
                Count++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Activated && Count == 1)
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                if (Zom.active)
                {
                    Activated = false;
                    Zom.SetActive(false);
                }
            }

        }


    }

}
