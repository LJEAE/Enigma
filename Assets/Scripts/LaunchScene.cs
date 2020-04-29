using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchScene : MonoBehaviour
{
	public string SceneName;
    private GameObject button;
    private GameObject headPanel;

    public void NextScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}