using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vida;
    public float maximoVida;
    public GameObject gameOver;
    private Move player;

    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;   
        player = GetComponent<Move>();
    }



    public void TomarVida(float dano)
    {        
        //AudioManager.Instance.PlaySFX("hit");
        vida = vida - dano;        
        Debug.Log("vida: " + vida);
        if(vida <= 0){            
            gameOver.SetActive(true);
            AudioManager.Instance.musicSource.Stop();
            //AudioManager.Instance.PlaySFX("gameover");
            Destroy(gameObject);
        }
    }

}
