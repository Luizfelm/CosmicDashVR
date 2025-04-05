using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementInput : MonoBehaviour
{
    private float movement = 0f;
    private float minPosition = -2.5f;
    private float maxPosition = 2.5f;

    public InputActionProperty movementAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        MoveZAxis();
    }

    public void MoveZAxis()
    {
        // Get the value of the movement action and clamp it to the min and max position, changing the z axis of the player
        movement = movementAction.action.ReadValue<float>() / 10;
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z + movement, minPosition, maxPosition));


    }


}
