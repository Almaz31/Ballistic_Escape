using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f; // Ўвидк≥сть кот≥нн€
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
    }
    public void StopPlayer()
    {
        move = false;
    }
}
