using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject _pipe;
    public float _spawnRate = 2f;
    public float _heightOffset = 8;
    public float _widthOffset = 5;
    public float _pipeStartPosition = 30;

    private float _timer = 0;
    
    void Start()
    {
        SpawnPipe(true);
    }

    void Update()
    {
        if (_timer < _spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            _timer = 0;
        }  
    }

    private void SpawnPipe(bool isStart = false)
    {
        float lowestPoint = transform.position.y - _heightOffset;
        float highestOffset = transform.position.y + _heightOffset;
        float leftMostPoint = isStart ? _pipeStartPosition : transform.position.x - _widthOffset;
        float rightMostOffset = isStart ? _pipeStartPosition : transform.position.x + _widthOffset;

        Instantiate(_pipe, new Vector3(Random.Range(leftMostPoint, rightMostOffset), Random.Range(lowestPoint, highestOffset), 0), transform.rotation);
    }
}
