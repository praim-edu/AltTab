using System.Collections.Generic;
using System.Linq;

namespace com.praim.altTab
{
    class AltTab
    {
        List<AppWindow> allWindows;
        int index;
        public AltTab()
        {
            allWindows = new WindowFinder().GetWindows();
            index = 1;
        }

        public void nextWindow()
        {
            if (allWindows == null || index >= allWindows.Count)
            {
                allWindows = new WindowFinder().GetWindows();
                allWindows.Reverse();
                index = 0;
            }

            if (!allWindows.ElementAt(index).IsClosed)
            {
                allWindows.ElementAt(index).SwitchToLastVisibleActivePopup();
                index++;
            }
            else
            {
                index++;
                nextWindow();
            }
        }
    }
}
