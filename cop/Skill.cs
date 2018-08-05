using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cop
{
    class Skill
    {
        #region Constructors

        public Skill()
            : this(null, 0, null)
        {
        }

        public Skill(string name, double value, string elementGroup)
        {
            Name = name ?? "N/A";
            Value = value;
            ElementGroup = elementGroup ?? "N/A";
        }

        #region Public Methods

        public override string ToString()
        {
            return Name + " | " + Value + " | " + ElementGroup;
        }

        #endregion

        #endregion

        #region Fields

        public string Name { get; set; }
        public double Value { get; set; }
        public string ElementGroup { get; set; }

        #endregion
    }
}
