using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange, chaos;
    private bool isGameOver = false;
    private float elapsedTime = 0;
	private bool isRunning = false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isGameOver = false;
	}
    // Update is called once per frame
    void Update()
    {
          //If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;
    }
    public void FinishedGame()
	{
		isRunning = false;
		isGameOver = true;
	}
    void OnGUI()
    {
        string message;
        if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}

        if(isGameOver)
        {
            Rect rect = new Rect (Screen.width / 2 -100, Screen.height / 2 - 50, 200, 75);
            GUI.Box (rect, "Game Over");
            Rect rect2 = new Rect (Screen.width / 2 -30, Screen.height / 2 - 25, 60, 50);
            GUI.Label (rect2, "Good Job!");
            message = "Click or Press Enter to Play Again";
        }
        else
			{
				message = "Click or Press Enter to Play";
			}

        if(!isRunning)
		{
			

			if(isGameOver)
			{
				message = "Click or Press Enter to Play Again";
			}
			else
			{
				message = "Click or Press Enter to Play";
			}

			//Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/2, 240, 30);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
				//start the game if the user clicks to play
				StartGame ();
			}
		}
		
		// If the player finished the game, show the final time
		if(isGameOver)
		{
            
		}
		else if(isRunning)
		{ 
			// If the game is running, show the current time
			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
		}
    }
}
