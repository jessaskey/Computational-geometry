using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habrador_Computational_Geometry
{
    /// <summary>
    /// The result of a clip operation which returns botht he clipped polygon and information about the clip.
    /// </summary>
    public class ClipResult
    {
        public List<List<MyVector2>> FinalPolygon { get; set; }
        public IntersectionType Intersection { get; set; }
    }

    public enum IntersectionType
    {
        NotIntersecting,
        Intersecting,
        PolygonInsideClip,
        ClipInsidePolygon
    }

}
