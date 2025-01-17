using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpaceInvader : MonoBehaviour
{
    bool isMarchingDown;
    Vector2 downMarchStartPosition;
    bool isMarchingLeft;

    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 startPosition = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)) + Vector3.right;
        downMarchStartPosition = startPosition;
        isMarchingDown = true;
        transform.position = startPosition;
        isMarchingLeft = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMarchingDown)
        {
            transform.position = transform.position + Vector3.down * Time.deltaTime * speed;
            if (transform.position.y < downMarchStartPosition.y - 1)
            {
                isMarchingDown = false;
            }
        } else if (isMarchingLeft)
        {
            transform.position = transform.position + Vector3.left * Time.deltaTime * speed;
            Vector2 position = Camera.main.WorldToScreenPoint(transform.position + Vector3.left);

            if (position.x < 0)
            {
                ChangeToMarch();
            }
        } else
        {
            transform.position = transform.position + Vector3.right * Time.deltaTime * speed;
            Vector2 position = Camera.main.WorldToScreenPoint(transform.position + Vector3.right);
            if (position.x > Screen.width)
            {
                ChangeToMarch();
            }
        }
    }


    void ChangeToMarch()
    {
        isMarchingLeft = !isMarchingLeft;
        isMarchingDown = true;
        downMarchStartPosition = transform.position;
    }
}
