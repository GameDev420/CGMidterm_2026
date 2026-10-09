using UnityEngine;
using UnityEngine.InputSystem;

public class CameraPivot : MonoBehaviour
{
    [SerializeField] Vector2 sensitivity = Vector2.one;
    [SerializeField] Transform pivot;

    Vector2 delta;
    public void MouseDelta(InputAction.CallbackContext ctx)
    {
        delta += ctx.ReadValue<Vector2>();
    }

    private void Update()
    {
        pivot.Rotate(new Vector3(0.0f, delta.x, 0.0f) * sensitivity, Space.World);
        delta = Vector2.zero;
    }
}
