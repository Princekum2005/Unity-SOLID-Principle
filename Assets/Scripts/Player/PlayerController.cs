using UnityEngine;

public class PlayerController : MonoBehaviour, IMovable, ICollidable
{
    private IInputHandler _inputHandler;
    [SerializeField] private float speed;
    [SerializeField] private float minX, maxX;

    void Start()
    {
        _inputHandler = new KeyboardInput();
    }

    void Update()
    {
        Move(_inputHandler.GetInput());
    }

    public void Move(Vector2 direction)
    {
        Vector3 newPosition = transform.position + (Vector3)(direction * speed * Time.deltaTime);
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        transform.position = newPosition;
    }

    public void OnCollide()
    {
        GameManager.Instance.GameOver();
    }
}
