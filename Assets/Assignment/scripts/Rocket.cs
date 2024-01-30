using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        Vector2 direction = new Vector2(transform.up.x,transform.up.y) *speed * Time.deltaTime;
        rb.MovePosition(rb.position + direction);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Boom");
        Destroy(gameObject);
    }
}
