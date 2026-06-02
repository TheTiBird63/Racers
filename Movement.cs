using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public Rigidbody2D p_1, p_2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        p_1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.D) ) 
        {

            p_1.linearVelocity = new Vector2(speed,0f);
        
        }
    }
}
