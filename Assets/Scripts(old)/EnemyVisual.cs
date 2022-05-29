using UnityEngine;
using DG.Tweening;

public class EnemyVisual : MonoBehaviour
{
    /// <summary> ���f����Renderer </summary>
    [SerializeField]
    private Renderer _renderer;

    private Sequence _seq;

    private void OnTriggerEnter(Collider other)
    {
        HitBlink();
    }

    /// <summary> �_�łɂ��_���[�W���o�Đ� </summary>
    private void HitBlink()
    {
        _seq?.Kill();
        _seq = DOTween.Sequence();
        _seq.AppendCallback(() => _renderer.enabled = false);
        _seq.AppendInterval(0.07f);
        _seq.AppendCallback(() => _renderer.enabled = true);
        _seq.AppendInterval(0.07f);
        _seq.SetLoops(2);
        _seq.Play();
    }
}
