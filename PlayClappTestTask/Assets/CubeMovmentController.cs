using UnityEngine;

public class CubeMovmentController
{
    private float _moveSpeed;
    private float _distance;
    private Cube _cube;

    public CubeMovmentController(Cube cube, float moveSpeed, float distance)
    {
        _cube = cube;
        _moveSpeed = moveSpeed;
        _distance = distance;
    }

    public void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        if (_cube != null)
        {
            _cube.transform.position = Vector3.MoveTowards(_cube.transform.position, new Vector3(_distance, 0, 0), _moveSpeed * Time.deltaTime);
            CubeCollapseByReachTarget();
        }
    }

    private void CubeCollapseByReachTarget()
    {
        if (_cube.transform.position == new Vector3(_distance, 0, 0))
        {
            Object.Destroy(_cube.gameObject);
        }
    }
}
