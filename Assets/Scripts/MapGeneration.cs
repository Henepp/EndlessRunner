using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    [SerializeField] private GameObject mapHolder;

    public GameObject[] Platforms;


    void Start()
    {
        CreateMapSection();
    }


    public void CreateMapSection()
    {
        Vector3 _pos = new Vector3(0, 0, 0);

        for (int i = 0; i < 20; i++)
        {
            //gets a random number to spawn a different platform
            int _platformNumber = Random.Range(0, Platforms.Length);

            //instantiates a platform prefab
            GameObject _go = Instantiate(Platforms[_platformNumber], _pos, Quaternion.identity);

            //sets the instantiated objects parent
            _go.transform.SetParent(mapHolder.transform);

            //sets the offset every time it loops trough the forloop
            _pos.z += 10;
        }
    }
}
