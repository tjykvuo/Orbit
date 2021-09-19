using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOneSceneOnClick : MonoBehaviour {

 public void LoadByIndex(int sceneIndex)
 {
      SceneManager.LoadScene(sceneIndex);
 }

}


