using UnityEngine;
using UnityEngine.UI;

public class FPSScript : MonoBehaviour
{
    #region Attributes and Properties

    public float UpdateInterval;

    #endregion

    #region Private Fields

    private Text _fpsLabel;
    private float _accum = 0f;
    private int _frames = 0;
    private float _timeleft;

    #endregion

    #region MonoBehaviour Methods

    public void Start () 
    {
        _fpsLabel = GetComponent<Text>();
	}

    public void Update()
    {
        _timeleft -= Time.deltaTime;
        _accum += Time.timeScale / Time.deltaTime;
        _frames++;

        if (_timeleft <= 0f)
        {
            _fpsLabel.text = "FPS - " + (_accum / _frames).ToString("f2");
            _timeleft = UpdateInterval;
            _accum = 0f;
            _frames = 0;
        }
    }

    #endregion
}


