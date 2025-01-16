using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveDemo : MonoBehaviour
{
    public AnimationCurve curve;
    public float leftOffset = 0;

    [Range(0, 32)] public float scale = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = curve.Evaluate(Time.time) * scale - leftOffset;
        transform.position = position;
    }
}
