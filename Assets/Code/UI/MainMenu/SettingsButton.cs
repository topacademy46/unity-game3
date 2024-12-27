using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    [SerializeField] private GameObject menuButtons;
    [SerializeField] private GameObject settingsMenu;


    public void showSettingsMenu() {
        menuButtons.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
