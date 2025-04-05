using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;  // Referência ao target (ex: jogador)
    public float speed = 5.0f; // Velocidade de movimento do inimigo

    private Vector3 direction; // Direção para o target
    private Rigidbody rb;      // Referência ao Rigidbody do inimigo

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        rb = GetComponent<Rigidbody>();

        // Calcula a direção apenas uma vez ao iniciar
        if (target != null)
        {
            direction = (target.position - transform.position).normalized;
        }
    }

    private void FixedUpdate()
    {
        // Move o inimigo na direção calculada
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
