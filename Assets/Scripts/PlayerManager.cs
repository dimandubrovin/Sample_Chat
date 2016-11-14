using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PlayerManager : NetworkBehaviour
{

	GameManager _gameManager;

	public void Start ()
	{
		_gameManager = FindObjectOfType<GameManager> ();

		if (isLocalPlayer)
			_gameManager.CurrentPlayer = this;
	}

	public void Send (string message)
	{
		CmdSend (Network.player.guid, message);
	}

	[Command]
	public void CmdSend (string id, string message)
	{
		RpcSend (id, message);
	}

	[ClientRpc]
	public void RpcSend (string id, string message)
	{
		_gameManager.output.text += id + ": " + message + System.Environment.NewLine;
	}
}
