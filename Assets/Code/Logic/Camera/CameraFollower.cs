using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    [SerializeField] private float smooth;

    private void LateUpdate() {
        transform.position = Vector3.Lerp(transform.position, new Vector3(targetTransform.position.x + offsetX, targetTransform.position.y + offsetY, transform.position.z), smooth * Time.deltaTime);
    }
}
