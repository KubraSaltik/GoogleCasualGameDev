using UnityEngine;

public class RotationalMovement : MonoBehaviour
{
    public Vector3 rotationAmountVector;

    private void FixedUpdate()
    {
        transform.Rotate(rotationAmountVector * Time.fixedDeltaTime);
    }
}
