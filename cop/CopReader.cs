using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cop
{
    /// <summary>
    /// Class used to read the COP from disk.
    /// </summary>
    class CopReader
    {
        #region Constructors

        /// <summary>
        /// Default constructor for CopReader
        /// </summary>
        public CopReader()
            : this(null)
        {
        }

        /// <summary>
        /// Constructor taking an XDocument as an argument
        /// </summary>
        /// <param name="cop">XDocument representing the COP</param>
        public CopReader(XDocument cop)
        {
            _cop = cop ?? XDocument.Load(@"C:\Repos\cop\cop\Resources\cop.xml");
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Retrieve a skill from the COP
        /// </summary>
        /// <param name="name">Name of the skill</param>
        /// <param name="evt">Event the skill is on</param>
        /// <returns>The data of the skill from the COP</returns>
        public Skill GetSkill(string name, string evt)
        {
            var query = from s in _cop.Descendants("Skill")
                        where s.Parent.Parent.Element("Name").Value.ToLower().Equals(evt.ToLower())
                        && s.Element("Name").Value.ToLower().Equals(name.ToLower())
                        select s;

            var skill = new Skill()
            {
                Name = query.First().Element("Name").Value,
                Value = double.Parse(query.First().Element("Value").Value),
                ElementGroup = query.First().Parent.Element("Name").Value
            };

            return skill;
        }


        /// <summary>
        /// Retrieve a routine from the code of points
        /// </summary>
        /// <param name="skills">List of skills in the cop</param>
        /// <param name="evt">Event of the skills</param>
        /// <returns></returns>
        public Routine GetRoutine(List<string> skills, string evt)
        {
            var routine = new Routine(evt);

            foreach(var skill in skills)
            {
                routine.Skills.Add(GetSkill(skill, evt));
            }

            return routine;
        }

        /// <summary>
        /// Get the events in the COP
        /// </summary>
        /// <returns>List of events</returns>
        public List<string> GetEvents()
        {
            var query = from e in _cop.Descendants("Event")
                        select e;

            var events = new List<string>();

            foreach(var evt in query)
            {
                events.Add(evt.Element("Name").Value);
            }

            return events;
        }

        /// <summary>
        /// Get the element groups on the given event
        /// </summary>
        /// <param name="evt">Event</param>
        /// <returns>List of groups on the event</returns>
        public List<string> GetGroupsByEvent(string evt)
        {
            var query = from s in _cop.Descendants("Group")
                        where s.Parent.Element("Name").Value.ToLower().Equals(evt.ToLower())
                        select s;

            var groups = new List<string>();

            foreach(var group in query)
            {
                groups.Add(group.Element("Name").Value);
            }

            return groups;
        }

        #endregion

        #region Fields

        readonly XDocument _cop;

        #endregion
    }

}
