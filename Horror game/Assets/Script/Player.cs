using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int NoteCount;
    public Text NoteScore;

    // Start is called before the first frame update
    void Start()
    {
        NoteCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NoteScore.text = NoteCount.ToString();
    }
}
