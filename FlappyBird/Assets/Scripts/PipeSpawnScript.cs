using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject _pipe;
    public float _spawnRate = 2;
    public float _heightOffset = 10;
    public float _widthOffset = 2;

    private float _timer = 0;
    
    void Start()
    {
        SpawnPipe();
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

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - _heightOffset;
        float highestOffset = transform.position.y + _heightOffset;
        float leftMostPoint = transform.position.x - _widthOffset;
        float rightMostOffset = transform.position.x + _widthOffset;

        Instantiate(_pipe, new Vector3(Random.Range(leftMostPoint, rightMostOffset), Random.Range(lowestPoint, highestOffset), 0), transform.rotation);
    }
}
