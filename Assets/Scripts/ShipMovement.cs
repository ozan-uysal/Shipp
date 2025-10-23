using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class ShipMovement : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;

    void Update()
    {
        
        Vector2 moveInput = Vector2.zero;
        Vector2 rotateInput = Vector2.zero;

        Vector3 moveDirection = transform.forward * moveInput.y * speed * Time.deltaTime;
        transform.position += moveDirection;
        Debug.Log(moveDirection);

        float rotationAmount = rotateInput.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationAmount, 0);
    }
}