using UnityEditor.Callbacks;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public float speedX = 10f;
    public float speedY = 10f;
    Rigidbody2D rb;
    public float minX = -7.4f;
    public float maxX = 7.4f;
    public float minY = -4.44f;
    public float maxY = 4f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(x*speedX,y*speedY);

        Vector2 pos = rb.position;
        pos.x = Mathf.Clamp(pos.x,minX,maxX);
        pos.y = Mathf.Clamp(pos.y,minY,maxY);
        rb.position = pos;
    }
}
