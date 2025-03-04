using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // all assets used from https://kenney.nl/assets/space-shooter-extension
    // background from Adobe Stock https://stock.adobe.com/ca/images/panorama-milky-way-galaxy-with-stars-and-space-dust-in-the-universe/185425447?prev_url=detail
    public float velocity = 500;
    public float steerspeed = 100;
    public float acceleration;
    public float steer;
    public Rigidbody2D rb;
    public GameObject rocketPrefab;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(rocketPrefab, spawn.position, spawn.rotation);
        }
    }
    private void FixedUpdate()
    {
        rb.AddTorque(steer * -steerspeed *  Time.deltaTime);
        Vector2 force = transform.up * acceleration * velocity * Time.deltaTime;
        rb.AddForce(force);
    }
}
