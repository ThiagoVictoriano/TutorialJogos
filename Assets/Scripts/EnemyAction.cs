using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Update()
    {
        if (target != null)
        {
            // Move o inimigo em direção ao jogador
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

}
