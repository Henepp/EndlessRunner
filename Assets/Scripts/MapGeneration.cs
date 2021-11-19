using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    public static MapGeneration instance;

    [SerializeField] private GameObject mapHolder;

    private Vector3 Pos = Vector3.zero;

    public GameObject[] Platforms;

    [Header("Spawn Settings")]
    public int AmountSpawned;
    public int OffsetZ;

    private void Awake()
    {
        //singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

    }

    void Start()
    {
        CreateMapSection();
    }


    public void CreateMapSection()
    {
        for (int i = 0; i < AmountSpawned; i++)
        {
            //gets a random number to spawn a different platform
            int _platformNumber = Random.Range(0, Platforms.Length);

            //instantiates a platform prefab
            GameObject _go = Instantiate(Platforms[_platformNumber], Pos, Quaternion.identity);

            //sets the instantiated objects parent
            _go.transform.SetParent(mapHolder.transform);

            //sets the offset every time it loops trough the forloop
            Pos.z += OffsetZ;
        }
    }
}
