using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject playerLayerPrefab;
    [SerializeField] private GameObject copyLayer;
    [SerializeField] private Transform spawnPos;

    private bool isScaling = false;
    [SerializeField] private float scaleFactor = 10f;
    private float touchTime;

    void Update()
    {
        if (isScaling)
        {
            ScalePlayer();
            if (Input.GetMouseButtonUp(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended))
            {
                isScaling = false;

                if (copyLayer != null)
                {
                    Creating copyScript = copyLayer.GetComponent<Creating>();
                    copyScript.SetDirectionAndPosition();
                }
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                CreateLayer();
                isScaling = true;
                touchTime= 0;
                Debug.Log(scaleFactor);
            }
        }
    }

    private void CreateLayer()
    {
        // Створюємо новий шар перед гравцем і встановлюємо його позицію
        copyLayer = Instantiate(playerLayerPrefab, spawnPos.position, Quaternion.identity);
    }

    private void ScalePlayer()
    {
        touchTime += Time.timeScale;
        scaleFactor = transform.localScale.x;
        scaleFactor -= touchTime/100000;
        transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        if (copyLayer != null)
        {
            Creating copyScript = copyLayer.GetComponent<Creating>();
            copyScript.Scale(touchTime);
        }
    }
}

