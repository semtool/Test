using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class HealthScale : MonoBehaviour
{
    [SerializeField] public Slider _barScale;
    [SerializeField] public Health _health;

    private float _barVolueMultiplier = 0.01f;
<<<<<<< Updated upstream
=======
    private int _maxHealthInPercent = 100;
>>>>>>> Stashed changes

    private void Start()
    {
        _barScale.value = GetCurrentBarVolue();
    }

    private void OnEnable()
    {
        _health.CurrentHealthChanged += ChangeBarView;
    }

    private void OnDisable()
    {
        _health.CurrentHealthChanged -= ChangeBarView;
    }

    public abstract void ChangeBarView();

    public float GetCurrentBarVolue()
    {
<<<<<<< Updated upstream
        return _health.CurrentHealth * _barVolueMultiplier;
=======
        return CalkulateDataForBar() * _barVolueMultiplier;
    }

    private float CalkulateDataForBar()
    {
        return  _health.CurrentHealth * _maxHealthInPercent / _health.MaxHealth;
>>>>>>> Stashed changes
    }
}