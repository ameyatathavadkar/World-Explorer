using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime=1f;
    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(0))
        {
            LoadLevel();
        }
    }

    private void LoadLevel()
    {
        StartCoroutine(LoadNextLevel("PerlinNoise")); 
    }

    public IEnumerator LoadNextLevel(String SceneName)
    {
        //play transition animation
        transition.SetTrigger("Start");
        //wait for animation to finish
        yield return new WaitForSeconds(transitionTime);
        
        //load next scene
        SceneManager.LoadScene(SceneName);
    }
}
