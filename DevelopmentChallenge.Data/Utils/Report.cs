using DevelopmentChallenge.Data.Dtos;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Utils
{
    public static class Report
    {
        // se agrupa por elemento geometrico y se arma la lista para el reporte agrupado
        private static List<GroupShapeDto> GenerateReportByShape(List<Shape> shapes)
        {
            var listGroupShapes = new List<GroupShapeDto>();

            var shapeGroups = shapes.GroupBy(s => s.GetType().Name);

            foreach ( var group in shapeGroups)
            {
                var groupReportItem = new GroupShapeDto()
                {
                    Name= group.Key,
                    Qty = group.Count(),
                    TotalArea = group.Sum(s => s.GetArea()),
                    TotalPerimeter = group.Sum(s => s.GetPerimeter())
                };

                listGroupShapes.Add(groupReportItem);
            }

            return listGroupShapes;
        }

        private static string GenerateLine(GroupShapeDto group)
        {
            if (group == null || group.Qty <= 0)
            {
                return string.Empty;
            }

            var nameSingularOrPlural = group.Qty > 1 ? $"{group.Name}s" : group.Name;

            return $"{group.Qty} {L.Get(nameSingularOrPlural)} | {L.Get("Area")} {group.TotalArea:#.##} | {L.Get("Perimeter")} {group.TotalPerimeter:#.##} <br/>";  
        }

        public static string PrintByShape(List<Shape> shapes, Language lang)
        {
            L.SetLang(lang); // seteo el lenguaje del reporte
            var sb = new StringBuilder();

            var listReportShapes = GenerateReportByShape(shapes);

            // si no hay formas devuelvo msj de lista vacia
            if (shapes == null || 
                shapes.Count == 0 || 
                listReportShapes == null || 
                listReportShapes.Count == 0)
            {
                return $"<h1>{L.Get("EmptyShapesList")}</h1>";
            }

            // creo reporte con datos
            sb.Append($"<h1>{L.Get("ShapesReport")}</h1>");

            foreach ( var shape in listReportShapes)
            {
                sb.Append(GenerateLine(shape));
            }

            // footer
            var totalShapes = listReportShapes.Sum(x => x.Qty);
            var totalArea = listReportShapes.Sum(x => x.TotalArea);
            var totalPerimeter = listReportShapes.Sum(x => x.TotalPerimeter);

            sb.Append("TOTAL:<br/>");
            sb.Append(totalShapes + " " + L.Get("Shapes") + " ");
            sb.Append(L.Get("Perimeter") + " " + totalPerimeter.ToString("#.##") + " ");
            sb.Append(L.Get("Area") + " " + totalArea.ToString("#.##"));
            
            return sb.ToString();
        }
    }
}
