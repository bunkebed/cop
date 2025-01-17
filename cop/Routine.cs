﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cop
{
    /// <summary>
    /// Represents a Routine
    /// </summary>
    class Routine
    {
        #region Constructors

        /// <summary>
        /// Routine defualt constructor
        /// </summary>
        public Routine()
            : this(null)
        {
        }

        public Routine(string evt)
        {
            Skills = new List<Skill>();
            Event = evt;
        }

        /// <summary>
        /// Constructor for routine
        /// </summary>
        /// <param name="skills">List of skills in the routine</param>
        /// <param name="evt">Event of the routine</param>
        public Routine(List<Skill> skills, string evt)
        {
            Skills = skills ?? new List<Skill>();
            Event = evt ?? "N/A";
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Calculate the difficulty value of the routine
        /// </summary>
        /// <returns>Difficulty value of the routine</returns>
        public double CalculateDifficulty()
        {
            var value = 0.0;

            foreach (var skill in Skills)
            {
                value += skill.Value;
            }

            return value;
        }

        /// <summary>
        /// Override of the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var description = "";

            foreach(var skill in Skills)
            {
                description += skill.ToStringDetailed() + "\n";
            }

            return description;
        }

        #endregion

        #region Fields

        public List<Skill> Skills { get; private set; }
        public string Event { get;  set; }

        #endregion
    }
}
