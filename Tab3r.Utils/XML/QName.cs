using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tab3r.Utils.XML
{
    /// <summary>
    /// Class store a qualified name
    /// </summary>
    public class QName
    {
        private string _prefix = String.Empty;
        private string _name = String.Empty;
        private string _namespace = String.Empty;

        #region Constructors

        public QName()
        {
            this._prefix = string.Empty;
            this._name = string.Empty;
            this._namespace = string.Empty;
        }

        public QName(string prefix, string name, string namespaceURI)
        {
            if (prefix == null || name == null || namespaceURI == null)
            {
                throw new ArgumentNullException("");
            }
            this._prefix = prefix;
            this._name = name;
            this._namespace = namespaceURI;
        }

        public QName(string sValue, string ns)
        {
            string[] strs;
            object[] locals;

            strs = sValue.Split(new char[] { ':' });
            if ((int)strs.Length != 2 || strs[0].Length == 0 || strs[1].Length == 0)
            {
                locals = new object[] { sValue };
                throw new FormatException(String.Format("xml_ImproperQName", locals));
            }
            this._prefix = strs[0];
            this._name = strs[1];
            this._namespace = ns;
        }

        #endregion Constructors

        #region Propierties

        public string Value
        {
            get
            {
                if (_prefix.Length > 0 && _name.Length > 0)
                    return String.Concat(_prefix, ":", _name);
                return "";
            }
        }

        /// <summary>
        /// The part of qname in the left, before ":"
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
        }

        /// <summary>
        /// The part of qname in the right, after ":"
        /// </summary>
        public string LocalName
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// Uri Namespace
        /// </summary>
        public string NamespaceUri
        {
            get { return this._namespace; }
            set { this._namespace = value; }
        }

        #endregion Propierties

        #region Static Functions

        static internal string findPrefix(string qname)
        {
            string[] strs;
            object[] locals;
            strs = qname.Split(new char[] { ':' });
            if ((int)strs.Length != 2 || strs[0].Length == 0 || strs[1].Length == 0)
            {
                locals = new object[] { qname };
                throw new FormatException(String.Format("xml_ImproperQName", locals));
            }
            return strs[0];
        }

        #endregion Static Functions

    }
}
