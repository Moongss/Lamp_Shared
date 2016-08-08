using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Button : MonoBehaviour {

    public int SceneNum;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnClick() {
        SceneManager.LoadScene(SceneNum);
    }
}
