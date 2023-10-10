using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private Transform player;// Посилання на об'єкт гравця
    [SerializeField] private float distance = 5.0f;
    [SerializeField] private float height = 2.0f; // Плавність руху камери

    void LateUpdate()
    {
        if (target == null)
        {
            return; // Перевірка, чи є посилання на гравця
        }

        // Обчислюємо позицію, до якої має наближатися камера
        Vector3 desiredPosition = player.position - target.forward * distance + Vector3.up * height;

        // Встановлюємо позицію камери
        transform.position = desiredPosition;

        // Направляємо камеру в тому ж напрямку, куди гравець котиться (вісь Z)
        transform.forward = target.forward;
        transform.LookAt(target.position);
    }
}

