using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogo1 : MonoBehaviour
{       
        public string text;
        public string palavra_embaralhada;
        public int numero = 0;

        public Text palavra;




    //gambiarra de variaveis
        public Text letra1;
        public Text letra2;
        public Text letra3;
        public Text letra4;
        public Text letra5;


    string[] palavras = new string[2];
    string[] letra = new string[4];
    // Start is called before the first frame update
    void Start()
    {


        //criando o dicionario
        palavras[0] = "IFSUL";
        palavras[1] = "CARRO";

        //sorteando um numero para o dicionario
        // numero = Random.Range(0, 2);

        char[] array = palavras[numero].ToCharArray();
        System.Random rng = new System.Random();
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = array[k];
            array[k] = array[n];
            array[n] = value;
        }

        palavra_embaralhada = new string(array);
        
        letra1.text = palavra_embaralhada[0].ToString();
        letra2.text = palavra_embaralhada[1].ToString();
        letra3.text = palavra_embaralhada[2].ToString();
        letra4.text = palavra_embaralhada[3].ToString();
        letra5.text = palavra_embaralhada[4].ToString();



        palavra.text = "I      F      S      U     L";

            
            // else if(numero == 1){
            //     palavra.text = "C     A     R     R    O";

            // }


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown (KeyCode.R)){
        
        
    }

    }

    public void Restart(){
        char[] array = palavras[numero].ToCharArray();
        System.Random rng = new System.Random();
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = array[k];
            array[k] = array[n];
            array[n] = value;
        }

        palavra_embaralhada = new string(array);

        letra1.text = palavra_embaralhada[0].ToString();
        letra2.text = palavra_embaralhada[1].ToString();
        letra3.text = palavra_embaralhada[2].ToString();
        letra4.text = palavra_embaralhada[3].ToString();
        letra5.text = palavra_embaralhada[4].ToString();

    }

    

    public void TrocarPalavra(){
        if(numero >= 1){
            palavra.text = "I      F      S      U     L";
            numero = 0;

            char[] array = palavras[numero].ToCharArray();
            System.Random rng = new System.Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }

            palavra_embaralhada = new string(array);

            letra1.text = palavra_embaralhada[0].ToString();
            letra2.text = palavra_embaralhada[1].ToString();
            letra3.text = palavra_embaralhada[2].ToString();
            letra4.text = palavra_embaralhada[3].ToString();
            letra5.text = palavra_embaralhada[4].ToString();
        }
        else{
        numero = numero + 1;

        char[] array = palavras[numero].ToCharArray();
        System.Random rng = new System.Random();
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = array[k];
            array[k] = array[n];
            array[n] = value;
        }

        palavra_embaralhada = new string(array);

        letra1.text = palavra_embaralhada[0].ToString();
        letra2.text = palavra_embaralhada[1].ToString();
        letra3.text = palavra_embaralhada[2].ToString();
        letra4.text = palavra_embaralhada[3].ToString();
        letra5.text = palavra_embaralhada[4].ToString();

        if(numero == 1){
            palavra.text = "C     A     R     R    O";
        }
    }
        
    }

    public void Voltar(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogos");

    }
    
    
    
}
