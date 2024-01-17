using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rigidBody.MovePosition(rigidBody.position + direction);
        //transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("boom");
        Destroy(gameObject);
    }
}
