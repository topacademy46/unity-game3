using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private float timeToDestroy;
    [SerializeField] private float speed;


    void Update()
    {
        timeToDestroy -= Time.deltaTime;
        if (timeToDestroy <= 0) {
            Destroy(gameObject);
        }

        transform.position = new Vector2(transform.position.x + Time.deltaTime * speed, transform.position.y);
    }
}
