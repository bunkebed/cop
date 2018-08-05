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

        #endregion

        #region Fields

        readonly XDocument _cop;

        #endregion
    }

}
