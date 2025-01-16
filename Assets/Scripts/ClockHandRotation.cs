using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ClockHandRotation : MonoBehaviour
{
    public float speed = 0.01f;
    public float speedMultiplier = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angle = transform.eulerAngles;
        angle.z -= speed * speedMultiplier;
        transform.eulerAngles = angle;
    }
}
