using UnityEngine;
using UnityEngine.Events;

public class SceneTransitionScript : MonoBehaviour
{
    #region Attributes and Properties

    public UnityEvent Activated;
    public UnityEvent Deactivated;

    #endregion

    #region Private Fields

    private Animator _animator;
    private Camera _camera;

    #endregion

    #region MonoBehaviour Methods

    public void Awake()
    {
        _animator = GetComponent<Animator>();
        
        Canvas canvas = GetComponent<Canvas>();
        _camera = canvas.worldCamera;
    }

    public void Update()
    {
        transform.localPosition = _camera.transform.position;
        transform.rotation = _camera.transform.rotation;
        transform.Translate(Vector3.forward * _camera.nearClipPlane * 2, Space.Self);
        transform.localScale = Vector3.one * 2f;
    }

    #endregion

    #region Private Methods

    private void OnActivated()
    {
        Activated.Invoke();
    }

    private void OnDectivated()
    {
        Deactivated.Invoke();
    }

    #endregion

    #region Public Methods

    public void Activate()
    {
        _animator.SetBool("Scene Active", true);

        if (!_animator.isActiveAndEnabled)
            _animator.enabled = true;
    }

    public void Deactivate()
    {
        _animator.SetBool("Scene Active", false);

        if (!_animator.isActiveAndEnabled)
            _animator.enabled = true;
    }

    #endregion
}