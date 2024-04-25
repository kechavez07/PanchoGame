using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjeto : MonoBehaviour
{

    public float tiempoMax = 2;
    private float tiempoInicial = 0;
    public GameObject obstacle;

    void Update()
    {
        if (tiempoInicial > tiempoMax)
        {
            GameObject obstaculoNuevo = Instantiate(obstacle);
            obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
    }

	
}
