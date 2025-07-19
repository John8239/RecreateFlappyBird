using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D _rigidBody2D;
    public float _flapStrength = 12;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody2D.linearVelocity = Vector2.up * _flapStrength;
        }
    }
}
