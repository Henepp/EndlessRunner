using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float height = 0.5f;

    private Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    private void Update()
    {
        //up and down
        float _newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        transform.position = new Vector3(transform.position.x, _newY, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UiManager.instance.AddTimeToTimer();
        }
    }
    }
