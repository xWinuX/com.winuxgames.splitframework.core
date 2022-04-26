using UnityEngine;
using UnityEngine.EventSystems;

namespace WinuXGames.SplitFramework.Core.Providers
{
    [CreateAssetMenu(menuName = "Split Framework/Providers/EventSystem", fileName = "EventSystemProvider", order = 0)]
    public class SO_EventSystemProvider : SO_ScriptableProvider
    {
        public EventSystem EventSystem { get; private set; }

        public void AssignEventSystem(EventSystem eventSystem) { EventSystem = eventSystem; }

        protected override void ResetValues() { EventSystem = null; }
    }
}