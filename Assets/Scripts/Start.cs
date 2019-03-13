using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Starting : MonoBehaviour
{
    void Start()
    {
      //Button btn = Start.GetComponent<Button>();
      //btn.onClick.AddListener(TaskOnClick);

    }

    void Update() {

    }

    void TaskOnClick()
    {
      //Debug.Log("You have clicked the button!");
      // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
      //SceneManager.LoadScene("Bar", LoadSceneMode.Additive);
    }
}
