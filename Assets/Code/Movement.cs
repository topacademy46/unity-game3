using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private InputService inputService;
    private Rigidbody2D rb;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        inputService = GetComponent<InputService>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        FlipX();
        UpdateAnimator();
    }

    private void FixedUpdate() {
        Move();
    }

    private void Move() {
        if (inputService.getHorizontalDirection() > 0) {
            // rb.AddForce(new Vector2(moveSpeed, 0), ForceMode2D.Impulse);
            rb.linearVelocityX += moveSpeed;
        }
        if (inputService.getHorizontalDirection() < 0) { 
            rb.linearVelocityX -= moveSpeed;
            // rb.AddForce(new Vector2(moveSpeed * -1, 0), ForceMode2D.Impulse);
        }
    }

    private void FlipX() {
        if (inputService.getHorizontalDirection() > 0) {
            spriteRenderer.flipX = false;
        }
        if (inputService.getHorizontalDirection() < 0) {
            spriteRenderer.flipX = true;
        }
    }

    private void UpdateAnimator() {
        animator.SetFloat("Speed", Mathf.Abs(inputService.getHorizontalDirection()));
    }
}
