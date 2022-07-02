using UnityEngine;

public class RotationalMovement : MonoBehaviour
{
    public Vector3 rotationAmountVector;

    private void Start()
    {
        Debug.Log($"{name} -> donmeye basliyor!!121");
    }

    private void FixedUpdate()
    {
        transform.Rotate(rotationAmountVector * Time.fixedDeltaTime);
    }
}
