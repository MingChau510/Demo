using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var explosion = Instantiate(
            explosionPrefab,
            transform.position,
            Quaternion.identity
        );

        Destroy(explosion, 0.5f);
        Destroy(gameObject);
    }
}