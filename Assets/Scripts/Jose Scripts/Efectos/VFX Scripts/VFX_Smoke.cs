using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX_Smoke : MonoBehaviour
{
    ParticleSystem ps;
    VerdugoController _verdugoController;
    void Start()
    {
        ps = this.gameObject.GetComponent<ParticleSystem>();
        _verdugoController = GetComponentInParent<VerdugoController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_verdugoController.chargingEffect == true)
        {
            ps.Play();
        }
    }
}
