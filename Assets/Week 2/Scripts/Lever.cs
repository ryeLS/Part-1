using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (door.activeInHierarchy == false )
        {
            Debug.Log("active");
            door.SetActive(true);
        }
        else
        {
            Debug.Log("inactive");
            door.SetActive(false);
        }
    }

}
