using UnityEngine;
using System.Collections;

public enum State
{
	MainMenu,
	InGame,
	Paused,
	Won,
	Lost
}

public class Controller : MonoBehaviour {

	private State _gameState = State.MainMenu;

	// Use this for initialization
	void Start () {
	
	}

	/// <summary>
	/// Update this instance.
	/// Update is called once per frame
	/// </summary>
	void Update () {

		switch (_gameState) 
		{
			case State.InGame :
				break;
			case State.Lost :
				break;
			case State.MainMenu :
				break;
			case State.Paused :
				break;
			case State.Won :
				break;
			default:
				break;
		}
	}

	/// <summary>
	/// Changes the state. Executes any actions required before switching to new state.
	/// </summary>
	/// <param name="newState">New state.</param>
	public void ChangeState(State newState)
	{
		switch (newState) 
		{
			case State.InGame :
				break;
			case State.Lost :
				break;
			case State.MainMenu :
				break;
			case State.Paused :
				break;
			case State.Won :
				break;
			default:
				break;
		}

		_gameState = newState;
	}
}
