using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Assets.Model;
using UnityEngine;

public class CubeRandomCreate : MonoBehaviour {

    public GameObject Cube;

    public GameObject CurCube;

    void Update() {
        if(!CurCube) CreateCube(Cube, 8.8f, 0.5f, 8.8f);
    }

    void CreateCube(GameObject Cube, float xSize, float ySize, float zSize) {
        CurCube = GameObject.Instantiate(Cube, Position.RandomPosition(xSize, ySize, zSize), Quaternion.identity) as GameObject;
    }
}
