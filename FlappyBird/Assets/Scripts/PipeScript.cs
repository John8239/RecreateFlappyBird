using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float _moveSpeed = 5;
    public float _deleteCoordinate = -45;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * _moveSpeed) * Time.deltaTime;

        if (transform.position.x < _deleteCoordinate)
        {
            Destroy(gameObject);
        }
    }
}
