using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour {

	public Image UIImagen;
    public Image UIImagen1;
    public Image UIImagen2;
    public Image UIImagen3;
    public Image UIImagen4;
    public int puntosGanados = 2;

	void Start () 
	{
		UIImagen = GameObject.Find("Image").GetComponent<Image>();
        UIImagen1 = GameObject.Find("Image1").GetComponent<Image>();
        UIImagen2 = GameObject.Find("Image2").GetComponent<Image>();
        UIImagen3 = GameObject.Find("Image3").GetComponent<Image>();
        UIImagen4 = GameObject.Find("Image4").GetComponent<Image>();
    }

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D collider)
	{
        NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
		Destroy (gameObject);
        //Debug.Log(puntosGanados);
		if(Puntuacion.puntuacion == 4)
        {
            UIImagen.sprite = Resources.Load<Sprite> ("Sprites/1Templo");
			UIImagen.color = new Color (255, 255, 255, 255);
        }
        else if (Puntuacion.puntuacion == 8)
        {
            Debug.Log(puntosGanados);
            UIImagen1.sprite = Resources.Load<Sprite>("Sprites/2Templo");
            UIImagen1.color = new Color(255, 255, 255, 255);
        }
        else if (Puntuacion.puntuacion == 10)
        {
            Debug.Log("bn");
            UIImagen2.sprite = Resources.Load<Sprite>("Sprites/3Templo");
            UIImagen2.color = new Color(255, 255, 255, 255);
        }
        else if (Puntuacion.puntuacion == 12)
        {
            Debug.Log("mbn");
            UIImagen3.sprite = Resources.Load<Sprite>("Sprites/4Templo");
            UIImagen3.color = new Color(255, 255, 255, 255);
        }
        else if (Puntuacion.puntuacion == 14)
        {
            Debug.Log("lmbn");
            UIImagen4.sprite = Resources.Load<Sprite>("Sprites/5Templo");
            UIImagen4.color = new Color(255, 255, 255, 255);
        }
        else if (Puntuacion.puntuacion == 20)
        {
            SceneManager.LoadScene("GanoRunner2");
        }
    }
}
