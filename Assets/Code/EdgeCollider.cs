using UnityEngine;

public class EdgeCollider : MonoBehaviour
{
    private HealthComponent healthComponent;

    void OnTriggerEnter2D(Collider2D collider) {
        collider.GetComponent<Rigidbody2D>().sleepMode = RigidbodySleepMode2D.NeverSleep;
        healthComponent = collider.GetComponent<HealthComponent>();
        if (healthComponent != null) {
            healthComponent.Regen();
        }
        // Destroy(collider.gameObject);
    }
    // void OnTriggerStay2D() {
        
    // } 
    void OnTriggerExit2D(Collider2D collider) {
        collider.GetComponent<Rigidbody2D>().sleepMode = RigidbodySleepMode2D.StartAwake;
    }
}
