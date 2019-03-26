using System.Collections.Generic;
using System.Linq;

namespace com.praim.altTab
{
    public class WindowFinder
    {
        public List<AppWindow> GetWindows()
        {
            return AppWindow.AllToplevelWindows
                .Where(a => a.IsAltTabWindow())
                .ToList();
        }
    }
}