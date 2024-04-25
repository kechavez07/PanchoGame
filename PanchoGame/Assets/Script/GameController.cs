using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private void Awake()
    {
        //para no tener varios objetos con distintos datos
        if (GameController.instance == null)
        {
            GameController.instance = this;
        }
        else
        {
            //para que se destruya ya que guarda algo q ya tenemos
            if (GameController.instance != this)
            {
                Destroy(gameObject);
                Debug.LogWarning("GameController HA SIDO INSTANCIANDO POR SEGUNDA VEZ. ESTO NO DEBERIA PASAR.");
            }
        }
    }

    //cuando un objeto se destruye OnDestroy SEGUNDA ESCENA O M�S ESCENAS

    public void OnDestroy()
    {
        if (GameController.instance == this)
        {
            GameController.instance = null;
        }
    }

    public GameObject GameOverText;
    public bool gameOver;
    public float scrollSpeed = -1.5f;
    private int puntos;
    public Text puntosText;

    public void BirdScored()
    {
        if (gameOver) return;
        puntos++;
        puntosText.text = "Puntos: " + puntos;
        SoundSystem.instance.PlayCoin();
    }

    public void BirdDie()
    {
        GameOverText.SetActive(true);
        gameOver = true;
    }

    public void actualizarPuntos()
    {
        if ( GameController.instance == null)
        {
            return;
        }

        if(puntos == 30)
        {
            BirdDie();
        }
        else
        {
			puntos++;
			puntosText.text = "Puntos: " + puntos;
			SoundSystem.instance.PlayCoin();
		}

    }
}
