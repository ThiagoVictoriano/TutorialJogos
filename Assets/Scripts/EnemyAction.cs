using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    public Transform target;
    public float baseSpeed = 2f; // Velocidade inicial
    public float maxSpeed = 10f;  // Velocidade m�xima

    void Update()
    {
        if (target != null)
        {
            // Aumenta com o tempo, mas limitado a maxSpeed
            float currentSpeed = Mathf.Min(baseSpeed + (GameTimer.elapsedTime / 2f), maxSpeed);

            // Move o inimigo em dire��o ao jogador
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * currentSpeed * Time.deltaTime;
        }
    }
}
