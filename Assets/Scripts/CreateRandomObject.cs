using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomObject : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateObject()
    {

        Vector3 prefabPosition = Random.insideUnitSphere *200;
        Instantiate(prefab, prefabPosition, Quaternion.identity);

    }

}
