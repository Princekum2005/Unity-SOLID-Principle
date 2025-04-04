using UnityEngine;

public class KeyboardInput : IInputHandler
{
    public Vector2 GetInput()
    {
        return new Vector2(Input.GetAxis("Horizontal"), 0);
    }
}
