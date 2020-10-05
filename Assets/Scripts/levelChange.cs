using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour
{
    public Animator transition;
    public float Time = 1f;
    public string transname;

    public void loadNextLevel() {
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator loadLevel(int levelIndex) {
        transition.SetTrigger(transname);
        yield return new WaitForSeconds(Time);
        SceneManager.LoadScene(levelIndex);
    }
}
