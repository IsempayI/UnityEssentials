using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 120.0f;
    public float jumpForce = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        if (Input.GetButtonDown("Jump")) rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
    }
    
    private void FixedUpdate()
    {
        var moveVertical = Input.GetAxis("Vertical");
        var movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
        
        var turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        var turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}