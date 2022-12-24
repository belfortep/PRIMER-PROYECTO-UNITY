using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    //public ScoreManager scoreManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameObject scripter = GameObject.Find("Scripter");//busca en la escena el objeto scripter
        //scripter.GetComponent<ScoreManager>().RaiseScore(1);//del scripter, busco el componente del script y llamo a su funcion
        //pero es mas facil con una referencia publica y listo?, bueno no, solo si el objeto ya estaba en la escena
        //no me sirve este caso
        //scoreManager.RaiseScore(1);
        //como es estatico, puedo entrar asi
        ScoreManager.scoreManager.RaiseScore(1);

        //gameObject.SetActive(false); aca desactivamos simplemente el objecto
        Destroy(transform.parent.gameObject); //aca destruimos directamente el objeto
    }
}
