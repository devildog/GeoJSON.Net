// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CRSBase.cs" company="Jörg Battermann">
//   Copyright © Jörg Battermann 2011
// </copyright>
// <summary>
//   Defines the CRSBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GeoJSON.Net.CoordinateReferenceSystem
{
    using System.Collections.Generic;
     

    /// <summary>
    /// Base class for all IGeometryObject implementing types
    /// </summary>
 
    public abstract class CRSBase
    {
        /// <summary>
        /// Gets the type of the GeometryObject object.
        /// </summary>
 
        public CRSType Type { get; internal set; }

        /// <summary>
        /// Gets the properties.
        /// </summary>
   
        public Dictionary<string, object> Properties { get; internal set; }
    }
}
