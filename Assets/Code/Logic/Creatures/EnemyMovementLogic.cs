using UnityEngine;

public class EnemyMovementLogic : MonoBehaviour
{
    [SerializeField] private EnemyViewLogic enemyViewLogic;
    [SerializeField] private InputService inputService;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;

    private void Start()
    {
        enemyViewLogic = GetComponentInChildren<EnemyViewLogic>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (enemyViewLogic.getTargetFound())
        {
            if (inputService != null)
            {
                rb.linearVelocity = new Vector2(moveSpeed * inputService.getViewDirection() * -1, rb.linearVelocityY);
                // 1. Проверка дошел ли юнит
                // 2. Найти направления взгляда героя
                // 3. Применить физику по x в противоположную сторону.

                // 1. Идти в позицию персонажа по X
                // 
                // Vector2.Distance();
                // Mathf.Abs() 
                // Vector2.Lerp();


                // Рассмотреть переход на другие сцены и загрузку объектов
            }
            else
            {
                inputService = enemyViewLogic.getTargetObj().GetComponent<InputService>();
            }
        }
    }
}
