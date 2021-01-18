using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public KeyCode flashlightToggleKey = KeyCode.F;
    public AudioClip toggleSound;
    public float batteryLifeInSeconds = 60;

    public float maxPower = 1;

    public float batteryLife;
    private bool isActive;

    private AudioSource myAudioSource;
    public Light myLight;
    

    public BatteryBar batteryBar;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        myLight = GetComponent<Light>();

        batteryLife = maxPower;
        batteryBar.SetMaxPower(maxPower);
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(flashlightToggleKey))
        {
            isActive = !isActive;

            if (myAudioSource != null && toggleSound != null)
                myAudioSource.PlayOneShot(toggleSound);

            
        }

        if (isActive)
        {
            myLight.enabled = true;
            batteryLife -= maxPower / batteryLifeInSeconds * Time.deltaTime;

            batteryBar.SetPower(batteryLife);
        }
        else
        {
            myLight.enabled = false;
        }

        if (batteryLife <= 0)
        {
            myLight.enabled = false;
            batteryLife = 0;
        }
        
    }

    public void AddBatteryLife(float _batteryPower)
    {
        batteryLife += _batteryPower;
        if (batteryLife > maxPower)
            batteryLife = 3;
    }
}
