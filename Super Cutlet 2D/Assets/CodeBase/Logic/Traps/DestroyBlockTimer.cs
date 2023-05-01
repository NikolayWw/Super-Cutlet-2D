using CodeBase.Services.Factory;
using UnityEngine;

namespace CodeBase.Logic.Traps
{
    public class DestroyBlockTimer : MonoBehaviour
    {
        [SerializeField] private float _seconds;
        [SerializeField] private TriggeredPlayer _triggered;
        private IGameFactory _gameFactory;

        public void Construct(IGameFactory gameFactory)
        {
            _gameFactory = gameFactory;
            _triggered.OnTriggeredEnter += StartDestroyTimer;
        }

        private void StartDestroyTimer()
        {
            _triggered.OnTriggeredEnter -= StartDestroyTimer;
            Invoke(nameof(Timer), _seconds);
        }

        private void Timer()
        {
            _gameFactory.CreateFx(transform.position);
            Destroy(gameObject);
        }
    }
}