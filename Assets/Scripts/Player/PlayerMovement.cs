using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f; // Ўвидк≥сть кот≥нн€

    void Update()
    {
        // –ухаЇмо об'Їкт вперед по ос≥ Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
