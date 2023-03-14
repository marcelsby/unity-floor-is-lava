using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public int rotationChange;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotationChange, rotationChange));
    }
}
