using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public float moveSpeed = 5f;
    public Rigidbody rb;

    

    // void Update()
    // {
    //     float moveHorizontal = Input.GetAxis("Horizontal");
    //     float moveVertical = Input.GetAxis("Vertical");

    //     Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
    //     transform.Translate(movement * speed * Time.deltaTime, Space.World);

    //     if (movement != Vector3.zero)
    //     {
    //         Quaternion targetRotation = Quaternion.LookRotation(movement);
    //         transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);
    //     }
    // }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }


}
