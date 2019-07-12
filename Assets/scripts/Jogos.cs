using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogos : MonoBehaviour
{
    public Text msg;    
    // Start is called before the first frame update
    void Start()
    {
        msg.text = "Bem vindo " + UserData.userNome+"!";
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jogo1(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo1");
    }

    public void jogo2(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo2");

    }
}
