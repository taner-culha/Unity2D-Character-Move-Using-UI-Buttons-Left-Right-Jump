using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;
    public Rigidbody2D rb;
    private float dirTurn;
    void Start()
    {
        dirTurn = 1;
    }
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime * 2;
    }
    public void LeftPos()
    {
        speed = -1;
        transform.eulerAngles = new Vector3(0, 180, 0);
    }
    public void RightPos()
    {
        speed = 1;
        transform.eulerAngles = new Vector3(0, 0, 0);
    }
    public void JumpPos()
    {
        if (rb.velocity.y == 0)
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }
    public void StopPos()
    {
        speed = 0;
        dirTurn = 0;
    }
}
