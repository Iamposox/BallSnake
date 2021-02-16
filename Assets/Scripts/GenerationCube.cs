using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Assets.Model;
using UnityEngine;

public class GenerationCube : MonoBehaviour {

    [SerializeField] private GameObject Cube;

    [SerializeField] private Cube CurCube;

    private void Start() {
        CreateCubeCube(Cube, 8.8f, 0.5f, 8.8f);
    }

    public void CreateCubeCube(GameObject сube, float xSize, float ySize, float zSize) {
        if (CurCube != null) CurCube.CreateCubeEvent -= CreateCubeCube;
        CurCube = Instantiate(сube, Position.RandomPosition(xSize, ySize, zSize), Quaternion.identity).GetComponent<Cube>();
        CurCube.CreateCubeEvent += CreateCubeCube;
    }
}
