using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuPrincipal : MonoBehaviour
{

    public InputField name;
    public Text msg;
    
    
    public void verification(){
        if (name.text  == ""){
        msg.text = "O NOME NÃO PODE SER VAZIO!";
    }
        else{
            UserData.userNome = name.text;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Jogos");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

        
   
}
