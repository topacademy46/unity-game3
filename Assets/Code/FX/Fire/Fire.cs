using UnityEngine;

public class Fire : MonoBehaviour
{
    private HealthComponent healthComponent;
    [SerializeField] private float fireDamage;
    private Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D collider) {
        rb = collider.GetComponent<Rigidbody2D>();
        if (rb != null) {
            rb.sleepMode = RigidbodySleepMode2D.NeverSleep;
        }
        healthComponent = collider.GetComponent<HealthComponent>();
    }

    void OnTriggerStay2D() {
        if (healthComponent != null) {
            healthComponent.takeDamage(fireDamage * Time.deltaTime);
        }
    }

    void OnTriggerExit2D() {
        if (rb != null) {
            rb.sleepMode = RigidbodySleepMode2D.StartAwake;
        }
    }
}
