using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject player1;
    public float speed = .01f;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    public int countObstacle = 0;

    //public Text scoreText;

    //public AudioSource collectionSound;
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        float v = Input.GetAxisRaw("Vertical");

        // Vector3 direction = new Vector3(h, 0, v);
        //
        // transform.position += direction * speed;
        Vector3 direction = new Vector3(h, 0, v).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity,
                turnSmoothTime);


            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            transform.position += direction * speed;
            //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            //{
              //  player1.GetComponent<Animator>().Play("walkingWhite");
            //}
            //rb = GetComponent<Rigidbody>();
            //rb.velocity = transform.forward * speed;
            //player.Move(moveDir.normalized * speed * Time.deltaTime);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WhiteSphere"))
        {
            Destroy(other.gameObject);
            //collectionSound.Play();
            countObstacle += 1;

            //scoreText.text = countObstacle.ToString("0");

        }
        /*
        if (countObstacle == 5)
        {
            SceneManager.LoadScene(2);
        }*/

    }
}
