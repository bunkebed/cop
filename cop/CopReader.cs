using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cop
{
    class CopReader
    {
        #region Constructors

        public CopReader()
            : this(null)
        {
        }

        public CopReader(XDocument cop)
        {
            _cop = cop ?? XDocument.Load(@"C:\Repos\cop\cop\Resources\cop.xml");
        }

        #endregion

        #region Public Methods

        public Skill GetSkill(string name)
        {
            var query = from s in _cop.Descendants("Skill")
                        where s.Element("Name").Value.ToLower().Equals(name.ToLower())
                        select s;

            var skill = new Skill()
            {
                Name = query.First().Element("Name").Value,
                Value = double.Parse(query.First().Element("Value").Value),
                ElementGroup = query.First().Parent.Value
            };

            return skill;
        }

        #endregion

        #region Fields

        readonly XDocument _cop;

        #endregion
    }

}
