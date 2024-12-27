using UnityEngine;

public class SettingsReturn : MonoBehaviour
{
    [SerializeField] private GameObject menuButtons;
    [SerializeField] private GameObject settingsMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            settingsMenu.SetActive(false);
            menuButtons.SetActive(true);
        }
    }
}
