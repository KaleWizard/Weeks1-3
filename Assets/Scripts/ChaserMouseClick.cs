using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserMouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(pos, transform.position) < 1)
            {
                pos = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height)));
            }
            transform.position = pos;
        }
    }
}
