using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D _rigidBody2D;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody2D.linearVelocity = Vector2.up * 10;
        }
    }
}
