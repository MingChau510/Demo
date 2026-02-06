using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // di chuyển xuống dưới
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // nếu ra khỏi màn hình thì xóa
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}