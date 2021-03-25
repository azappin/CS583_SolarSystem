using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnRevolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, .016f, 0, 0);
    }
}
