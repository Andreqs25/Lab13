using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{
    public int speedX;
    public int speedY;
    public float directionX;
    public float directionY;

    private SpriteRenderer _compSpriteRenderer;

    void Awake()
    {
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            directionX = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            directionX = -1;
        }
        else
        {
            directionX = 0;
        }

        if (Input.GetKey(KeyCode.W))
        {
            directionY = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            directionY = -1;
        }
        else
        {
            directionY = 0;
        }

        transform.position = new Vector2(transform.position.x + speedX * directionX * Time.deltaTime, transform.position.y + speedY * directionY * Time.deltaTime);
    }
}