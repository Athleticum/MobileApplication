using System;
using System.Collections.Generic;
using System.Text;

namespace Athleticum
{
    public class ApplicationState
    {
        private static ApplicationState _instance;

        private ApplicationState() { }

        public static ApplicationState Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApplicationState();
                }
                return _instance;
            }
        }
    }
}
