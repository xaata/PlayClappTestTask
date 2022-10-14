using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnDelay;
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;
    [SerializeField] private Cube _cube;

    private void Start()
    {
        StartCoroutine(SpawnCube());
    }
    private IEnumerator SpawnCube()
    {
        while (true)
        {
            Cube cube = Instantiate(_cube, transform);
            cube.Init(_speed, _distance);
            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}
