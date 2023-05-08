using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
	private void Awake()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void GotoMainScene()
	{
		SceneManager.LoadScene("Playground");
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
