using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class download : MonoBehaviour   {

    public void OpenURL() {
          Application.OpenURL("https://bit.ly/3atsNJh");
          Debug.Log("Download the link");
    }
}
