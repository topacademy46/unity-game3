using UnityEngine;

public class EnemyViewLogic : MonoBehaviour
{
    [SerializeField] private bool targetFound = false;
    [SerializeField] private GameObject targetObj;
    [SerializeField] private HealthComponent targetHealthComponent;


    private void Update()
    {
        if (targetHealthComponent.getCurrentHealth() <= 0 && targetHealthComponent != null)
        {
            targetFound = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Ally"))
        {
            if (collider.GetComponent<HealthComponent>().getCurrentHealth() > 0)
            {
                targetObj = collider.gameObject;
                targetHealthComponent = targetObj.GetComponent<HealthComponent>();
                targetFound = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject == targetObj)
        {
            targetFound = false;
        }
    }

    public GameObject getTargetObj() { return targetObj; }
    public bool getTargetFound() { return targetFound; }
}
