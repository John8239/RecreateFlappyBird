using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript _logic;

    void Start()
    {
        _logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Bird Layer"))
        {
            _logic.AddScore();
        }
    }
}
