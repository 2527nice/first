using UnityEngine;

public class objectsmoving : MonoBehaviour
{
    [SerializeField] private float speed = 4.5f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.right * speed);
    }
}
