using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallBouncing : MonoBehaviour
{
    public Vector2 direction;
    public float speed = 1f;

    public float scale = 1f;

    public Transform topLeft;
    public Transform bottomRight;

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

        Vector2 positionTL = Camera.main.WorldToScreenPoint(topLeft.position);
        Vector2 positionBR = Camera.main.WorldToScreenPoint(bottomRight.position);
        checkFlipHorizontal(positionTL.x, positionBR.x);
        checkFlipVertical(positionTL.y, positionBR.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            direction.Normalize();
            transform.position = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            scale += 0.1f;
            ResetScale();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            scale -= 0.1f;
            ResetScale();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed += 1f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed -= 1f;
        }
    }

    void move()
    {
        Vector2 position = transform.position;
        position += direction * speed * Time.deltaTime;
        transform.position = position;
    }

    void checkFlipHorizontal(float left, float right)
    {
        if ((left < 0 && direction.x < 0) || (right > Screen.width && direction.x > 0))
        {
            direction.x *= -1;
        }
    }

    void checkFlipVertical(float top, float bottom)
    {
        if ((bottom < 0 && direction.y < 0) || (top > Screen.height && direction.y > 0))
        {
            direction.y *= -1;
        }
    }

    void ResetScale()
    {
        transform.localScale = Vector2.one * scale;
    }
}
