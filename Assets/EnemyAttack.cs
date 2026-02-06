using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 1;
    private Health selfHealth;

    private void Awake()
    {
        selfHealth = GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health playerHealth = collision.GetComponent<Health>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);

            // enemy tự sát
            if (selfHealth != null)
            {
                selfHealth.TakeDamage(999);
            }
        }
    }
}