using UnityEngine;

public class noisesctes : MonoBehaviour
{
    [SerializeField] private float NoiseSpeed = -5f;

    private void Update()
    {
        transform.position -= new Vector3(NoiseSpeed * Time.deltaTime, 0, 0);
    }
}
