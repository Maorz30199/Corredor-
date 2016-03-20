using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {

    public Transform personaje;
    public float separacion = 8f;

	void Update ()
    {
        transform.position = new Vector3(personaje.position.x+separacion, transform.position.y, transform.position.z);
	}
}
