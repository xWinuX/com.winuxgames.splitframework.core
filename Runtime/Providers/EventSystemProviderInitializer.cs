using UnityEngine;
using UnityEngine.EventSystems;

namespace WinuXGames.SplitFramework.Core.Providers
{
    public class EventSystemProviderInitializer : MonoBehaviour
    {
        [SerializeField] private EventSystem            _eventSystem;
        [SerializeField] private SO_EventSystemProvider _eventSystemProvider;

        private void Awake() { _eventSystemProvider.AssignEventSystem(_eventSystem); }
    }
}