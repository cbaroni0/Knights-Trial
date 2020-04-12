using UnityEngine;
using UnityEngine.Events;

public class HeroController : MonoBehaviour
{


    public float maxWalkSpeed;
    public float jumpSpeed;
    private bool direction_right = true;

    private Vector3 playerVelocity;
    private Rigidbody2D rigidBody;

    void Start()
    {
        playerVelocity = Vector3.zero;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerVelocity.x = Input.GetAxis("Horizontal") * maxWalkSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerVelocity.y = jumpSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction_right = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

        }
        else
        {
            playerVelocity.y = rigidBody.velocity.y;
        }

        rigidBody.velocity = playerVelocity;
    }
}