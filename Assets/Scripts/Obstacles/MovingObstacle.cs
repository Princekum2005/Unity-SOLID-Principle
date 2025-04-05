using UnityEngine;

public class MovingObstacle : Obstacle
{
    [SerializeField] private float horizontalSpeed = 1.5f;
    
    public override void Move(Vector2 direction)
    {
        base.Move(direction);
        transform.Translate(Vector2.right * Mathf.Sin(Time.time * horizontalSpeed) * Time.deltaTime);
    }
}
