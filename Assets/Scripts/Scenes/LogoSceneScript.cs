using UnityEngine;

public class LogoSceneScript : MonoBehaviour
{
    #region Attributes and Properties

    public SceneTransitionScript Transition;    

    #endregion

    #region MonoBehaviour Methods

    public void Start ()
    {
        Transition.Activate();
	}

    #endregion

    #region Public Methods

    public void LoadNextScene()
    {
        Application.LoadLevel("2 - Tutorial Scene");
    }

    #endregion
}
