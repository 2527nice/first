using UnityEngine;

public class solidersrunning : MonoBehaviour
{
    [SerializeField] private float soliderSpeed = 5f;

    private void Update()
    {
        transform.position -= new Vector3(soliderSpeed * Time.deltaTime, 0, 0);
    }
}
