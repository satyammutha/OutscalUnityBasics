using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneScript : MonoBehaviour
{
    public Button button;
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
            button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        int intSaveSceneNo = SceneManager.GetActiveScene().buildIndex;
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - intSaveSceneNo);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + scene);
        }

    }

    // Update is called once per frame
    private void Update()
    {

    }
}
