using UnityEngine;

public class EdgeCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) {
        Destroy(collider.gameObject);
    }
}
