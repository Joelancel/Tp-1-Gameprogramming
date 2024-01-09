using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 50f;
    public float maxX = 10.2f;
    public float minX = -10.2f;
    public float maxY = 4.5f;
    public float minY = -4.5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(moveX, moveY);

        transform.Translate(move * Time.deltaTime * speed);

        Vector2 newPosition = new Vector2(
            Mathf.Clamp(transform.position.x, minX, maxX),
            Mathf.Clamp(transform.position.y, minY, maxY)
        );
        transform.position = newPosition;
    }
}