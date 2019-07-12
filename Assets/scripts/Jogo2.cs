using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogo2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text resposta;
    public Text msg;
    public int acertos;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void acerto(){
        acertos = acertos + 1;
        if(acertos > 2){
            msg.text = "Parabénss!!";
        }
        else{
            resposta.text = "✔";
        }
    }
    
    public void errado(){
        resposta.text = "X";
    }

    public void reload(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo2");

    }

    public void voltar(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogos");

    }
}

