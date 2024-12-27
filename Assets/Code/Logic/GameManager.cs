using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject playerObj;

    private void Awake() {
        // playerObj.GetComponent<PlayerStats>().loadPlayerStats();


        // Instantiate(playerObj, new Vector3(-9.69f,-1.95f,0), Quaternion.identity);

        Instantiate(playerObj, new Vector3(-9.69f,-1.95f,0), Quaternion.identity).GetComponent<PlayerStats>().loadPlayerStats();
    }
}
