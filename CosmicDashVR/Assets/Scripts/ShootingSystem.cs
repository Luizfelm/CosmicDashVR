using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingSystem : MonoBehaviour
{
    public InputActionProperty inputActionProperty;
    public GameObject bulletPrefab;
    public AudioSource audioSource;

    public void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        audioSource.Play();
    }


}
