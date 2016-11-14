using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{

	public InputField input;
	public Text output;

	private PlayerManager _currentPlayer;

	public PlayerManager CurrentPlayer {
		get { return _currentPlayer; }
		set { _currentPlayer = value; }
	}

	public void Send ()
	{
		CurrentPlayer.Send (input.text);
	}
}
