using System.Net.Sockets;
using UnityEngine;

public class background : MonoBehaviour
{
    public float speed = 3f;
    private float width;

    void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
        Debug.Log(width);
    }
    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);

        if (transform.position.x < -width)
        {
            transform.position+= Vector3.right*width*2f;
        } 

    }
}
