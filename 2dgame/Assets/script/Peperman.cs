using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Peperman : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField] private GameObject DeathScreen;

    [SerializeField] private float jumpVelocity = 20;

    [Header("Player UI Settings")]

    [SerializeField] private GameObject PlayerUI;

    

    private Animator animation; 
    
    private Rigidbody2D rigidbody;

    private bool jump = false;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        Time.timeScale = 1f;
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.Space) && jump == false)
        {
            rigidbody.velocity = new Vector3(0, jumpVelocity, 0);
            animation.SetBool("Jump", true);
            jump = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "LocationTemplate")
        {
            animation.SetBool("Jump", false);
            jump = false;
        }
        if(other.gameObject.tag == "Obstacle")
        {
            DeathScreen.SetActive(true);
            Time.timeScale = 0f;
            PlayerUI.SetActive(false);
        }
    }
}
