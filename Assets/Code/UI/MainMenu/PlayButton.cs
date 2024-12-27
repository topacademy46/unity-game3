using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour
{
    public void play() {
        SceneManager.LoadScene("World");
    }
}
