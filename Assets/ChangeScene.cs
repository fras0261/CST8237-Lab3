using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Select the scene that will be loaded
    public void ChangeSceneWithName(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}
