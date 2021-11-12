using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyPlayButton : MonoBehaviour
{
    public void Playbutton()
      {
          SceneManager.LoadScene("SampleScene");
      }
  
}
