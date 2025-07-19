using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float _moveSpeed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * _moveSpeed) * Time.deltaTime;
    }
}
