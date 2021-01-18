using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notes : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().NoteCount++;            
            gameObject.SetActive(false);
        }
    }

    void Update()
    {

    }
}
