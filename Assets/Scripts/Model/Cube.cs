using System;
using UnityEngine;

public delegate void CreateCubeDelegate();
public class Cube : MonoBehaviour {
    public event CreateCubeDelegate CreateCubeEvent;

    private void OnTriggerEnter(Collider player) {
        if (player.TryGetComponent(out Player gamer)) {
            Destroy(gameObject);
            CreateCubeEvent?.Invoke();
            gamer.UpdateScore(1);
        }
    }
}
