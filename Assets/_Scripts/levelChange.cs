using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour
{
    public Animator transition;
    public float Time = 0f;
    public string transname;
    private bool start = false;
    private bool go = false;

	public void OnTriggerEnter(Collider other) {
		loadNextLevel();
	}

    void Update() {
        Scene S = SceneManager.GetActiveScene();
        if (S.name == "Menu - Credits") {
            StartCoroutine(reset());

            IEnumerator reset() {
                yield return new WaitForSeconds(78);
                SceneManager.LoadScene("Menu - Main");
            }
        }
        
        if(start != true && S.name == "Menu - Main") {
            //StartCoroutine(bgload());
            start = true;
            IEnumerator bgload() {
                AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Level - 1 The cave");
                asyncOperation.allowSceneActivation = false;
                if(go) {
                    yield return new WaitForSeconds(2);
                    asyncOperation.allowSceneActivation = true;
                }
            }
        }
    }

    public void loadNextLevel() {
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator loadLevel(int levelIndex) {
        transition.SetTrigger(transname);
        yield return new WaitForSeconds(Time);
        SceneManager.LoadScene(levelIndex);
    }
}
