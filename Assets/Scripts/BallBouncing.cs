using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBouncing : MonoBehaviour
{
    public Vector2 direction;
    public float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(1, 1);
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        move();

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        checkFlipHorizontal(screenPosition);
        checkFlipVertical(screenPosition);
    }

    void move()
    {
        Vector2 position = transform.position;
        position += direction * speed * Time.deltaTime;
        transform.position = position;
    }

    void checkFlipHorizontal(Vector2 screenPosition)
    {
        if ((screenPosition.x < 0 && direction.x < 0) || (screenPosition.x > Screen.width && direction.x > 0))
        {
            direction.x *= -1;
        }
    }

    void checkFlipVertical(Vector2 screenPosition)
    {
        if ((screenPosition.y < 0 && direction.y < 0) || (screenPosition.y > Screen.height && direction.y > 0))
        {
            direction.y *= -1;
        }
    }
}
