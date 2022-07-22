using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlanet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] planetTags;
    private GameObject choosenPlanet;
    private int index;
    public GameObject cameraControllerTag;
    void Start()
    {
        planetTags = GameObject.FindGameObjectsWithTag("Planet");
        index = Random.Range(0, planetTags.Length);
        choosenPlanet = planetTags[index];
        Debug.Log(choosenPlanet.name);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, choosenPlanet.transform.position, 0.03f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision çalýþtý");
        Destroy(gameObject);
        cameraControllerTag = GameObject.FindGameObjectWithTag("CameraController");
        cameraControllerTag.GetComponent<CameraStateManager>().StartIdleTimer();
    }
}
