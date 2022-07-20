using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAround : MonoBehaviour
{
    public GameObject target; // turns around this object
    public float angle;

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.RotateAround(target.transform.position, Vector3.up, angle * Time.deltaTime);
    }
}
