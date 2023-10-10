using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Creating : MonoBehaviour
{

    [SerializeField]private float scaleFactor = 1.0f; // Початковий масштаб гравця
    [SerializeField] private float speed=10f;
    private Camera mainCamera;
    private Rigidbody rigidbody;
    private bool isMoving = false;
    private Vector3 direction;

    private void Start()
    {
        mainCamera=GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rigidbody = GetComponent<Rigidbody>();

        
    }
    private void FixedUpdate()
    {
        if (isMoving)
        {
            rigidbody.velocity = direction.normalized * speed;

            // Обмежте позицію об'єкта по осі Y, щоб не літав вище
            float newY = Mathf.Clamp(transform.position.y, scaleFactor, Mathf.Infinity);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
        else
        {
            // Обмежте позицію об'єкта по осі Y, навіть коли не рухається
            float newY = Mathf.Clamp(transform.position.y, scaleFactor, Mathf.Infinity);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);

            rigidbody.velocity = new Vector3(0, 0, transform.position.z).normalized * speed / 2;
        }
    }


    public void Scale(float touchDuration)
    {
        if (scaleFactor < 8)
        {
            scaleFactor += touchDuration / 10000;
            transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        }
    }

    public void SetDirectionAndPosition()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        //Ray ray = mainCamera.ScreenPointToRay(Input.GetTouch(0).position);
        direction = new Vector3(ray.direction.x,0f,ray.direction.z);
        isMoving = true;
    }
}
