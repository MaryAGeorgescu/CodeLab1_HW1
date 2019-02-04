using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay1 : MonoBehaviour
{
    public GameObject Player1; //this is to bring the player 1 game object into this class
    public PlayerController script; //this makes the player controller accessible
    public Text Score1; //this is text game object
    
    private int _score1; //this is a score variable 
    
    private void Start()
    {
        script = Player1.GetComponent<PlayerController>(); 
        //this grabs the player controller script where we wrote the score
    }

    // Update is called once per frame
    void Update()
    {
        Score1.text = script.score.ToString(); 
        //you're accessing the score which is in script and script is what we wrote above
        //then you're converting it into a string because score is an int
        // if its a number you have to convert into a string in order for it to be displayable
    }
}
