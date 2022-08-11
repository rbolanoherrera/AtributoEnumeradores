using System;

namespace AtributoEnumeradores.Utilidades
{
    /// <summary>
    /// Manejo de los atributos para las enumeraciones
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class StringValue : Attribute
    {
        /// <summary>
        /// Gets or set valor del string a obtener
        /// </summary>
        private string stringVal = string.Empty;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValue" /> class.
        /// </summary>
        /// <param name="value">Aggregate value</param>
        public StringValue(string value)
        {
            this.stringVal = value;
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets or set Holds the stringvalue for a value in an enum.
        /// </summary>
        public string StringVal
        {
            get
            {
                return this.stringVal;
            }
        }

        #endregion Properties
    }
}
