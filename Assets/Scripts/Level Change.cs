using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu_Transition : MonoBehaviour
{
    public Animator transition;
    public float Time = 1f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            loadNextLevel();
        }
    }

    public void loadNextLevel() {
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator loadLevel(int levelIndex) {
        transition.SetTrigger("BigDoor - Open");
        yield return new WaitForSeconds(Time);
        SceneManager.LoadScene(levelIndex);
    }

}
