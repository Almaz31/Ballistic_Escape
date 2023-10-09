using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f; // �������� ������

    void Update()
    {
        // ������ ��'��� ������ �� �� Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
