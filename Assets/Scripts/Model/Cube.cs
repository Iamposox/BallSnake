using UnityEngine;

public class Cube : MonoBehaviour
{
    void OnTriggerEnter(Collider snake) {
        if (snake.CompareTag("Snake")) {
            Destroy(gameObject);
            snake.GetComponent<SnakeMovement>().Score++;
        }
    }
}
