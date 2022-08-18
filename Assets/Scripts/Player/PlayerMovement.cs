using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed = 3.2f;
    public float Jump = 10.5f;
    public float Radus = 0.2f;
    public Transform GroundCheck;
    public LayerMask layerMask;
    float X_axis;
    float Y_axis;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        X_axis = transform.position.x;
        Y_axis = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        bool jump = Input.GetButton("Jump");

        rb.velocity = new Vector2(horizontal * Speed, rb.velocity.y);

        Collider2D[] ground = Physics2D.OverlapCircleAll(GroundCheck.position, Radus, layerMask);

        GroundCheck.position = new Vector3(transform.position.x + 0, transform.position.y + -0.5f);

        if (jump == true && ground.Length > 0)
            rb.velocity = new Vector2(0, Jump);

        if (transform.position.y < -7)
            transform.position = new Vector3(X_axis, Y_axis);
    }

    private void OnDrawGizmosSelected()
    {
        if (GroundCheck == null)
            return;

        Gizmos.DrawWireSphere(GroundCheck.position, Radus);
    }
}