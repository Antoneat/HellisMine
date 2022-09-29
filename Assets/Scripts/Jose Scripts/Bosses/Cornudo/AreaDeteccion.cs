using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AreaDeteccion : MonoBehaviour
{
    VerdugoController verdugoScript;
    
    
    void Start()
    {
        verdugoScript = GetComponentInParent<VerdugoController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            verdugoScript.onChase = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DelayDeRetroceso());
            verdugoScript.onChase = false;
            
          

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            verdugoScript.active = true;
            

        }
        
    }

    IEnumerator DelayDeRetroceso()
    {
        yield return new WaitForSeconds(3);
        verdugoScript.agent.SetDestination(verdugoScript.startPosition);
    }

}
