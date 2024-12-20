using UnityEngine;

public class InputService : MonoBehaviour
{
    private float horizontalDirection;


    public float getHorizontalDirection() {
        horizontalDirection = 0;
        
        if (Input.GetKey(KeyCode.D)) {
            horizontalDirection = 1f;
        }
        if (Input.GetKey(KeyCode.A)) {
            horizontalDirection = -1f;
        }
        return horizontalDirection;
    }
}
