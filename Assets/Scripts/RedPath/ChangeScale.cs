using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    [SerializeField]private GameObject playerLayer; // Ссилка на ваш шар
    [SerializeField] private float initialWidth=4f; // Початкова ширина доріжки


    private void Update()
    { 
        float layerHeight = playerLayer.transform.localScale.y;

        float newWidth = initialWidth + layerHeight;

        Vector3 newScale = new Vector3(newWidth, transform.localScale.y, transform.localScale.z);
        transform.localScale = newScale;
    }
}
