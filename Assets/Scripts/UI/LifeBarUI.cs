using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarUI : MonoBehaviour
{
    [SerializeField] private Slider lifeBarSlider;
    [SerializeField] private GameObject playerLayer; 


    private void Update()
    {
        float layerHeight = playerLayer.transform.localScale.y;
        float lifeBarValue = (layerHeight - 1f) / 9f*100f;

        lifeBarSlider.value = lifeBarValue;
    }
}
