using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float destroyTime = 2f;
    public float speed = 10f;
    private Transform gun;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //find tag "Gun" in the scene
        gun = GameObject.FindGameObjectWithTag("Gun").transform;

        //Add a force to the bullet
        gameObject.GetComponent<Rigidbody>().AddForce(gun.right * speed, ForceMode.Impulse);       

        //Destroy the bullet after a certain amount of time
        Destroy(gameObject, destroyTime);

    }

    

    
}
