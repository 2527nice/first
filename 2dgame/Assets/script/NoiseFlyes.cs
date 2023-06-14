using UnityEngine;

public class NoiseFlyes : MonoBehaviour
{
    [SerializeField] private float NoiseFlySpeed = 5f;

    private void Update()
    {
        transform.position -= new Vector3(NoiseFlySpeed * Time.deltaTime, 0, 0);
    }
}
