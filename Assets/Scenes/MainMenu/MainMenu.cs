using Games.Shared.Util;
using Games.Shared.Util.Menu;
using TMPro;
using UnityEngine.UI;

namespace Scenes.MainMenu
{
    [AutoAssignable]
    public class MainMenu: AnimatedMenu
    {
        public Button Play;
        public Button Credits;
        public Button Exit;
        public TextMeshProUGUI VersionText;
    }
}