using UnityEngine;

public class ActivateMapGeneration : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("hi");
            MapGeneration.instance.CreateMapSection();
        }
    }
}
