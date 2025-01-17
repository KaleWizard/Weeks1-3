using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos += Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.position = pos;
    }
}
