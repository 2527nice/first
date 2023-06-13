using UnityEngine;

public class snickruns : MonoBehaviour
{
    [SerializeField] private float SnickSpeed = 5f;

    private void Update()
    {
        transform.position -= new Vector3(SnickSpeed * Time.deltaTime, 0, 0);
    }
}
