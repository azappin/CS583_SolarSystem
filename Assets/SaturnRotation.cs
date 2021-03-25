using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 23f, 0, 0);
    }
}
