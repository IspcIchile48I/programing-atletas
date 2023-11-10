using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Velocista : Atletas
{
    
   public override void velocidad() {
        
       float teclas = Input.GetAxis("Vertical");
       rbvelocista.AddForce(Vector3.right * Rapidez*2 * teclas, ForceMode.Impulse);

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
