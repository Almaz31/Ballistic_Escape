using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    [SerializeField] private GameObject radiusObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            CheckRadius(other.transform.position);
            Debug.Log("Hit Enemy");
        }
    }
    private void CheckRadius(Vector3 pos)
    {
        GameObject explosionZone = Instantiate(radiusObject, pos, Quaternion.identity);
        explosionZone.transform.localScale=this.transform.localScale*2;

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // ��������� ��� ������ � �������� ������� ������ ��� ������� � ���, �� ��������� � ����
        foreach (GameObject e in enemies)
        {
            // ��������, �� ����� ����������� � ����� ������
            float distance = Vector3.Distance(explosionZone.transform.position, e.transform.position);
            if (distance < explosionZone.transform.localScale.x)
            {
                e.GetComponent<Destroying>().StartDestroying();
            }
        }

        // ������� ����
        Destroy(gameObject);
    }
}

