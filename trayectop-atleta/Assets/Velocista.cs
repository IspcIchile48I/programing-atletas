using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Velocista : Atletas // INHERITANCE
{
    public TMP_InputField alo;
    public void Valorrapidez()
    {
        int i = int.Parse(alo.text);
        Rapidez = i;

    }

    public override void velocidad() {
        
       float teclas = Input.GetAxis("Vertical");
       rbvelocista.AddForce(Vector3.right * Rapidez*2 * teclas, ForceMode.Impulse);

    }// POLYMORPHISM





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
    salto();// ABSTRACTION
    }
}
