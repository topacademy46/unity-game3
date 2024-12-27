using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private float regenRate;



    private void Update() {
        regen();
    }

    public float getCurrentHealth() {
        return currentHealth;
    }

    public void setCurrentHealth(float value) {
        currentHealth = value;
    }

    public void regen() {
      currentHealth += regenRate * Time.deltaTime;
        if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
    }

    public void takeDamage(float damage) {
        currentHealth -= damage;
    }
}
