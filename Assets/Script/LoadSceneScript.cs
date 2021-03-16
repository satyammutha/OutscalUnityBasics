using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneScript : MonoBehaviour
{
    public Button button;
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
            button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        SceneManager.LoadScene(scene);
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
