using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f; 
    private Rigidbody rb;
    private bool move=true;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (move)
        {
            transform.position = new Vector3(transform.position.x, transform.localScale.z, transform.position.z);
            rb.velocity = new Vector3(0, 0, transform.position.z).normalized * speed;
        }
        else
        {
            rb.velocity = Vector3.zero;

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
    public void StopPlayer()
    {
        move = false;
    }
}
