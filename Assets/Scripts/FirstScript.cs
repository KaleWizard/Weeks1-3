using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FirstScript : MonoBehaviour
{
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        transform.position = pos;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            speed *= -1;
        }

        //Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.0f);
        //transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.Rotate(0, 0, 1);
    }
}
