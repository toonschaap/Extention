using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getrandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> words = new List<string>();
        words.Add("stinky");
        words.Add("poo poo");
        words.Add("uh oh");
        words.Add("funny poo poo");

        Debug.Log(words.GetRandomValue());
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
