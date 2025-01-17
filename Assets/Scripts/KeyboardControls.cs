using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControls : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1f;

    bool isFlipped;

    public Transform topLeft;
    public Transform bottomRight;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.zero;
        direction.Normalize();
        isFlipped = false;
    }

    // Update is called once per frame
    void Update()
    {
        move();

        Vector2 positionTL = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height));
        Vector2 positionBR = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0));
        checkClampHorizontal(positionTL.x, positionBR.x);
        checkClampVertical(positionTL.y, positionBR.y);
    }

    void move()
    {
        direction.x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        direction.y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        direction.Normalize();
        transform.position = transform.position + direction * speed * Time.deltaTime;

        if (direction.x > 0 && isFlipped)
        {
            isFlipped = false;
            transform.localScale = Vector3.one;
        } else if (direction.x < 0 && !isFlipped)
        {
            isFlipped = true;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    void checkClampHorizontal(float left, float right)
    {
        if (topLeft.position.x < left)
        {
            transform.position = new Vector2(left + bottomRight.localPosition.x, transform.position.y);
        } else if (bottomRight.position.x > right)
        {
            transform.position = new Vector2(right + topLeft.localPosition.x, transform.position.y);
        }
    }

    void checkClampVertical(float top, float bottom)
    {
        if (bottomRight.position.y < bottom)
        {
            transform.position = new Vector2(transform.position.x, bottom + topLeft.localPosition.y);
        } else if (topLeft.position.y > top)
        {
            transform.position = new Vector2(transform.position.x, top + bottomRight.localPosition.y);
        }
    }
}
