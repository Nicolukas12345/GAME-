<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
	[SerializeField] GameObject pauseMenu;
	
	public void Pause ()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 2f;
	}
	
	public void Resume()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
	}


=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
	[SerializeField] GameObject pauseMenu;
	
	public void Pause ()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 2f;
	}
	
	public void Resume()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
	}


>>>>>>> 6732494b11c04c4578800bdecd10b86da48108a0
}