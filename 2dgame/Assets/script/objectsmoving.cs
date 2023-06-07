using UnityEngine;

public class ObjectsMoving : MonoBehaviour
{
    [SerializeField] private float TemplateSpeed = 5f;

    private void Update()
    {
        transform.position -= new Vector3(TemplateSpeed * Time.deltaTime, 0, 0);
    }
}
