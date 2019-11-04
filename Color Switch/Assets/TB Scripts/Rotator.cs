using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float rotatorSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,rotatorSpeed * Time.deltaTime);
    }
    
}
