using UnityEngine;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour {

    public float Speed;

    public float RotationSpeed;

    public Text ScoreText;

    public int Score { get; set; }

    // Update is called once per frame
    void Update() {
        ScoreText.text = Score.ToString();
        if (Input.GetKeyDown(KeyCode.W)) Speed += 3;
        else if (Input.GetKeyUp(KeyCode.W)) Speed -= 3;
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) RotateSnake(Vector3.up, RotationSpeed);
        if (Input.GetKey(KeyCode.A)) RotateSnake(Vector3.down, RotationSpeed);
    }

    private void RotateSnake(Vector3 way, float speed) => transform.Rotate(way* speed * Time.deltaTime);

}
