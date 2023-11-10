using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoAlto : Atletas
{
    
    public override void salto()
    {
        float podersalto = 200;
        if (Input.GetKeyDown(KeyCode.Space) && estaenelsuelo)
        {
            rbvelocista.AddForce(Vector3.up * podersalto, ForceMode.Impulse);
            estaenelsuelo = false;
        }
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
    private void Update()
    {
        velocidad();
        salto();
    }
}
