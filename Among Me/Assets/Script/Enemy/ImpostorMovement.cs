using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpostorMovement : MonoBehaviour
{
    public float moveSpeedX;
    public float moveSpeedY;
    public float range;

    float startingX;
    float startingY;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        startingX = transform.position.x;
        startingY = transform.position.y;

    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * moveSpeedX * direction * Time.deltaTime);
        transform.Translate(Vector2.up * moveSpeedY * direction * Time.deltaTime);

        if (transform.position.x < startingX || transform.position.x > startingX + range || transform.position.y < startingY || transform.position.y > startingY + range)
        {
            Flip();
        }
    }

    void Flip()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        direction *= -1;
    }

}
