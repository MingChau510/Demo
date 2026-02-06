using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 6f;
    public int damage = 1;

    void Update()
    {
        transform.Translate(Vector2.up * flySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}