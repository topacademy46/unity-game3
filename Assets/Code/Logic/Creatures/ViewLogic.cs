using System.Diagnostics;
using UnityEngine;

public class ViewLogic : MonoBehaviour
{
    // [SerializeField] private Transform orcTransform;
    [SerializeField] private GameObject orcObj;
    private HealthComponent healthComponent;
    [SerializeField] private float speed;

    private void Start() {
        orcObj = GetComponentInParent<GameObject>();
    }
   private void OnTriggerEnter2D(Collider2D collider) {
    healthComponent = collider.GetComponent<HealthComponent>();
   }

   private void OnTriggerStay2D(Collider2D collider) {
        if (healthComponent != null) {
            orcObj.transform.position = Vector3.Lerp(orcObj.transform.position, collider.transform.position, speed * Time.deltaTime);
        }
   }
}
