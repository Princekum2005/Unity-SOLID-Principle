using UnityEngine;

public class Obstacle : MonoBehaviour, IMovable
{
    protected float speed = 3f;

    public virtual void Move(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void Update()
    {
        Move(Vector2.down);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<ICollidable>()?.OnCollide();
        }
    }
}
