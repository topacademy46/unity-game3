using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string scene;

    void OnTriggerStay2D(Collider2D collider) {
        if (collider.name == "Mage" && Input.GetKeyDown(KeyCode.F)) {
            collider.GetComponent<PlayerStats>().savePlayerStats();
            SceneManager.LoadScene(scene);
        }
    }
}
