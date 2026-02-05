using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePosition.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
    }
}