using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update() {
        if (Input.GetKeyDown(KeyCode.D)) {
            Debug.Log("Нажали D");
        }
        if (Input.GetKey(KeyCode.D)) {
            Debug.Log("Зажали D");
        }
        if (Input.GetKeyUp(KeyCode.D)) {
            Debug.Log("Отжали D");
        }
    }
}
