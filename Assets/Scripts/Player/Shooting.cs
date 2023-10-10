using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject playerLayerPrefab;
    [SerializeField] private GameObject copyLayer;
    [SerializeField] private Transform spawnPos;

    private bool isScaling = false;
    public float scaleFactor = 10f;
    [SerializeField] private float offsetZ=2f;
    private float touchTime;
    private bool isLosing=false;

    void Update()
    {
        if (isScaling)
        {
            if (transform.localScale.x < 1)
            {
                GameManager.Instance.Lose();
                isLosing = true;
                
            }
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
            if (isLosing) return;
            if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                CreateLayer();
                isScaling = true;
                touchTime= 0;
            }
        }
    }

    private void CreateLayer()
    {
        Vector3 offset = new Vector3(0, 0, offsetZ);
        Vector3 scale = new Vector3(0, 0, transform.localScale.z);
        copyLayer = Instantiate(playerLayerPrefab, spawnPos.position + scale , Quaternion.identity);
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

