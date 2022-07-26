using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    bool isHurt;
    bool isActing = false;
    Rigidbody2D rigidbody2D;
    Vector2 vector;

    SpriteRenderer render;
    Color halfA = new Color(1,1,1,0.5f);
    Color fullA = new Color(1,1,1,1);

    public float heartSpeed;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if(isActing)
            return;

        rigidbody2D.velocity = vector.normalized * heartSpeed;
    }

    void GetInput()
    {
        vector.x = Input.GetAxisRaw("Horizontal");
        vector.y = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Heart"))
        {
            
        }

    }
}
