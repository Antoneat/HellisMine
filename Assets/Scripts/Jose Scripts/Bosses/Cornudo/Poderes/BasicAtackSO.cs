using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Habilidades Verdugo/BasicAtack", order = 1)]

public class BasicAtackSO : Habilidad_SO
{
    public override void Activate(GameObject parent)
    {
        VerdugoController _verdugoController = parent.GetComponent<VerdugoController>();
        _verdugoController.basicAttack = true;
    }
}
