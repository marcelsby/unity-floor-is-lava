using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
    }
}
