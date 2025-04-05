using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
