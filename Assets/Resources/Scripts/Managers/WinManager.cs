using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class WinManager : Singleton<WinManager> {

    [SerializeField]
    private Sprite Player1Panel;
    [SerializeField]
    private Sprite Player2Panel;
    [SerializeField]
    private GameObject Canvas;
    [SerializeField]
    private Camera m_camera;
    [SerializeField]
    private Image Panel;

    protected WinManager()
    {

    }

    void Awake()
    {

    }

    public void Win(int player)
    {
        Debug.Log(Panel);
        Panel.sprite = (player == 1) ? Player1Panel : Player2Panel;

        XInput.instance.StopVibration();
        Ui_Manager.Instance.gameObject.SetActive(false);
        Canvas.SetActive(false);
        Panel.gameObject.SetActive(true);
        m_camera.enabled = true;
        DOTween.KillAll();
        m_camera.transform.LookAt(Panel.transform);
        m_camera.transform.parent.DORotate(new Vector3(0, 180, 0), 15f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        Panel.transform.DORotate(new Vector3(0, 180, 0), 15f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        //Panel.transform.DOMoveY(2, 2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }
}
