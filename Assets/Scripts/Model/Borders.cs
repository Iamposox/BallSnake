using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Borders : MonoBehaviour
{
    void OnTriggerEnter(Collider snake) {
        if (snake.CompareTag("Snake")) {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        }
    }
}
