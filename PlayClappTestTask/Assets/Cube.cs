using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private CubeMovmentController _cubeMovmentController;
    public void Init(float moveSpeed, float distance)
    {
        _cubeMovmentController = new CubeMovmentController(this, moveSpeed, distance);
    }
    private void Update()
    {
        _cubeMovmentController.Update();
    }
}
