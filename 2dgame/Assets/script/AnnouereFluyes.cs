using UnityEngine;

public class AnnouereFluyes : MonoBehaviour
{
    [SerializeField] private float AnnouereFluyesspeed = 5f;

    private void Update()
    {
        transform.position -= new Vector3(AnnouereFluyesspeed * Time.deltaTime, 0, 0);
    }
}
