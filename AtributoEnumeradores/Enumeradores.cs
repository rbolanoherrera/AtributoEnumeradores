using AtributoEnumeradores.Utilidades;
using System;
using System.Reflection;

namespace AtributoEnumeradores
{
    public static class Enumeradores
    {
        public enum TipoTarjeta
        {
            /// <summary>
            /// Item Visa.
            /// </summary>
            [StringValue("Visa")]
            Visa = 1,

            /// <summary>
            /// Item Master Card.
            /// </summary>
            [StringValue("MasterCard")]
            MasterCard = 2,

            /// <summary>
            /// Item Diners Club.
            /// </summary>
            [StringValue("Diners")]
            Diners = 3,

            /// <summary>
            /// Item American Express.
            /// </summary>
            [StringValue("American Express")]
            AmericanExpress = 4

        }

        /// <summary>
        /// Will get the string value for a given enums value, this will
        /// only work if you assign the StringValue attribute to
        /// the items in your enum.
        /// </summary>
        /// <param name="value">Nombre de la propiedad a buscar.</param>
        /// <returns>valor correspondiente a la propiedad.</returns>
        public static string StringValue(this Enum value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // Get the stringvalue attributes
            StringValue[] attribs = fieldInfo.GetCustomAttributes(typeof(StringValue), false) as StringValue[];

            // Return the first if there was a match.
            return attribs.Length > 0 ? attribs[0].StringVal : null;
        }
    }
}
