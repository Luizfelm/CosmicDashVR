using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;  // Refer�ncia ao target (ex: jogador)
    public float speed = 5.0f; // Velocidade de movimento do inimigo

    private Vector3 direction; // Dire��o para o target
    private Rigidbody rb;      // Refer�ncia ao Rigidbody do inimigo

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        rb = GetComponent<Rigidbody>();

        // Calcula a dire��o apenas uma vez ao iniciar
        if (target != null)
        {
            direction = (target.position - transform.position).normalized;
        }
    }

    private void FixedUpdate()
    {
        // Move o inimigo na dire��o calculada
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
