using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 3f;
    
    public void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);
        if(transform.position.x< -8.5f)
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");
        }
    }
}
