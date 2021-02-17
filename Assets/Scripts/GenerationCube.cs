using Assets.Model;
using UnityEngine;

public class GenerationCube : MonoBehaviour {

    [SerializeField] private GameObject _cube;

    [SerializeField] private Cube _curCube;

    private void Start() {
        CreateCube(_cube, 8.8f, 0.5f, 8.8f);
    }

    public void CreateCube(GameObject cube, float xSize, float ySize, float zSize) {
        if (_curCube != null) _curCube.CreateCubeEvent -= () => CreateCube(cube, 8.8f, 0.65f, 8.8f);
        _curCube = Instantiate(cube, Position.RandomPosition(xSize, ySize, zSize), Quaternion.identity).GetComponent<Cube>();
        _curCube.CreateCubeEvent += () => CreateCube(cube, 8.8f, 0.65f, 8.8f);
    }
}
