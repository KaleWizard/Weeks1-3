using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBarrel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.up = dir;
    }
}
