using UnityEngine;
using System.Collections;

public class TutorialSceneScript : MonoBehaviour
{
    #region Attributes and Properties

    public SceneTransitionScript Transition;

    #endregion

    #region MonoBehaviour Methods

    public void Start()
    {
        Transition.Activate();
    }

    #endregion

    #region Public Methods

    public void LoadNextScene()
    {
        Debug.Log("Crazy ass fuck");
        //Application.LoadLevel("3 - Living Room Scene");
    }

    #endregion
}
