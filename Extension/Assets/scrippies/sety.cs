using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sety : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetPositionY(3);
        Debug.Log("thingie moved a bit");
        
    }
}
