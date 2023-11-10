using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Atletas : MonoBehaviour
{
    
     
    protected bool estaenelsuelo = true;
    protected Rigidbody rbvelocista;

    public virtual void velocidad() {
        float speed = 1;
        float teclas = Input.GetAxis("Vertical");
        rbvelocista.AddForce(Vector3.right * speed * teclas, ForceMode.Impulse);
    }
    public virtual void salto() {
        float podersalto = 200;
        if (Input.GetKeyDown(KeyCode.Space) && estaenelsuelo)
        {
            rbvelocista.AddForce(Vector3.up * podersalto, ForceMode.Impulse);
            estaenelsuelo = false;
        }
    }
        

}
