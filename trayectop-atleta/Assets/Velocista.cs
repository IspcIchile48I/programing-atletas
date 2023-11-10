using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Velocista : Atletas
{

    public override void velocidad() 
    {
        rapidez = 2;
        float teclas = Input.GetAxis("Vertical");
        rbvelocista.AddForce(Vector3.right * rapidez * teclas, ForceMode.Impulse);
    }
    


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            estaenelsuelo = true;

        }
    }
    // Start is called before the first frame update
    void Start()
    {

        rbvelocista = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        velocidad();
        salto();
        


    }
}
