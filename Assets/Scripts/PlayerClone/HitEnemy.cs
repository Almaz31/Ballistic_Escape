using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    [SerializeField] private GameObject radiusObject;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Hit();
            CheckRadius(collision.transform.position);
            Debug.Log("Hit Enemy");
        }
    }
    private void Hit()
    {
        Destroy(gameObject);
    }
    private void CheckRadius(Vector3 pos)
    {
        GameObject sphera=Instantiate(radiusObject, pos, Quaternion.identity);
        sphera.transform.localScale=this.transform.localScale;
    }
}
