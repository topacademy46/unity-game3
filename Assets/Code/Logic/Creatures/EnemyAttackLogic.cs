using UnityEngine;

public class EnemyAttackLogic : MonoBehaviour
{
    private HealthComponent healthComponent;

    void OnTriggerEnter2D(Collider2D collider) {
        if (!collider.CompareTag("Enemy")) {
            healthComponent = collider.GetComponent<HealthComponent>();
            if (healthComponent != null) {
                healthComponent.takeDamage(10);
            }
        }
    }
}
