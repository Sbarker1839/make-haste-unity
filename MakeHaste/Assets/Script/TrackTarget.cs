using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TrackTarget : MonoBehaviour {
    [SerializeField] Transform target;//The Transform of the player
	[SerializeField] GameObject graveyard;
	[SerializeField] GameObject plank;
	[SerializeField] GameObject pyramid;
	[SerializeField] GameObject maze1;
    [SerializeField] GameObject rotatingTomb;
	[SerializeField] GameObject movingPlatforms;
    [SerializeField] private Text timer;
    [SerializeField] private Text winStatus;

    private int randomObstacle = 0;
    private float WIN_CONDITION = 100.0f;//Distance for the win condition
    private float LOOSE_CONDITION = 3f;//Distance for the loose condition
    private float SPEED = 7f;//The speed of the ghost


    private float startTime;
    public Text timerText;
    public Text statusText;
    bool keepTiming;
    public static string endTime = "0:0:0";
	// Use this for initialization
	void Start () {

        keepTiming = true;
        startTime = Time.time;

		GameObject[] obstacles = new GameObject[6];
		obstacles [0] = graveyard;
		obstacles [1] = pyramid; 
		obstacles [2] = plank;
		obstacles [3] = maze1;
        obstacles [4] = rotatingTomb;
		obstacles [5] = movingPlatforms;


		for (float i = 30; i < 1000; i = i + 20) {
			randomObstacle = (int) Random.Range (0, 6);
			GameObject selectedObstacle = obstacles [randomObstacle];
			switch (randomObstacle) {
			case 0:
				Instantiate (selectedObstacle, new Vector3 (i, 2.25f, 0.1f),Quaternion.Euler(0,0,0));
				break;
			case 1: 
				Instantiate(selectedObstacle, new Vector3(i,1.0f,0f), Quaternion.Euler(0,0,0));
				break;
			case 2:
				Instantiate (selectedObstacle, new Vector3 (i, 4.25f, 3.8f),Quaternion.Euler(0,0,0));
				break;
			case 3: 
				Instantiate (selectedObstacle, new Vector3 (i, .5f, -2.52f),Quaternion.Euler(0,0,0));
				break;
            case 4:
                Instantiate(selectedObstacle, new Vector3(i, 4.5f, -1.11f), Quaternion.Euler(0, 0, 0));
                break;
			case 5:
				Instantiate (selectedObstacle, new Vector3 (i, 3.7f, -.0399f),Quaternion.Euler(0,0,0));
				break;
			default:
				break;
			}

				

		}
        //Obstacle generation and Timer UI can be implemented here
	}
	
	// Update is called once per frame
	void Update () {
        
        string minutes = "";
        string seconds = "";

        if (keepTiming == true)
        {
            float t = Time.time - startTime;
            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("f2");
            endTime = minutes + ":" + seconds;
            timerText.text = endTime;
        }
        else
        {
            timerText.text = endTime;
        }
        

        float step = SPEED * Time.deltaTime;//Step ghost takes at each frame

        if (Vector3.Distance(transform.position, target.position) > WIN_CONDITION)
        {
            keepTiming = false;
            
            statusText.text = "You Win!!";
            SceneManager.LoadScene("WinScreen");
        }
        else if (Vector3.Distance(transform.position, target.position) > LOOSE_CONDITION)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            //If the win condition or lose condition aren't taken, apply step
        }
        else
        {
            keepTiming = false;
            
            statusText.text = "You Lose!";
            SceneManager.LoadScene("LoseScreen");
        }
	}
}
