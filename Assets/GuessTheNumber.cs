using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuessTheNumber : MonoBehaviour {

	public InputField input;
	public Text infoText;

	private int guessnumber;
	private int userguess;

	// Use this for initialization
	void Start () {
		guessnumber = Random.Range (0, 100);
	}

	public void checkGuess () {
		userguess = int.Parse (input.text);

		if (userguess == guessnumber) {
			infoText.text = "You Guessed The Number! You are a Wizard!!!";

			StartCoroutine (wait ());

			SceneManager.LoadScene(Scene0);

		} else if (userguess > guessnumber) {
			infoText.text = "Your Number Is Greater Than The Guess Number";
		} else {
			infoText.text = "Your Number Is Less Than The Guess Number";
		}

		input.text = "";
	}

	IEnumerator wait () {
		yield return new WaitForSeconds (3);
	}

}