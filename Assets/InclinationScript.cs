using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InclinationScript : MonoBehaviour
{
    public float inclinationChange;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, inclinationChange);
    }
}
