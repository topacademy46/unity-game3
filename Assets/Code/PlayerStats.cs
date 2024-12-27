using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] private HealthComponent healthComponent;

    private void Awake() {
        healthComponent = GetComponent<HealthComponent>();
    }

   public void savePlayerStats() {
        PlayerPrefs.SetFloat("Health", healthComponent.getCurrentHealth());
   }

   public void loadPlayerStats() {
        healthComponent.setCurrentHealth(PlayerPrefs.GetFloat("Health"));
   }
}
