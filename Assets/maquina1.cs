using UnityEngine;

public class maquina1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    char[] valores = new char[] { 'A', 'B', 'C', 'D' };

    char rodillo1;
    char rodillo2;
    char rodillo3;

    public bool boton = false;

    public int saldo = 1000;

    void Start()
    {
        print("puedes jugar pulsando el boton booleano.");
    }

    // Update is called once per frame
    void Update()
    {
        if (boton)
        {
            //llamada de funcion tirada;
            tiraRodillos();
            boton = false;
        }



    }


    void tiraRodillos()
    {
        if (saldo < 10)
        {


            print("No tienes saldo.");

            return;
        }

        saldo = saldo - 10;

        

        rodillo1 = valores[Random.Range(0, valores.Length - 1)];
        rodillo2 = valores[Random.Range(0, valores.Length - 1)];
        rodillo3 = valores[Random.Range(0, valores.Length - 1)];


        print(rodillo1 + "," + rodillo2 + "," + rodillo3);

        if (rodillo1==rodillo2 && rodillo1==rodillo3)
        {

            print("Premio!!, ganaste: " + (saldo * 0.9) + " €");
            print("Su saldo es: " + saldo+ " €");
        }
        else
        {
            print("no tuviste suerte.. Saldo disponible: " + saldo + " €");
        }
    }

}

