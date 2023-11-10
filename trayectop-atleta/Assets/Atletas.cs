using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Atletas : MonoBehaviour
{

    
    
    public float rapidez{
        get { return rapidez; }
            
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
        rapidez = 1;
        float teclas = Input.GetAxis("Vertical");
        rbvelocista.AddForce(Vector3.right * rapidez * teclas,ForceMode.Impulse);
    }
    public virtual void salto() {
        float podersalto = 1;
        if (Input.GetKeyDown(KeyCode.Space) && estaenelsuelo)
        {
            rbvelocista.AddForce(Vector3.up * podersalto, ForceMode.Impulse);
            estaenelsuelo = false;
        }
    }
        

}
