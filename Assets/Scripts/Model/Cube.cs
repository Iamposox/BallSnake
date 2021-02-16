using System;
using UnityEngine;

public class Cube : MonoBehaviour {
    public event Action<GameObject, float, float, float> CreateCubeEvent;

    [SerializeField] private GameObject newCube;

    private void OnTriggerEnter(Collider player) {
        if (player.TryGetComponent(out Player gamer)) {
            Destroy(gameObject);
            CreateCubeEvent?.Invoke(newCube, 8.8f, 0.65f, 8.8f);
            gamer.UpdateScore(1);
        }
    }
}
