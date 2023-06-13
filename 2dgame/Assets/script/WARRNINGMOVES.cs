
using UnityEngine;

public class WARRNINGMOVES : MonoBehaviour
{
    [SerializeField] private float WARRNINGSpeed = 5f;

    private void Update()
    {
        transform.position -= new Vector3(WARRNINGSpeed * Time.deltaTime, 0, 0);
    }
}
