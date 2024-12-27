using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private InputService inputService;
    private Rigidbody2D rb;

    [SerializeField] private Vector2 direction;

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
        rb.linearVelocity = new Vector2(moveSpeed * inputService.getHorizontalDirection(), rb.linearVelocityY);
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
