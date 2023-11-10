using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Atletas : MonoBehaviour
{


    private float _rapidez = 1;
    public float rapidez{
        get { return _rapidez; }
            
             set
        {
            if (value > 5)
            {
                value = 5;
            }
            else if (value < 1) 
            {
                value = 1;
            }
         
       }

    }
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
