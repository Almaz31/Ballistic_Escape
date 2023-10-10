using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour
{
    [SerializeField] private Material endMaterial;
    private bool startExplose;
    private void Update()
    {
        if (startExplose)
        {
            Vector3 step = new(0.1f, 0.1f, 0.1f);
            transform.localScale +=step;
        }
    }
    public void StartDestroying()
    {
        this.GetComponent<MeshRenderer>().material = endMaterial;
        startExplose = true;
        StartCoroutine("DestroyEnemy");
    }
    private IEnumerator DestroyEnemy()
    {
        
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("DestroySphera"))
        {
            StartDestroying();
        }
    }
    
}
