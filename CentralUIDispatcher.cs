using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicMute
{
    static class CentralUIDispatcher
    {
        private delegate void Action();
        private static Action _toggleMuteAction;
        private static MainForm _mainForm;

        static public void RegisterMainWindow(MainForm mainForm)
        {
            _mainForm = mainForm;
            _toggleMuteAction = new Action(_mainForm.ToggleMicStatus);
        }

        static public void ToggleMuteButton()
        {
            if (_mainForm != null)
                _mainForm.Invoke(_toggleMuteAction);
        }
    }
}
