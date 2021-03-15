using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * @Monica Ly 
 * Transitions between interstage scene to playable level 
 */
public class NextScene : MonoBehaviour
{
    // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager-activeSceneChanged.html 

    public void Start()
    {

        // wait 4s 
        StartCoroutine(MoveNextScene());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator MoveNextScene()
    {
        yield return new WaitForSeconds(4.0f);
        print(Time.time + " seconds");
        ChangeScene();
    }


    void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }

}

