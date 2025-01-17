using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserChaser : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        dir.z = 0;
        dir.Normalize();
        if (Input.GetMouseButton(0))
        {
            transform.position = transform.position + dir * speed * Time.deltaTime;
        }

        transform.up = dir;
    }
}
