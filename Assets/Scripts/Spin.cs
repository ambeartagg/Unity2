using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
       transform.Rotate(0, speed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
