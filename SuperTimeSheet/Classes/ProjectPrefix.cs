using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTimeSheet.Classes
{
    /// <summary>
    /// Class that represents the object 'Project Prefix'.
    /// Project prefix consists of prefix itself and appropriate description.
    /// </summary>
    public class ProjectPrefix
    {
        /// <summary>
        /// The project prefix
        /// </summary>
        private string prefix;

        /// <summary>
        /// Project description
        /// </summary>
        private string description;

        public string Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public ProjectPrefix(string prefix, string description)
        {
            SetPrefix(prefix);
            SetDescription(description);
        }

        public string GetPrefix()
        {
            return prefix;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetPrefix(string prefix)
        {
            this.prefix = prefix;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }
    }
}
