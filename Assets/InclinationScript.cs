using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InclinationScript : MonoBehaviour
{
    public float inclinationChange;
    public Vector3 positionChange;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, inclinationChange);
        transform.position += positionChange;
    }
}
