using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject.ObjClasses
{
    /// <summary>
    /// CurrentMember class keeps track of who the currently
    /// logged-in member is. Accessible through public get
    /// and set methods.
    /// </summary>
    public static class CurrentMember
    {
        private static Member Current { get; set; }

        public static Member GetCurrentMember()
        {
            return Current;
        }

        public static void SetCurrentMember(Member member)
        {
            Current = member;
        }
    }
}
