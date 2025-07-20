using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float _flapStrength = 12;
    public bool _isAlive = true;
    public Rigidbody2D _rigidBody2D;
    public LogicScript _logic;

    void Start()
    {
        _logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isAlive)
        {
            _rigidBody2D.linearVelocity = Vector2.up * _flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _logic.GameOver();
        _isAlive = false;
    }
}
