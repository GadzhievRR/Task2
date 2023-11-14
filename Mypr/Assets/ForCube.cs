using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    public float speed = 10f;
    public Text x;
    public int cout = 6;
    public GameObject cylindr;
    public GameObject button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * speed * Time.deltaTime);
        }


        if (cout <= 0)
        {
            this.gameObject.SetActive(false);
            x.text="Game over";
        }
        else
        {
            x.text = cout.ToString();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.black;
        cout--;
    }

    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnCollisionStay(Collision collision)
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {

    }

    public void health()
    {
        cout = 5;
    }
}
