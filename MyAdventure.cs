using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    Hier worden de states weergegeven van waar de speler zich bevind
    private enum States
   {
        start,
        intro,
        delen,
        delennee,
        delenja,
        leukgesprek
    }

    private States currentstate = States.start;
        
    // Start is called before the first frame update
    void Start()
    {
        print(message: "Hello World");
    }
    void ShowMainMenu ()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal");
        Terminal.WriteLine("Typ start om te beginnen");
    }

    void OnUserInput (string input)
    {
        if (currentstate == States.start)

        else if (input == "1337")
            if (input == "start")
            {
                StartIntro();

            }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Get was een koude donkere nacht");
        Terminal.WriteLine("Een goede nacht om Fortnite te spelen");
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}

