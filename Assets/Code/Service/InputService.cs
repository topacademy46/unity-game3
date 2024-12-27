using UnityEngine;

public class InputService : MonoBehaviour
{
    private float horizontalDirection;
    [SerializeField] private float viewDirection = 1f;


    public float getHorizontalDirection() {
        horizontalDirection = 0;
        
        if (Input.GetKey(KeyCode.D)) {
            horizontalDirection = 1f;
            viewDirection = 1f;
        }
        if (Input.GetKey(KeyCode.A)) {
            horizontalDirection = -1f;
            viewDirection = -1f;
        }
        return horizontalDirection;
    }

    public float getViewDirection() {
        return viewDirection;
    }
}
