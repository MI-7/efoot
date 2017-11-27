using FOE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOE
{
    public static class GlobalSettings
    {
        private static Doctor LoggedInDoctor = null;
        private static Patient CurrentPatient = null;

        public static void SetCurrentPatient(Patient p)
        {
            CurrentPatient = p;
        }

        public static void SetLoggedInDoctor(Doctor d)
        {
            LoggedInDoctor = d;
        }

        public static Patient GetCurrentPatient()
        {
            return CurrentPatient;
        }

        public static Doctor GetLoggedInDoctor()
        {
            return LoggedInDoctor;
        }

        public static void ClearGlobalSettings ()
        {
            LoggedInDoctor = null;
            CurrentPatient = null;
        }
    }
}
