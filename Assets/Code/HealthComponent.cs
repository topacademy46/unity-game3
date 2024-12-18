using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private float regenRate;



    private void Update() {
        Regen();
    }

    public void Regen() {
      currentHealth += regenRate * Time.deltaTime;
        if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
    }
}
