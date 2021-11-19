using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMapGeneration : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MapGeneration.instance.CreateMapSection();
    }
}
