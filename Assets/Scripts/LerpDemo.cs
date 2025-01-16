using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{
    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = Vector2.one * Mathf.Lerp(-5, 5, (Mathf.Sin(Time.time) / 2) + 0.5f);
        transform.position = Vector2.Lerp(start.position, end.position, (Mathf.Sin(Time.time) / 2) + 0.5f);
        Random.Range(0, 1);
    }
}
