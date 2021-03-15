using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // managing scenes
using TMPro;

/*
 * @Monica Ly
 * Generates and displays current stage that the player is on
 * Keeps track of the total amount of scenes and the current stage
 * * Determines which scenes are transitional scenes 
 * Changes scene from title screen to transition scene
 * Quits game on clicking quit
 */

public class NewGameManager : MonoBehaviour
{
    // ==== VARIABLES ====
    // ---- TRANSITIONS (SCENES) ----
    public int stage = 0; // init stage counter, counting the actual LEVEL that the player is on
    public static int sceneCounter = 0; // init scene counter, different amount from stages

    // **can use stage as the var to determine if game is over. if stage is updated & stage > maxStage for example
    // public Text stageText; // declare text variable
    public TMP_Text stageTextTMP;

    // ---- UI ----
    // public float secondsLeftInStage;
    // add lives, score




    // private IEnumerator coroutine; // https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html


    // Start is called before the first frame update
    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {

        // scene 0 = title, scene 1 = transition after start, scene 2 = level 1, scene 3 = transition
        // % 2 = 0 for e scenes, excluding main menu scene
        // if (sceneCounter % 2 == 0 && sceneCounter != 0)

        // SceneManager.activeSceneChanged += ChangedActiveScene;
        // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager-activeSceneChanged.html
        // https://docs.unity3d.com/ScriptReference/SceneManagement.Scene-name.html

        if (sceneCounter % 2 == 1) // odd number for transition scenes
        {
            // StartCoroutine(TimeChangedScene());
            DisplayTransitionScene();
            Debug.Log("Transition scene");
            // StartCoroutine(TimeChangedScene());
            // TimeChangedScene();

        }

    }


    /* IEnumerator TimeChangedScene()
     {
         print(Time.time + " seconds");
         yield return new WaitForSeconds(4.0f);
         sceneCount += 1;
         UpdateScene();
     }*/

    public void OnStartClicked() // when START button on menu is clicked
    {
        stage += 1; // increment
        sceneCounter += 1; // 1st scene (transition)
        Debug.Log("Starting...");
        UpdateScene(); // call sceneupdater
    }

    public void OnQuitPressed()
    {
        // doesn't show as an option in button drop down for On Click () with private, declared public instead
        Debug.Log("Quitting...");
        // https://docs.unity3d.com/ScriptReference/Application.Quit.html
        Application.Quit(); // to quit, does not work in editor, only in building
    }

    private void UpdateScene()
    {
        // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html

        // after stage transition + its music, proceed to new level
        SceneManager.LoadScene(sceneCounter); // load scene
    }

    public void DisplayTransitionScene()
    {

        // transitTimer = 0.0f; // reset timer for new scene


        // if stage changes, go to stage transition 
        // stage transition shows the following: 
        // ("Stage: " + stage)
        // stageText.text = "Stage: " + stage; // can't change to custom Press Start 2P front with regular text, using TMP instead


        stageTextTMP.text = "Stage: " + stage;


        Debug.Log("Loading scene...");
        Debug.Log("Scene: " + sceneCounter + "DisplayTransitScene");
        // *stage transition lasts specific amount of time (music duration)

        // music(02_Stage Start) = 4s 
        // https://downloads.khinsider.com/game-soundtracks/album/bomberman-nes

        // StartCoroutine(TimeChangedScene());

        /*  if (transitTimer > transitDuration) // boolean not working
               {
                   Debug.Log("Transit Timer" + transitTimer);
                   sceneCounter += 1; // increment scene to change to next scene
                   UpdateScene(); // call function to transition


               }*/

    }

}
