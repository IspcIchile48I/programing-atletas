using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Globalization;
using UnityEditor.Experimental.GraphView;

public class Atletas : MonoBehaviour
{
    
    protected bool estaenelsuelo = true;
    protected Rigidbody rbvelocista;
    
   private int _Rapidez=1;

    public int Rapidez { get { return _Rapidez; }
        set { if (value > 5) { _Rapidez = 5; }
            else if(value<1){ _Rapidez = 1; }
            else 
                _Rapidez = value; }
    }// ENCAPSULATION

    public virtual void velocidad()
    {
        
        float teclas = Input.GetAxis("Vertical");
        rbvelocista.AddForce(Vector3.right * Rapidez * teclas, ForceMode.Impulse);

    }
    public virtual void salto()
    {
        float podersalto = 40;
        if (Input.GetKeyDown(KeyCode.Space) && estaenelsuelo)
        {
            rbvelocista.AddForce(Vector3.up * podersalto, ForceMode.Impulse);
            estaenelsuelo = false;
        }

    }
    
    






}
