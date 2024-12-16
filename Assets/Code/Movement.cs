using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update() {
        FlipX();
        Move();
    }

    private void Move() {
        if (Input.GetKey(KeyCode.D)) {
            transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }

    
    private void FlipX() {
        if (Input.GetKey(KeyCode.D)) {
            spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.A)) {
            spriteRenderer.flipX = true;
        }
    }
}
