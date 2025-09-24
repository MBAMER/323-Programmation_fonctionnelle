using Aspose.Gis;
using Aspose.Gis.Formats.Gpx;
using Aspose.Gis.Geometries;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Rando
{
    internal static class Program
    {

        public static List<TrackPoint> TrackPoints = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            // Chargez le fichier GPX et ouvrez la couche pour lire les fonctionnalités
            using (var layer = Drivers.Gpx.OpenLayer(@"../../../../../../gpx/gemmikandersteg.gpx"))
            {
                foreach (var feature in layer)
                {
                    // Vérifier la géométrie MultiLineString
                    if (feature.Geometry.GeometryType == GeometryType.MultiLineString)
                    {
                        // Lire le segment
                        var lines = (MultiLineString)feature.Geometry;
                        for (int i = 0; i < lines.Count; i++)
                        {
                            Console.WriteLine($"....segment({i})......");
                            var segment = (LineString)lines[i];

                            // Lire les points dans le segment
                            for (int j = 0; j < segment.Count; j++)
                            {
                                // Rechercher l'attribut
                                string attributeName = $"name__{i}__{j}";
                                if (layer.Attributes.Contains(attributeName) && feature.IsValueSet(attributeName))
                                {
                                    // Imprimer un point et un attribut
                                    var value = feature.GetValue<string>(attributeName);
                                    Debug.WriteLine($"{segment[j].AsText()} - {attributeName}: {value}, ");
                                }
                                else
                                {
                                    // Imprimer un point seulement
                                    Debug.WriteLine(segment[j].AsText());
                                }
                            }
                        }
                        Console.WriteLine("..........");
                    }
                }
            }



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Rando());


        }
    }
}