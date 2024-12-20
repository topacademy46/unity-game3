using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject fireBall;

    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1)) {
            Instantiate(fireBall, transform.position, Quaternion.identity);
        }
    }
}
