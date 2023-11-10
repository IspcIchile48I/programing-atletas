using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Globalization;

public class Atletas : MonoBehaviour
{
    public TMP_InputField alo;
    public void Valorrapidez()
    {
        int i = int.Parse(alo.text);
        Rapidez = i;
       
    }
    protected bool estaenelsuelo = true;
    protected Rigidbody rbvelocista;
    
   private int _Rapidez=1;

    public int Rapidez { get { return _Rapidez; }set { _Rapidez = value; } }

    public virtual void velocidad()
    {
        
        float teclas = Input.GetAxis("Vertical");
        rbvelocista.AddForce(Vector3.right * Rapidez * teclas, ForceMode.Impulse);

    }
    public virtual void salto()
    {
        float podersalto = 5;
        if (Input.GetKeyDown(KeyCode.Space) && estaenelsuelo)
        {
            rbvelocista.AddForce(Vector3.up * podersalto, ForceMode.Impulse);
            estaenelsuelo = false;
        }

    }
    public int caso = 2;
    






}
