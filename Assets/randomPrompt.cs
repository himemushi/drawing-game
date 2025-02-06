using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randomPrompt : MonoBehaviour
{
    public string[] manyprompts = { "Moonlight", "Spiderlily", "Flower", "Harelquin", "Batman", "Summer", "Coffee", "Strawberry", "Platypus", "Diner", "Funeral", "Pizza", "Penguin", "Jellyfish", "Ribbon", "Touhou", "Sword and Shield", "Inferno" };
    public string[] hello = { "help", "me" };
   // private readonly List<string> words = new List<string>();
    public TMP_Text textpls;

    // Start is called before the first frame update
    void Start()
    {
        //Log whatever comes out of the RandomWord string
        string wordToDisplay = RandomWord();

        textpls.text = wordToDisplay;
   
    }

    // when you see a string function, it will return a string that you can use anywhere

    private string RandomWord()
    {
        //grab a randoms tring from the words array
        string randomWord = manyprompts[Random.Range(0, manyprompts.Length)];

        //return it (this will be the string that the script will use)
        return randomWord;
    }

   

  /* public string GetRandomPrompt()
    {
        //Gets a random number between 0 and number of strings in the array
       int random = Random.Range(0, manyprompts.Length);
        *//*int random = Random.Range(0, hello.Length);
        return hello[random];*//*
        //Returns the index random from the string array
       return manyprompts[random];
    } */
  

    // Update is called once per frame
    void Update()
    {
        /*textpls.text = hello.GetRandomPrompt().ToString();*/
      // textpls.text = manyprompts.GetRandomPrompt().ToString();
       // textpls.text = manyprompts.ToString().GetRandomPrompt();
    }
}
