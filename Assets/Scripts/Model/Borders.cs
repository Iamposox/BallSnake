using UnityEngine;
using UnityEngine.SceneManagement;

public class Borders : MonoBehaviour {
    void OnTriggerEnter(Collider snake) {
        if (snake.TryGetComponent(out Player newSnake)) {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        }
    }
}
