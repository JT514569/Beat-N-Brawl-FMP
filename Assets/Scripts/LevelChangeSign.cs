using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChangeSign : MonoBehaviour
{
    public Animator transition;

    public IEnumerator LoadLevel(string sceneName)
    {
        transition.SetTrigger("End");

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);
    }
}