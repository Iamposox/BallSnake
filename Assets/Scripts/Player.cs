using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    [SerializeField] private float _speed;

    [SerializeField] private float _rotationSpeed;

    [SerializeField] private Text _scoreText;

    [SerializeField] private int _score { get; set; }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.W)) _speed += 3;
        else if (Input.GetKeyUp(KeyCode.W)) _speed -= 3;
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) RotateSnake(Vector3.up, _rotationSpeed);
        if (Input.GetKey(KeyCode.A)) RotateSnake(Vector3.down, _rotationSpeed);
    }

    private void RotateSnake(Vector3 way, float speed) => transform.Rotate(way * speed * Time.deltaTime);

    public void UpdateScore(int score) {
        _score += score;
        _scoreText.text = _score.ToString();
    }
}
