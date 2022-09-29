using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bergerak : MonoBehaviour
{
    public Rigidbody rb;
    // public Rigidbody rb;
    public float jumpAmount = 3;
    public float forwadForce = 2000f;
    public float sidewaysForce = 500f;

    Rigidbody cek;
    BoxCollider box;

    // Start is called before the first frame update
    // void Start()
    // {

    // }
    // Update is called once per frame
 
    void FixedUpdate()
    {

        Loncat();
        rb.AddForce(0, 0, forwadForce * Time.deltaTime); // digunakan supaya player bisa berjalan

        if (Input.GetKey("d")) // jika tombol d ditekan maka player akan ke kanan
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // Debug.Log(Time.deltaTime);
        }
        if (Input.GetKey("a")) // jika tombol d ditekan maka player akan ke kanans
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            // yje.position.y = -3000;
            FindObjectOfType<GameManager>().EndGame();
        }


    }

    void Loncat()
    {
        cek = GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            // Debug.Log(box.center);
        }
    }
}
