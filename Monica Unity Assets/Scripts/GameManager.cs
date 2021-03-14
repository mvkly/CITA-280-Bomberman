using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int stage = 0;

    public GameObject buttonGameObject; 
    // Start is called before the first frame update
    void Start()
    {
        Button buttonComponent = buttonGameObject.GetComponent<Button>();
            buttonComponent.onClick.AddListener(OnQuitPressed);
            // call method when button is pressed 
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnStartClicked()
    {
        stage += 1;
        Debug.Log("Starting");
    }

    private void OnQuitPressed()
    {
        Debug.Log("Quit Pressed");
        Application.Quit(); // to quit, does not work in editor, only in building
    }

    public void updateScene()
    {
        // if stage changes, go to stage transition 

        // stage transition lasts specific amount of time (music duration)

        // after stage transition + music, proceed to new level
        SceneManager.LoadScene(stage);
    }
}
