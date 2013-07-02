﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MultiPolygon.cs" company="Jörg Battermann">
//   Copyright © Jörg Battermann 2011
// </copyright>
// <summary>
//   Defines the <see cref="http://geojson.org/geojson-spec.html#multipolygon">MultiPolygon</see> type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GeoJSON.Net.Geometry
{
    using System.Collections.Generic;

   

    /// <summary>
    /// Defines the <see cref="http://geojson.org/geojson-spec.html#multipolygon">MultiPolygon</see> type.
    /// </summary>
    public class MultiPolygon : GeoJSONObject, IGeometryObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPolygon"/> class.
        /// </summary>
        /// <param name="polygons">The polygons contained in this MultiPolygon.</param>
        /// 
        public MultiPolygon()
        {
            this.Type = GeoJSONObjectType.MultiPolygon;
        }
        public MultiPolygon(List<Polygon> polygons = null)
        {
            this.Coordinates = polygons ?? new List<Polygon>();
            this.Type = GeoJSONObjectType.MultiPolygon;
        }

        /// <summary>
        /// Gets the list of Polygons enclosed in this MultiPolygon.
        /// </summary>
 
        public List<Polygon> Coordinates { get; set; }
    }
}
