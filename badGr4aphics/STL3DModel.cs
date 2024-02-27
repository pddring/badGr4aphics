using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace badGr4aphics
{
    public class Vertex
    {
        public double X;
        public double Y;
        public double Z;
    }

    public class Face
    {
        public List<Vertex> vertices = new List<Vertex>();
    }

    internal class STL3DModel
    {
        public List<Face> faces = new List<Face>();

        public void LoadSTLFile(string filename)
        {
            string fileContents = File.ReadAllText(filename);

            // iterate through all the faces
            foreach(Match f in Regex.Matches(fileContents, "outer loop(.*?)endloop", RegexOptions.Singleline))
            {
                Face frannie = new Face();

                // iterate through all the vertices in the face
                foreach(Match v in Regex.Matches(f.Value, "vertex (-?[0-9.]+) (-?[0-9.]+) (-?[0-9.]+)"))
                {
                    Vertex vinnie = new Vertex();
                    vinnie.X = double.Parse(v.Groups[1].Value);
                    vinnie.Y = double.Parse(v.Groups[2].Value);
                    vinnie.Z = double.Parse(v.Groups[3].Value);
                    frannie.vertices.Add(vinnie);
                }
                faces.Add(frannie);
            }
        }
    }
}
