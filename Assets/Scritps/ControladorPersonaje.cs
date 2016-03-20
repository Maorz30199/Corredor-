using UnityEngine;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {

    public float fuerzaSalto = 30f;

    private bool enSuelo = true;
    public Transform comprobadorSuelo;
    float comprobadorRadio = 0.07f;
    public LayerMask mascaraSuelo;

    private bool dobleSalto = false;

    private Animator animator;

    private bool corriendo = false;

    private float velocidad = 5f;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

void FixedUpdate()
    {
        if(corriendo)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
        }

        animator.SetFloat("VelX", GetComponent<Rigidbody2D>().velocity.x);
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
        animator.SetBool("isGrounded", enSuelo);
        if(enSuelo)
        {
            
            dobleSalto = false;

        }
    }

    void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (corriendo)
            {
                if (enSuelo || !dobleSalto)
            {

                GetComponent<Rigidbody2D>().velocity = new Vector2(0, fuerzaSalto);
                if (!dobleSalto && !enSuelo)
                {

                    dobleSalto = true;
                }
            }
        }       
            else
            {
                corriendo = true;
            }
        }
    }

}
