using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Public variable to set the speed of the gameobject
    public float movement = 0f;

    private float minPosition = -3.5f;
    private float maxPosition = 3.5f;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        
        movement = Mathf.Clamp(movement, minPosition, maxPosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, movement);
    }
   

}
