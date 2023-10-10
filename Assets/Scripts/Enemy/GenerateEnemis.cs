using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemis : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefs;
    [SerializeField] private Transform MaxZ;
    [SerializeField] private Transform MinZ;
    [SerializeField] private Transform MaxX;
    [SerializeField] private Transform MinX;
    [SerializeField] private int numOfEnemis;
    private int currentNumOfEnemis;

    private void Start()
    {
        GenerateEnemy();
    }
    private void GenerateEnemy()
    {
        while (currentNumOfEnemis < numOfEnemis)
        {
            float randX = Random.Range(MinX.position.x, MaxX.position.x);
            float randZ = Random.Range(MinZ.position.z, MaxZ.position.z);
            float randScale = Random.Range(1, 5);
            float randY = 0f;
            Vector3 pos = new Vector3(randX, randScale, randZ);
            Vector3 scale = new Vector3( randScale, randScale, randScale);
            GameObject newEnemy= Instantiate(enemyPrefs,pos, Quaternion.identity );
            newEnemy.transform.localScale = scale;
            currentNumOfEnemis++;
        }
    }
}
