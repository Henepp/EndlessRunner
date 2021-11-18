using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSoundeffect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Environment"))
        {
            AudioManager.instance.StartWhoosh();
        }

    }
}
