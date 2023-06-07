using UnityEngine;

public class BackGrounMoving : MonoBehaviour
{
    [SerializeField] private float BackGroundSpeed = 5f;

    private void Update()
    {
        transform.position -= new Vector3 (BackGroundSpeed * Time.deltaTime, 0, 0);
    }
}
