using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class ShipMovement : MonoBehaviour
{
    public InputActionAsset playerControls;

    InputAction moveAction;
    InputAction rotateAction;
    GameObject player;
    Rigidbody playerRB;

    [SerializeField] int speed = 500; 

    float move;
    float rotate;


    void OnEnable()
    {
        playerControls.Enable();
       
    }

    void OnDisable()
    {
        playerControls.Disable();
    }

    void Awake()
    {
        player = this.gameObject;
        playerRB = GetComponent<Rigidbody>();
        rotateAction = playerControls.FindAction("Rotation");
        moveAction = playerControls.FindAction("Move");
    }

    void Update()
    {
        ReadValues();
        MovingForward();
        RotateShip();
        
    }

    private void ReadValues()
    {
        move = moveAction.ReadValue<float>();
        rotate = rotateAction.ReadValue<float>();
        
    }

    void MovingForward()
    {
        playerRB.AddForce(0f, 0f, move * speed * Time.deltaTime);
    }
    void RotateShip()
    {
        playerRB.AddTorque(0, rotate * speed * Time.deltaTime, 0);
    }
}