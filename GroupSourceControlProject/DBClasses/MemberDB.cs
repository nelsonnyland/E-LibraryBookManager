using GroupSourceControlProject.ObjClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    /// <summary>
    /// The MemberDB class communicates with the database and
    /// handles current logged-in member as well as registration
    /// log-in and some Member class methods.
    /// </summary>
    public static class MemberDB
    {
        /// <summary>
        /// Returns all members in the database.
        /// </summary>
        /// <returns></returns>
        public static List<Member> GetAllMembers()
        {
            LibraryContext context = new LibraryContext();

            List<Member> allMembers =
                (from m in context.Members
                 select m).ToList();

            return allMembers;
        }

        /// <summary>
        /// Checks if the member passed in matches just 
        /// username of a member in the database. 
        /// If so, returns true, false otherwise.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>bool verification result</returns>
        public static bool IsMember(Member member)
        {
            List<Member> allMembers = GetAllMembers();

            foreach (Member item in allMembers)
            {
                if (item.Username == member.Username)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the member passed in matches both the 
        /// username and PIN of a member in the database. 
        /// If so, the user is logged-in.
        /// </summary>
        /// <param name="member"></param>
        public static bool Validate(Member member)
        {
            List<Member> allMembers = GetAllMembers();

            foreach (Member item in allMembers)
            {
                if ((item.Username == member.Username) 
                    && (item.PIN == member.PIN))
                {
                    LogIn(member);
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Adds a member to the database.
        /// </summary>
        /// <param name="member"></param>
        public static bool Register(Member member)
        {
            LibraryContext context = new LibraryContext();

            context.Members.Add(member);

            context.SaveChanges();

            return IsMember(member);
        }

        /// <summary>
        /// Sets the current member logged-in to the website.
        /// </summary>
        /// <param name="member"></param>
        private static void LogIn(Member member)
        {
            CurrentMember.SetCurrentMember(member);
        }
    }
}
