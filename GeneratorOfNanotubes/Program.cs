using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Globalization;

namespace WindowsFormsApplication2
{
    /// <summary>
    /// Sturcture that hides list but provide some of his functions to others
    /// </summary>
    interface IStructure : IEnumerable<CartesianCoordinates>
    {
        void Add(CartesianCoordinates item);
        void Clear();
        bool Remove(CartesianCoordinates item);
        int Count { get; }
        void Insert(int index, CartesianCoordinates item);
        void RemoveAt(int index);
        OneCrystalSize FindMaxDistanceAmongAtoms();
        OneCrystalSize FindMinDistanceAmongAtoms();
    }

    /// <summary>
    /// singleton class that keeps List with coordinates of created structure atoms
    /// </summary>
    public class CreatedStructure : IStructure
    {
        private static CreatedStructure instance = new CreatedStructure();

        private CreatedStructure() { }

        public static CreatedStructure Instance
        {
            get
            {
                return instance ?? (instance = new CreatedStructure());
            }
        }

        private static List<CartesianCoordinates> createdStructure = new List<CartesianCoordinates>();

        public IEnumerator<CartesianCoordinates> GetEnumerator()
        {
            return createdStructure.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return createdStructure.GetEnumerator();
        }

        public void Add(CartesianCoordinates item)
        {
            createdStructure.Add(item);
        }

        public void Clear()
        {
            createdStructure.Clear();
        }
        public bool Remove(CartesianCoordinates item)
        {
            return createdStructure.Remove(item);
        }

        public int Count
        {
            get { return createdStructure.Count; }
        }

        public void Insert(int index, CartesianCoordinates item)
        {
            createdStructure.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            createdStructure.RemoveAt(index);
        }

        public CartesianCoordinates this[int index]
        {
            get { return createdStructure[index]; }
            set { createdStructure[index] = value; }
        }

        public OneCrystalSize FindMaxDistanceAmongAtoms()
        {
            double maxX = Double.MinValue;
            double maxY = Double.MinValue;
            double maxZ = Double.MinValue;
            foreach (var item in createdStructure)
            {
                if (item.x > maxX)
                {
                    maxX = item.x;
                }
                if (item.y > maxY)
                {
                    maxY = item.y;
                }
                if (item.z > maxZ)
                {
                    maxZ = item.z;
                }
            }
            OneCrystalSize s = new OneCrystalSize(maxX, maxY, maxZ);
            return s;
        }


        public OneCrystalSize FindMinDistanceAmongAtoms()
        {
            double minX = Double.MaxValue;
            double minY = Double.MaxValue;
            double minZ = Double.MaxValue;
            foreach (var item in createdStructure)
            {
                if (item.x < minX)
                {
                    minX = item.x;
                }
                if (item.y < minY)
                {
                    minY = item.y;
                }
                if (item.z < minZ)
                {
                    minZ = item.z;
                }
            }
            OneCrystalSize s = new OneCrystalSize(minX, minY, minZ);
            return s;
        }
    }

    /// <summary>
    /// singleton class that keeps List with coordinates of original crystal atoms
    /// </summary>
    public class OriginalCrystal : IStructure
    {
        //immediate initialization on first use
        private static OriginalCrystal instance = new OriginalCrystal();

        //private constructor
        private OriginalCrystal() { }

        //static property return instance
        public static OriginalCrystal Instance
        {
            get
            {
                return instance ?? (instance = new OriginalCrystal());
            }
        }
        private static List<CartesianCoordinates> originalCrystal = new List<CartesianCoordinates>();

        public IEnumerator<CartesianCoordinates> GetEnumerator()
        {
            return originalCrystal.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return originalCrystal.GetEnumerator();
        }

        public void Add(CartesianCoordinates item)
        {
            originalCrystal.Add(item);
        }

        public void Clear()
        {
            originalCrystal.Clear();
        }
        public bool Remove(CartesianCoordinates item)
        {
            return originalCrystal.Remove(item);
        }

        public int Count
        {
            get { return originalCrystal.Count; }
        }

        public void Insert(int index, CartesianCoordinates item)
        {
            originalCrystal.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            originalCrystal.RemoveAt(index);
        }

        public CartesianCoordinates this[int index]
        {
            get { return originalCrystal[index]; }
            set { originalCrystal[index] = value; }
        }
        public OneCrystalSize FindMaxDistanceAmongAtoms()
        {
            double maxX = Double.MinValue;
            double maxY = Double.MinValue;
            double maxZ = Double.MinValue;
            foreach (var item in originalCrystal)
            {
                if (item.x > maxX)
                {
                    maxX = item.x;
                }
                if (item.y > maxY)
                {
                    maxY = item.y;
                }
                if (item.z > maxZ)
                {
                    maxZ = item.z;
                }
            }
            OneCrystalSize s = new OneCrystalSize(maxX, maxY, maxZ);
            return s;
        }

        public OneCrystalSize FindMinDistanceAmongAtoms()
        {
            double minX = Double.MaxValue;
            double minY = Double.MaxValue;
            double minZ = Double.MaxValue;
            foreach (var item in originalCrystal)
            {
                if (item.x < minX)
                {
                    minX = item.x;
                }
                if (item.y < minY)
                {
                    minY = item.y;
                }
                if (item.z < minZ)
                {
                    minZ = item.z;
                }
            }
            OneCrystalSize s = new OneCrystalSize(minX, minY, minZ);
            return s;
        }
    }

    /// <summary>
    /// Structure for vector
    /// </summary>
    public class Vector
    {
        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double sizeOfVector()
        {
            double s = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            return s;
        }
    }


    /// <summary>
    /// Structure to save axis of rotation
    /// </summary>
    enum Axes {xUp, xDown, xFront, xBack, yUp, yDown, yFront, yBack, zUp, zDown, zFront, zBack };

    /// <summary>
    /// Structure for saving atom coordinates in polar coordinates
    /// </summary>
    public class CylindricCoordinates
    {
        public double r;
        public double angle;
        public string element;
        public double z;

        public CylindricCoordinates(string element, double r, double angle, double z)
        {
            this.element = element;
            this.r = r;
            this.angle = angle;
            this.z = z;
        }
    }

    /// <summary>
    /// Structure for saving atom coordinates in cartesian coordinates
    /// </summary>
    public class CartesianCoordinates : IEquatable<CartesianCoordinates>
    {
        public double x;
        public double y;
        public double z;
        public string element;

        public CartesianCoordinates(string element, double x, double y, double z)
        {
            this.element = element;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool Equals(CartesianCoordinates other)
        {
            return (Math.Abs(x - other.x) < (1 / 1000) && Math.Abs(y - other.y) < (1 / 1000) && Math.Abs(z - other.z) < (1 / 1000));
        }
    }

    /// <summary>
    /// Converts one type of coordinates to another one
    /// </summary>
    class ConvertorOfCoordinates
    {
        /// <summary>
        /// Converts cylindric coordinates to cartesian coordinates
        /// </summary>
        /// <param name="p">cylindric coordinates of atom</param>
        /// <returns>cartesian coordinates of atom</returns>
        public static CartesianCoordinates ConvertCylindricToCartesian(CylindricCoordinates p)
        {
            double x = p.r * Math.Cos(p.angle);
            double y = p.r * Math.Sin(p.angle);
            CartesianCoordinates c = new CartesianCoordinates(p.element, x, y, p.z);
            return c;
        }

        /// <summary>
        /// Converts cartesian coordinates to cylindriccoordinates
        /// </summary>
        /// <param name="c">cartesian coordinates of atom</param>
        /// <returns>cylindric coordinates of atom</returns>
        public static CylindricCoordinates ConvertCartesianToCylindric(CartesianCoordinates c)
        {
            double r = Math.Sqrt(Math.Pow(c.x, 2) + Math.Pow(c.y, 2));
            double fi = Math.Atan2(c.y, c.x);
            CylindricCoordinates p = new CylindricCoordinates(c.element, r, fi, c.z);
            return p;
        }
    }

    /// <summary>
    /// Structure for saving cartesian coordinates of one atom
    /// </summary>
    public struct OneCrystalSize
    {
        public double x;
        public double y;
        public double z;

        public OneCrystalSize(double x, double y, double z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    /// <summary>
    /// class which keep crystal parameters
    /// </summary>
    public class CrystalParameters
    {
        public double a;
        public double b;
        public double c;

        public double alpha;
        public double beta;
        public double gamma;

        public CrystalParameters(double a, double b, double c, double alpha, double beta, double gamma)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
        }
    }

    /// <summary>
    /// class that keep cylindr parameters
    /// </summary>
    public class CylinderParameters
    {
        public double depth;
        public double circumference;
        public double wallWidth;

        public CylinderParameters(double depth, double circumference, double wallWidth)
        {
            this.depth = depth;
            this.circumference = circumference;
            this.wallWidth = wallWidth;
        }
    }

    /// <summary>
    /// class that keep planar parameters
    /// </summary>
    public class PlanarParameters
    {
        public double width;
        public double heigth;
        public double depth;

        public PlanarParameters(double width, double heigth, double depth)
        {
            this.width = width;
            this.heigth = heigth;
            this.depth = depth;
        }
    }

    /// <summary>
    /// class that keep spiral parameters
    /// </summary>
    public class SpiralParameters
    {
        public double move;
        public double climb;
        public double depth;
        public double circumference;
        public double wallWidth;

        public SpiralParameters(double move, double climb, double depth, double circumference, double wallWidth)
        {
            this.move = move;
            this.climb = climb;
            this.depth = depth;
            this.circumference = circumference;
            this.wallWidth = wallWidth;
        }
    }

    /// <summary>
    /// Verifies wheher input parametres are in correct format
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Verifies if input parameter is greater than 0
        /// </summary>
        /// <param name="num">length of first side of crystal</param>
        /// <returns></returns>
        public static bool ValidNumber(double num)
        {
            return (num > 0);
        }

        /// <summary>
        /// Verifies if angle describing the crystal is valid angle (in degrees)
        /// </summary>
        /// <param name="ang1>first angle</param>
        /// <returns></returns>
        public static bool ValidAngle(double ang)
        {
            return (ang > 0 && ang < 180);
        }

        /// <summary>
        /// validates whether crystal parameters are valid
        /// </summary>
        /// <param name="cp">crystal parameters</param>
        /// <returns></returns>
        public static bool ValidCrystal(CrystalParameters cp)
        {
            return (ValidNumber(cp.a) && ValidNumber(cp.b) && ValidNumber(cp.c) && ValidAngle(cp.alpha) && ValidAngle(cp.beta) && ValidAngle(cp.gamma));
        }

        /// <summary>
        ///  validates whether spiral parameters are valid
        /// </summary>
        /// <param name="sp">spiral parameters</param>
        /// <returns></returns>
        public static bool ValidSpiral(SpiralParameters sp)
        {
            return (ValidNumber(sp.depth) && ValidNumber(sp.circumference) && sp.move >= 0 && ValidAngle(sp.climb));
        }

        /// <summary>
        /// validates whether cylindr parameters are valid
        /// </summary>
        /// <param name="cp">pipe parameters</param>
        /// <returns></returns>
        public static bool ValidPipe(CylinderParameters cp)
        {
            return (ValidNumber(cp.depth) && ValidNumber(cp.circumference));
        }

        /// <summary>plane parameters are valid
        /// </summary>
        /// <param name="pp">plane parameters</param>
        /// <returns></returns>
        public static bool ValidPlane(PlanarParameters pp)
        {
            return (ValidNumber(pp.depth) && ValidNumber(pp.heigth) && ValidNumber(pp.width));
        }
    }


    /// <summary>
    /// Loads input file and saves result to output file
    /// </summary>
    class LoaderAndSaver
    {
        /// <summary>
        /// Loads input file to List of cartesian coordinates
        /// </summary>
        /// <param name="file">name of input file</param>
        public static void LoadFile(string file)
        {
            OriginalCrystal.Instance.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    int lines = Convert.ToInt32(sr.ReadLine());

                    sr.ReadLine();
                    for (int i = 0; i < lines; i++)
                    {
                        string line = sr.ReadLine();
                        char[] parsers = { ' ', '\t' };
                        string[] coord = line.Split(parsers);
                        string element = coord[0];
                        double x = Convert.ToDouble(coord[1], CultureInfo.InvariantCulture);
                        double y = Convert.ToDouble(coord[2], CultureInfo.InvariantCulture);
                        double z = Convert.ToDouble(coord[3], CultureInfo.InvariantCulture);
                        CreatedStructure.Instance.Add(new CartesianCoordinates(element, x, y, z));
                        OriginalCrystal.Instance.Add(new CartesianCoordinates(element, x, y, z));
                    }
                }
            }
            catch (IOException)
            {
                return;
            }

        }


        /// <summary>
        /// Saves List of cartesian coordinates to output file
        /// </summary>
        /// <returns>whether saving was successfull</returns>
        public static void SaveToFile()
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "xyz files (*.xyz)|*.xyz|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.WriteLine(CreatedStructure.Instance.Count);
                        sw.WriteLine();
                        foreach (var item in CreatedStructure.Instance)
                        {
                            sw.Write(item.element + " " + item.x + " " + item.y + " " + item.z, CultureInfo.InvariantCulture);
                            sw.WriteLine();
                        }
                    }
                }
            }
            catch (IOException)
            {
                return;
            }
        }

        /// <summary>
        /// saves crystal into file
        /// </summary>
        /// <param name="a">side a</param>
        /// <param name="b">side b</param>
        /// <param name="c">side c</param>
        /// <param name="alpha">angle alpha</param>
        /// <param name="beta">angle beta</param>
        /// <param name="gamma">angle gamma</param>
        public static void SaveCrystalToFile(string a, string b, string c, string alpha, string beta, string gamma)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xyz files (*.xyz)|*.xyz|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.WriteLine(a);
                        sw.WriteLine(b);
                        sw.WriteLine(c);
                        sw.WriteLine(alpha);
                        sw.WriteLine(beta);
                        sw.Write(gamma);
                    }
                }
            }
            catch (IOException)
            {
                return;
            }
        }

        /// <summary>
        /// Loads crystal parameters from file
        /// </summary>
        /// <param name="file">file name</param>
        /// <returns>parametres is operation was successfull or null if not</returns>
        public static string[] LoadFileParams(string file)
        {
            try
            {
                string[] elements = new string[6];
                using (StreamReader sr = new StreamReader(file))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        string line = sr.ReadLine();
                        double x = Convert.ToDouble(line, CultureInfo.InvariantCulture);
                        elements[i] = line;
                    }
                    return elements;
                }
            }
            catch
            {
                return null;
            }
        }
    }

    /// <summary>
    /// Converts parameters from pgysical to mathematical that are used for counting the spiral
    /// </summary>
    public class ConvertorOfParametres
    {
        /// <summary>
        /// count number of turns in spiral
        /// </summary>
        /// <param name="alpha">angle climb of the spiral</param>
        /// <param name="outerDiameter">outer diameter of spiral structure</param>
        /// <param name="wallWidth">width of the one wall</param>
        /// <param name="moveFromTheMiddle">move from the middle of the spiral</param>
        /// <returns>number of turns</returns>
        public static double CountTurns(double alpha, double wallWidth, double outerDiameter, double moveFromTheMiddle)
        {
            return (outerDiameter-2*moveFromTheMiddle - wallWidth + Math.PI* alpha) /(4*Math.PI*alpha);
        }

        /// <summary>
        /// count length of the spiral
        /// </summary>
        /// <param name="move">move from the middle</param>
        /// <param name="climb">speed of turning the spiral</param>
        /// <param name="turns">number of turns</param>
        /// <returns>length of the spiral</returns>
        public static double CountCircumference(double move, double climb, double turns)
        {
            double from = 0;
            double to =  2*Math.PI * turns;
            double equationFrom = climb * from + move;
            double equationTo = climb * to + move;
            double upperBound = ((Math.Sqrt(climb * climb + equationTo* equationTo) * equationTo) / (2 * climb)) + (1 / 2 * climb * Math.Log(Math.Sqrt(climb*climb + equationTo*equationTo) + equationTo));
            double lesserBound = ((Math.Sqrt(climb * climb + equationFrom* equationFrom) * equationFrom) / (2 * climb)) + (1 / 2 * climb * Math.Log(Math.Sqrt(climb * climb + equationFrom*equationFrom) + equationFrom));
            double tmp = upperBound - lesserBound;
            return upperBound - lesserBound;
        }

        /// <summary>
        /// count speed of turning the spiral
        /// </summary>
        /// <param name="spaceWidth">width of the space between walls</param>
        /// <param name="wallWidth">width of the one wall</param>
        /// <returns>speed of turning the spiral in angles</returns>
        public static double CountClimb(double spaceWidth, double wallWidth)
        {
            return (spaceWidth + wallWidth) / (2 * Math.PI); //=alpha
        }

        /// <summary>
        /// count original move from the middle of the spiral
        /// </summary>
        /// <param name="innerSize">inner diamater of the spiral</param>
        /// <param name="wallWidth">width of the one wall</param>
        /// <param name="alpha">climb of the spiral</param>
        /// <returns></returns>
        public static double CountMove(double innerSize, double wallWidth, double alpha)
        {

            return (innerSize + wallWidth - Math.PI * alpha ) / 2; //=Beta
        }

        /// <summary>
        /// count circumference of the circle of the pipe
        /// </summary>
        /// <param name="innerSize">inner diamater of the cylinder</param>
        /// <param name="outerSize">outer diamater of the cylinder</param>
        /// <returns>circumference of the cylinder</returns>
        public static double CircumferenceOfTheCircle(double innerSize, double outerSize)
        {
            double radius = (outerSize - innerSize) / 4 + innerSize / 2;
            return 2 * Math.PI * radius;
        }
    }

    /// <summary>
    /// Rotates original crystal to have correct original turn to create a structure according to chosen axis
    /// </summary>
    public static class RotatorOfCrystal
    {

        /// <summary>
        /// recount crystal parameters to have correct parameters of the crystal after two rotations on X
        /// </summary>
        /// <param name="cp">original crystal parameters</param>
        /// <returns>recounted crystal parameters</returns>
        public static CrystalParameters RecountOnXDown(CrystalParameters cp)
        {
            return new CrystalParameters(cp.a, cp.b, cp.c, 180 - cp.alpha, cp.beta, 180 - cp.gamma);
        }


        /// <summary>
        /// recount crystal parameters to have correct parameters of the crystal after rotation on Y axis to the left
        /// </summary>
        /// <param name="cp">original crystal parameters</param>
        /// <returns>recounted crystal parameters</returns>
        public static CrystalParameters RecountOnXFront(CrystalParameters cp)
        {
            return new CrystalParameters(cp.a, cp.c, cp.b, 180 - cp.gamma, 180 - cp.beta, cp.alpha);
        }
        public static CrystalParameters RecountOnXBack(CrystalParameters cp)
        {
            return new CrystalParameters(cp.a, cp.c, cp.b, cp.gamma, 180 - cp.beta, 180 - cp.alpha);
        }
        public static CrystalParameters RecountOnYUp(CrystalParameters cp)
        {
            return new CrystalParameters(cp.c, cp.b, cp.a, 180 - cp.alpha, 180 - cp.gamma, cp.beta);
        }
        public static CrystalParameters RecountOnYDown(CrystalParameters cp)
        {
            return new CrystalParameters(cp.c, cp.b, cp.a, cp.alpha, 180 - cp.gamma, 180 - cp.beta);
        }
        public static CrystalParameters RecountOnYFront(CrystalParameters cp)
        {
            return new CrystalParameters(cp.c, cp.a, cp.b, cp.beta, cp.gamma, cp.alpha);
        }
        public static CrystalParameters RecountOnYBack(CrystalParameters cp)
        {
            return new CrystalParameters(cp.c, cp.a, cp.b, 180 - cp.beta, cp.gamma, 180 - cp.alpha);
        }
        public static CrystalParameters RecountOnZUp(CrystalParameters cp)
        {
            return new CrystalParameters(cp.b, cp.a, cp.c, cp.beta, 180 - cp.alpha, 180 - cp.gamma);
        }
        public static CrystalParameters RecountOnZDown(CrystalParameters cp)
        {
            return new CrystalParameters(cp.b, cp.a, cp.c, 180 - cp.beta, 180 - cp.alpha, cp.gamma);
        }
        public static CrystalParameters RecountOnZFront(CrystalParameters cp)
        {
            return new CrystalParameters(cp.b, cp.c, cp.a, cp.gamma, cp.alpha, cp.beta);
        }
        public static CrystalParameters RecountOnZBack(CrystalParameters cp)
        {
            return new CrystalParameters(cp.b, cp.c, cp.a, 180 - cp.gamma, cp.alpha, 180 - cp.beta);
        }


        /// <summary>
        /// Rotate crystal around corresponding axis 
        /// </summary>
        /// <param name="fi">angle of rotation</param>
        /// <param name="sourceList">source cooordinates of crystal atoms</param>
        /// <returns>resultant rotated crystal atom coordinates</returns>
        public static List<CartesianCoordinates> RotateCrystalRoundXFront(double fi, List<CartesianCoordinates> sourceList)
        {
            List<CartesianCoordinates> resultList = new List<CartesianCoordinates>();
            foreach (CartesianCoordinates cc in sourceList)
            {
                double zNew = cc.z * Math.Cos(fi) + cc.y * Math.Sin(fi);
                double yNew = - cc.z * Math.Sin(fi) + cc.y * Math.Cos(fi);
                cc.y = yNew;
                cc.z = zNew;
                resultList.Add(new CartesianCoordinates(cc.element, cc.x, cc.y, cc.z));
            }
            return resultList;
        }
        public static List<CartesianCoordinates> RotateCrystalRoundXBack(double fi, List<CartesianCoordinates> sourceList)
        {
            List<CartesianCoordinates> resultList = new List<CartesianCoordinates>();
            foreach (CartesianCoordinates cc in sourceList)
            {
                double zNew = cc.z * Math.Cos(fi) - cc.y * Math.Sin(fi);
                double yNew = cc.z * Math.Sin(fi) + cc.y * Math.Cos(fi);
                cc.y = yNew;
                cc.z = zNew;
                resultList.Add(new CartesianCoordinates(cc.element, cc.x, cc.y, cc.z));
            }
            return resultList;
        }
        public static List<CartesianCoordinates> RotateCrystalRoundYFront(double fi, List<CartesianCoordinates> sourceList)
        {
            List<CartesianCoordinates> resultList = new List<CartesianCoordinates>();
            foreach (CartesianCoordinates cc in sourceList)
            {
                double xNew = cc.x * Math.Cos(fi) - cc.z * Math.Sin(fi);
                double zNew = cc.x * Math.Sin(fi) + cc.z * Math.Cos(fi);
                cc.x = xNew;
                cc.z = zNew;
                resultList.Add(new CartesianCoordinates(cc.element, cc.x, cc.y, cc.z));
            }
            return resultList;
        }
        public static List<CartesianCoordinates> RotateCrystalRoundYBack(double fi, List<CartesianCoordinates> sourceList)
        {
            List<CartesianCoordinates> resultList = new List<CartesianCoordinates>();
            foreach (CartesianCoordinates cc in sourceList)
            {
                double xNew = cc.x * Math.Cos(fi) + cc.z * Math.Sin(fi);
                double zNew = -cc.x * Math.Sin(fi) + cc.z * Math.Cos(fi);
                cc.x = xNew;
                cc.z = zNew;
                resultList.Add(new CartesianCoordinates(cc.element, cc.x, cc.y, cc.z));
            }
            return resultList;
        }
        public static List<CartesianCoordinates> RotateCrystalRoundZRight(double fi, List<CartesianCoordinates> sourceList)
        {
            List<CartesianCoordinates> resultList = new List<CartesianCoordinates>();
            foreach (CartesianCoordinates cc in sourceList)
            {
                double xNew = cc.x * Math.Cos(fi) + cc.y * Math.Sin(fi);
                double yNew = -cc.x * Math.Sin(fi) + cc.y * Math.Cos(fi);
                cc.x = xNew;
                cc.y = yNew;
                resultList.Add(new CartesianCoordinates(cc.element, cc.x, cc.y, cc.z));
            }
            return resultList;
        }
        public static List<CartesianCoordinates> RotateCrystalRoundZLeft(double fi, List<CartesianCoordinates> sourceList)
        {
            List<CartesianCoordinates> resultList = new List<CartesianCoordinates>();
            foreach (CartesianCoordinates cc in sourceList)
            {
                double xNew = cc.x * Math.Cos(fi) - cc.y * Math.Sin(fi);
                double yNew = cc.x * Math.Sin(fi) + cc.y * Math.Cos(fi);
                cc.x = xNew;
                cc.y = yNew;
                resultList.Add(new CartesianCoordinates(cc.element, cc.x, cc.y, cc.z));
            }

            return resultList;
        }


        /// <summary>
        /// rotate crystal around correct axis
        /// </summary>
        /// <param name="axis">one of x+ y+ z+ x- y- z- </param>
        /// <param name="cp">crystal parameters to rotate</param>
        public static CrystalParameters RotateCrystalRoundAxis(string axis, CrystalParameters cp)
        {
            List<CartesianCoordinates> recountedAtomsCoordinates = new List<CartesianCoordinates>();
            CrystalParameters recountedCrystalParameters = new CrystalParameters(cp.a,cp.b, cp.c, cp.alpha, cp.beta, cp.gamma);
            if (axis == Axes.xDown.ToString())
            {
                double fi = Math.PI;
                recountedAtomsCoordinates = RotateCrystalRoundXBack(fi, CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnXDown(cp);
            }
            if (axis == Axes.xFront.ToString())
            {
                double fi = (cp.beta) * (Math.PI / 180);
                recountedAtomsCoordinates = RotateCrystalRoundXBack(fi, CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnXFront(cp);
            }
            if (axis == Axes.xBack.ToString())
            {
                double fi = (180-cp.beta) * (Math.PI / 180);
                recountedAtomsCoordinates = RotateCrystalRoundXFront(fi, CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnXBack(cp);
            }
         

            if (axis == Axes.yUp.ToString())
            {
                double fi = cp.alpha * (Math.PI / 180.0); //alpha  to radians (angle of rotation)
                recountedAtomsCoordinates = RotateCrystalRoundZRight(fi, CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnYUp(cp);

                if (recountedCrystalParameters.gamma != 90)
                {
                   recountedAtomsCoordinates = RotateCrystalRoundYFront((90 - recountedCrystalParameters.gamma) * (Math.PI / 180.0), CreatedStructure.Instance.ToList());
                }
                if (recountedCrystalParameters.beta != 90)
                {
                    recountedAtomsCoordinates = RotateCrystalRoundXBack((90 - recountedCrystalParameters.beta) * (Math.PI / 180.0), CreatedStructure.Instance.ToList());
                }
            }
            if (axis == Axes.yDown.ToString())
            {
                double fi = (180-cp.alpha) * (Math.PI / 180);
                List<CartesianCoordinates> halfRotation = RotateCrystalRoundZLeft(fi, CreatedStructure.Instance.ToList());
                recountedAtomsCoordinates = RotateCrystalRoundYFront(Math.PI, CreatedStructure.Instance.ToList()); 
                recountedCrystalParameters = RecountOnYDown(cp);
                if (recountedCrystalParameters.gamma != 90)
                {
                    recountedAtomsCoordinates = RotateCrystalRoundYBack((-90+recountedCrystalParameters.gamma) * (Math.PI / 180.0), CreatedStructure.Instance.ToList());
                }
                if (recountedCrystalParameters.beta != 90)
                {
                    recountedAtomsCoordinates = RotateCrystalRoundXFront((-90+recountedCrystalParameters.beta) * (Math.PI / 180.0), CreatedStructure.Instance.ToList());
                }
            }
            if (axis == Axes.yFront.ToString())
            {
                double fi = cp.alpha * (Math.PI / 180);
                List<CartesianCoordinates> halfRotation = RotateCrystalRoundZRight(fi, CreatedStructure.Instance.ToList());
                recountedAtomsCoordinates = RotateCrystalRoundXBack((cp.gamma)  * (Math.PI / 180), CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnYFront(cp);
                if (recountedCrystalParameters.beta != 90)
                {
                    recountedAtomsCoordinates = RotateCrystalRoundXBack((90 - recountedCrystalParameters.beta) * (Math.PI / 180.0), CreatedStructure.Instance.ToList());
                }
                if (recountedCrystalParameters.alpha != 90)
                {
                    recountedAtomsCoordinates = RotateCrystalRoundZLeft((90 - recountedCrystalParameters.alpha) * (Math.PI / 180.0), CreatedStructure.Instance.ToList());
                }

            }
            if (axis == Axes.yBack.ToString())
            {
                double fi = cp.alpha * (Math.PI / 180);

                List<CartesianCoordinates> halfRotation = RotateCrystalRoundZRight(fi, CreatedStructure.Instance.ToList());
                recountedAtomsCoordinates = RotateCrystalRoundXFront((180-cp.gamma) * (Math.PI / 180), CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnYBack(cp);
                if (recountedCrystalParameters.alpha != 90)
                {
                    recountedAtomsCoordinates = RotateCrystalRoundZLeft((90- recountedCrystalParameters.alpha) * (Math.PI / 180.0), CreatedStructure.Instance.ToList());
                }
                if (recountedCrystalParameters.beta != 90)
                {
                    recountedAtomsCoordinates = RotateCrystalRoundXFront((-90 + recountedCrystalParameters.beta) * (Math.PI / 180.0), CreatedStructure.Instance.ToList());
                }
            }

            if (axis == Axes.zUp.ToString())
            {
                double fi = cp.gamma * (Math.PI / 180.0); //gamma to radians (angle of rotation)
                recountedAtomsCoordinates = RotateCrystalRoundYFront(fi, CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnZUp(cp);
            }
            if (axis == Axes.zDown.ToString())
            {
                double fi = cp.gamma * (Math.PI / 180.0);
                List<CartesianCoordinates> halfRotation = RotateCrystalRoundYFront(fi, CreatedStructure.Instance.ToList());
                recountedAtomsCoordinates = RotateCrystalRoundXBack(Math.PI, CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnZDown(cp);
            }
            if (axis == Axes.zFront.ToString())
            {
                double fi = cp.gamma * (Math.PI / 180.0);
                List<CartesianCoordinates> halfRotation = RotateCrystalRoundYFront(fi, CreatedStructure.Instance.ToList());
                recountedAtomsCoordinates = RotateCrystalRoundXBack((180 - cp.alpha) * (Math.PI / 180), CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnZFront(cp);
            }
            if (axis == Axes.zBack.ToString())
            {
                double fi = cp.gamma * (Math.PI / 180.0);
                List<CartesianCoordinates> halfRotation = RotateCrystalRoundYFront(fi, CreatedStructure.Instance.ToList());
                recountedAtomsCoordinates = RotateCrystalRoundXFront(cp.alpha * (Math.PI / 180), CreatedStructure.Instance.ToList());
                recountedCrystalParameters = RecountOnZBack(cp);
            }

            CopyListToOriginalCrystal(recountedAtomsCoordinates);
            return recountedCrystalParameters;
        }

        /// <summary>
        /// Copy resultant rotated atom coordinates of crystal to structure OriginalCrystal
        /// </summary>
        /// <param name="sourceList">list with source atom coordinates</param>
        private static void CopyListToOriginalCrystal(List<CartesianCoordinates> sourceList)
        {

            OriginalCrystal.Instance.Clear();
            foreach (CartesianCoordinates cc in sourceList)
            {
                OriginalCrystal.Instance.Add(cc);
            }
        }
    }

    /// <summary>
    /// Creator of spiral
    /// </summary>
    class CreatorOfSpiral
    {
        /// <summary>
        /// Creates spiral
        /// </summary>
        /// <param name="move">move from the middle</param>
        /// <param name="climb">speed of climb of the spiral</param>
        /// <param name="length">required length of the spiral</param>
        /// <param name="height">required height of the spiral</param>
        /// <param name="length">how many times the basic cell should repeat in the spiral</param>
        public static void CreateSpiral(double move, double climb, double length, double height, int repeats)
        {
            Dictionary<CartesianCoordinates, CartesianCoordinates> crystDict = new Dictionary<CartesianCoordinates, CartesianCoordinates>();
            HashSet<CartesianCoordinates> crystHash = new HashSet<CartesianCoordinates>();
            OneCrystalSize sMax = CreatedStructure.Instance.FindMaxDistanceAmongAtoms();
            OneCrystalSize sMin = CreatedStructure.Instance.FindMinDistanceAmongAtoms();
            Queue<CartesianCoordinates> queueCrystal = new Queue<CartesianCoordinates>();

            double sizeX = CreatorOfSurface.crystalMoveX.x;
            double sizeY = (sMax.y - sMin.y);
            double dist =  sizeY / 2; //height / 2; //
            double moveX = (0 - sMin.x); //move minimum to x=0  
            double moveY = (0 - sMin.y); //move minimum to y=0  
            double moveZ = (0 - sMin.z); //move minimum to z=0  

            OriginalCrystal.Instance.Clear();
            foreach (var crystal in CreatedStructure.Instance.OrderBy(c => c.x))
            {
                crystal.x += moveX;
                crystal.y += moveY;
                crystal.z += moveZ;
                queueCrystal.Enqueue(crystal);
                OriginalCrystal.Instance.Add(crystal);
            }
            int numberOfAtomsInStructure = OriginalCrystal.Instance.Count*repeats;
            CreatedStructure.Instance.Clear();


            
            double origFi = 0;
            double origR = origFi * climb + move;
            double linStep = sizeX / 1000;
            double deltaFi = linStep / move;
            if (Math.Abs(move) < Math.Pow(1,-8))
            {
                deltaFi = 0.00001;
            }
            double tmpLength = 0;
            double minX = origR * Math.Cos(origFi);
            double minY = origR * Math.Sin(origFi);
            int index = 0;

            while (tmpLength < length || crystHash.Count()<numberOfAtomsInStructure)
            {
                if (crystHash.Count() == numberOfAtomsInStructure)
                {
                    break;
                }
                double lenghtAct = 0;
                double x = 0;
                double y = 0;
                double fi = origFi;
                int crystalCount = OriginalCrystal.Instance.Count;
                double reallySmallConstant = Math.Pow(1, -5);
                while (Math.Abs(OriginalCrystal.Instance[index].x) < reallySmallConstant && Math.Abs(tmpLength) < reallySmallConstant) //while x=0 add to result
                {
                    double newX = OriginalCrystal.Instance[index].x + sizeX;
                    CartesianCoordinates crystNew = new CartesianCoordinates(OriginalCrystal.Instance[index].element, newX, OriginalCrystal.Instance[index].y, OriginalCrystal.Instance[index].z);
                    OriginalCrystal.Instance.Add(crystNew);
                    OriginalCrystal.Instance[index].x += sizeX;
                    CartesianCoordinates c = OriginalCrystal.Instance[index];
                    double r = fi * climb + move;
                    double distAct = c.y - dist;

                    double rAct = r + distAct;
                    CylindricCoordinates p = new CylindricCoordinates(c.element, rAct, fi, c.z);
                    CartesianCoordinates cc = ConvertorOfCoordinates.ConvertCylindricToCartesian(p);
                    if (!crystHash.Contains(cc))
                    {
                        crystHash.Add(cc);
                    }
                    index++;
                }

                while (!((lenghtAct < (1.01 * linStep)) && (lenghtAct > 0.99 * linStep)))
                {
                    fi += deltaFi;
                    double r = fi * climb + move;
                    x = r * Math.Cos(fi);
                    y = r * Math.Sin(fi);
                    lenghtAct = Math.Sqrt(Math.Pow((minX - x), 2) + Math.Pow((minY - y), 2));

                    if (lenghtAct < (1.01 * linStep) && lenghtAct > (0.99 * linStep))
                    {
                        tmpLength += lenghtAct;
                        double roundLength = tmpLength - tmpLength % OriginalCrystal.Instance[index].x;
                        double d = roundLength % OriginalCrystal.Instance[index].x;
                        while ((Math.Abs(roundLength % OriginalCrystal.Instance[index].x) < Math.Pow(1,-5) && roundLength != 0))
                        {
                            CartesianCoordinates c = OriginalCrystal.Instance[index];

                            double newX = OriginalCrystal.Instance[index].x + sizeX;
                            CartesianCoordinates crystNew = new CartesianCoordinates(OriginalCrystal.Instance[index].element, newX, OriginalCrystal.Instance[index].y, OriginalCrystal.Instance[index].z);
                            OriginalCrystal.Instance.Add(crystNew);
                            double distAct = c.y - dist;
                            double rAct = r + distAct;
                            //double xAct = rAct * Math.Cos(fi);
                            //double yAct = rAct * Math.Sin(fi);
                            CylindricCoordinates p = new CylindricCoordinates(c.element, rAct, fi, c.z);
                            CartesianCoordinates cc = ConvertorOfCoordinates.ConvertCylindricToCartesian(p);
                            //CartesianCoordinates cc = new CartesianCoordinates(c.element, xAct, yAct, c.z);
                            if (!crystHash.Contains(cc))
                            {

                                crystHash.Add(cc);
                            }
                            index++;

                        }
                        minX = x;
                        minY = y;
                        origFi = fi;
                    }
                    else
                    {
                        fi -= deltaFi;
                        r = fi * climb + move;
                        deltaFi *= (linStep / lenghtAct);
                    }

                }
            }

            foreach (var c in crystHash)
            {
                CreatedStructure.Instance.Add(c);
            }
        }
    }

    /// <summary>
    /// Creator of pipe from area
    /// </summary>
    class CreatorOfCylinder
    {
        static double radius;

        /// <summary>
        /// Creates cyllinder from area
        /// </summary>
        /// <param name="circumference">circumference of pipe</param>
        /// <param name="height">height of structure</param>
        public static void CreateCylinder(double circumference, double height)
        {
            HashSet<CylindricCoordinates> cylindricCoord = new HashSet<CylindricCoordinates>();
            //OneCrystalSize sMax = CreatedStructure.Instance.FindMaxDistanceAmongAtoms(); //TODO: az to milan schvali tak tohle smaz!
            //OneCrystalSize sMin = CreatedStructure.Instance.FindMinDistanceAmongAtoms();
            //circumference = Math.Abs(sMax.x - sMin.x);
            double halfY = height / 2;//Math.Abs(sMax.y - sMin.y);
            //double halfY = Math.Abs(sMax.y - sMin.y);
             radius = circumference / (2 * Math.PI) - halfY / 2; //radius of the circle with minimal deformation - axis leads throught the middle
            foreach (var item in CreatedStructure.Instance)
            {
                double r = item.y + radius;
                double fi = ((2 * Math.PI) / circumference) * item.x;
                CylindricCoordinates cc = new CylindricCoordinates(item.element, r, fi, item.z);
                if (!cylindricCoord.Contains(cc))
                {
                    cylindricCoord.Add(cc);
                }
            }
            CreatedStructure.Instance.Clear();
            foreach (var item in cylindricCoord)
            {
                double x = item.r * Math.Sin(item.angle); //TODO: spravne opacne
                double y = item.r * Math.Cos(item.angle);
                CartesianCoordinates cs = new CartesianCoordinates(item.element, x, y, item.z);
                CreatedStructure.Instance.Add(cs);
            }
        }
    }

    /// <summary>
    /// Creator of surface/area on x y z axis
    /// </summary>
    class CreatorOfSurface
    {
        public static OneCrystalSize crystalOneCrystalSize;
        public static bool angstroms = false;
        public static Vector crystalMoveX;
        public static Vector crystalMoveY;
        public static Vector crystalMoveZ;

        public static double[,] MatrixMultiply(double[,] m, double[,] n)
        {
            double[,] result = new double[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            double[,] c = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j] += m[i, k] * n[k, j];
                    }
                }
            }
            return c;
        }

        /// <summary>
        /// From crystal parameters recounts vectors of move
        /// </summary>
        /// <param name="cp">parameters of the crystal</param>
        /// <param name="axis">axis around which is rotated</param>
        public static void SetCrystalParams(CrystalParameters cp, String axis)
        {
            try
            {
                crystalMoveX = new Vector(cp.a, 0, 0);

                double gammaRad = Math.PI * (cp.gamma) / 180.0;
                double alphaRad = Math.PI * (cp.alpha) / 180.0;
                double betaRad = Math.PI * (cp.beta) / 180.0;
                double px = -cp.b * Math.Cos(gammaRad);
                double py = 0;
                double pz = cp.b * Math.Sin(gammaRad);
                if (cp.gamma!=90  && (axis == Axes.yFront.ToString() || axis == Axes.yBack.ToString()))
                {
                    pz *= -1;
                }
                crystalMoveZ = new Vector(px, py, pz);

                px = cp.c * Math.Cos(alphaRad);
                py = cp.c * Math.Sin(alphaRad)*Math.Sin(betaRad);
                pz = -cp.c * Math.Cos(betaRad);
                if (cp.alpha != 90 && (axis == Axes.yFront.ToString() || axis == Axes.yBack.ToString()))
                {
                    py *= -1;
                }
                crystalMoveY = new Vector(px, py, pz);

                //double betaRad = Math.PI * (cp.beta) / 180;
                //double alphaRad = Math.PI * (cp.alpha) / 180.0;

                //double volume = cp.a * cp.b * cp.c * Math.Sqrt(1 - Math.Pow(Math.Cos(alphaRad), 2) - Math.Pow(Math.Cos(betaRad), 2) - Math.Pow(Math.Cos(gammaRad), 2) + 2 * Math.Cos(alphaRad) * Math.Cos(betaRad) * Math.Cos(gammaRad));
                //double area = cp.a * cp.b * Math.Sin(gammaRad);
                //double altitude = volume / area;
                //px = cp.c * Math.Cos(alphaRad);
                //py = altitude;
                //pz = cp.c * Math.Cos(betaRad);


                //double alphaRadCosToSin = Math.PI * (90 - cp.alpha) / 180;
                //px = cp.c * Math.Sin(alphaRadCosToSin);

                //py = altitude;
                //pz = Math.Sqrt(Math.Pow(cp.c, 2) - Math.Pow(px, 2) - Math.Pow(py, 2));

                //double betaRad = Math.PI * (-(90 - cp.beta)) / 180; //tu na plus
                //double alphaRad = Math.PI * (-(90 - cp.alpha)) / 180.0;

                //double[,] Rzy = new double[,] { { 1, 0, 0 }, { 0, Math.Cos(betaRad), -Math.Sin(betaRad) }, { 0, Math.Sin(betaRad), Math.Cos(betaRad) } };
                //double[,] Rxy = new double[,] { { Math.Cos(alphaRad), -Math.Sin(alphaRad), 0 }, { Math.Sin(alphaRad), Math.Cos(alphaRad), 0 }, { 0, 0, 1 } };
                //double[,] Rfin = MatrixMultiply(Rzy, Rxy);
                //double[,] vector = new double[,] { { 0, 0, 0 }, { cp.c, 0, 0 }, { 0, 0, 0 } };
                //double[,] res = MatrixMultiply(Rfin, vector);
                //px = res[0, 0];
                //py = res[1, 0];
                //pz = res[2, 0];
                //crystalMoveY = new Vector(px, py, pz);

                //Console.WriteLine(crystalMoveX.x + " " + crystalMoveX.y + " " + crystalMoveX.z);
                //Console.WriteLine(crystalMoveY.x + " " + crystalMoveY.y + " " + crystalMoveY.z);
                //Console.WriteLine(crystalMoveZ.x + " " + crystalMoveZ.y + " " + crystalMoveZ.z);
                //Console.WriteLine("===");
            }
            catch
            {
                CreatorWindow cw = new CreatorWindow();
                cw.ShowError("Invalid crystal parametres");
                return;
            }
        }

        /// <summary>
        /// Finds size of one crystal
        /// </summary>
        /// <returns>size of one crystal</returns>
        public static OneCrystalSize FindOneCrystalSizeOfCrystal()
        {
            OneCrystalSize sMax = OriginalCrystal.Instance.FindMaxDistanceAmongAtoms();
            OneCrystalSize sMin = OriginalCrystal.Instance.FindMinDistanceAmongAtoms();
            double OneCrystalSizeX = Math.Abs(sMax.x - sMin.x);
            double OneCrystalSizeY = Math.Abs(sMax.y - sMin.y);
            double OneCrystalSizeZ = Math.Abs(sMax.z - sMin.z);
            OneCrystalSize s = new OneCrystalSize(OneCrystalSizeX, OneCrystalSizeY, OneCrystalSizeZ);
            return s;
        }

        public static double repeatX;
        public static double repeatY;
        public static double repeatZ;

        public static void CreateSurfaceWidthX(double widthX, double wallWidth)
        {
            double repeats = widthX; //repeats are read from the params
            if (angstroms) //repeats mus be counted from the length
            {
                repeats = Math.Floor(widthX / wallWidth);
            }
            repeatX = Math.Round(repeats);

            int listCount = CreatedStructure.Instance.Count();
            HashSet<CartesianCoordinates> origAtoms = new HashSet<CartesianCoordinates>();

            for (int i = 0; i < (int)repeats; i++)
            {
                foreach (CartesianCoordinates cc in CreatedStructure.Instance)
                {
                    CartesianCoordinates c = new CartesianCoordinates(cc.element, cc.x + crystalMoveX.x * i, cc.y + crystalMoveX.y * i, cc.z + crystalMoveX.z * i);
                    if (!origAtoms.Contains(c))
                    {
                        origAtoms.Add(c);
                    }
                }
            }
            CreatedStructure.Instance.Clear();
            foreach (CartesianCoordinates cc in origAtoms)
            {
                CreatedStructure.Instance.Add(cc);
            }
        }

        public static void CreateSurfaceHeightY(double heigthY, double wallHeight)
        {
            double repeats = heigthY; //repeats are read from the params
            if (angstroms) //repeats mus be counted from the length
            {
                repeats = Math.Floor(heigthY / wallHeight);
            }
            repeatY = Math.Round(repeats);

            int listCount = CreatedStructure.Instance.Count();
            HashSet<CartesianCoordinates> origAtoms = new HashSet<CartesianCoordinates>();

            for (int i = 0; i < (int)repeats; i++)
            {
                foreach (CartesianCoordinates cc in CreatedStructure.Instance)
                {
                    CartesianCoordinates c = new CartesianCoordinates(cc.element, cc.x + crystalMoveY.x * i, cc.y + crystalMoveY.y * i, cc.z + crystalMoveY.z * i);
                    if (!origAtoms.Contains(c))
                    {
                        origAtoms.Add(c);
                    }
                }
            }
            CreatedStructure.Instance.Clear();
            foreach (CartesianCoordinates cc in origAtoms)
            {
                CreatedStructure.Instance.Add(cc);
            }
        }
        public static void CreateSurfaceDepthZ(double depthZ, double wallDepth)
        {
            double repeats = depthZ; //repeats are read from the params           
            if (angstroms) //repeats mus be counted from the length
            {
                repeats = Math.Floor(depthZ / wallDepth);
            }
            repeatZ = repeats;

            int listCount = CreatedStructure.Instance.Count();
            HashSet<CartesianCoordinates> origAtoms = new HashSet<CartesianCoordinates>();

            for (int i = 0; i < (int)repeats; i++)
            {
                foreach (CartesianCoordinates cc in CreatedStructure.Instance)
                {
                    CartesianCoordinates c = new CartesianCoordinates(cc.element, cc.x + crystalMoveZ.x * i, cc.y + crystalMoveZ.y * i, cc.z + crystalMoveZ.z * i);
                    if (!origAtoms.Contains(c))
                    {
                        origAtoms.Add(c);
                    }
                }
            }
            CreatedStructure.Instance.Clear();
            foreach (CartesianCoordinates cc in origAtoms)
            {
                CreatedStructure.Instance.Add(cc);
            }
        }

        public static void MoveMinToZero(OneCrystalSize sMin)
        {
            foreach (CartesianCoordinates c in CreatedStructure.Instance)
            {
                c.x = c.x - sMin.x;
                c.y = c.y - sMin.y;
                c.z = c.z - sMin.z;
            }
        }

        public static void MoveMaxToZero(OneCrystalSize sMax)
        {
            foreach (CartesianCoordinates c in CreatedStructure.Instance)
            {
                c.x = c.x - sMax.x - 1;
                c.y = c.y - sMax.y - 1;
                c.z = c.z - sMax.z - 1;
            }
        }

        /// <summary>
        /// Creating of all surface to all three axes
        /// </summary>
        /// <param name="widthX">required width of area</param>
        /// <param name="heightY">required height of area</param>
        /// <param name="depthZ">required depth of area</param>
        /// /// <param name="cp">parameters of input crystal</param>
        /// /// <param name="axis">axis around which the crystal is rotated</param>
        public static void CreateSurface(CrystalParameters cp,double widthX, double heightY, double depthZ, string axis)
        {
            List<CartesianCoordinates> tmp = new List<CartesianCoordinates>();
            crystalOneCrystalSize = FindOneCrystalSizeOfCrystal();
            OneCrystalSize sMax = CreatedStructure.Instance.FindMaxDistanceAmongAtoms();
            OneCrystalSize sMin = CreatedStructure.Instance.FindMinDistanceAmongAtoms();
            MoveMinToZero(sMin);
            if (widthX != 0)
            {
                CreateSurfaceWidthX(widthX, cp.a);
            }
            CreateSurfaceHeightY(heightY, cp.c);
            CreateSurfaceDepthZ(depthZ, cp.b);
        }
    }

    static class Program
    {
        /// <summary>
        /// Function that reads input file, set parametres and then recounts spiral structure coordinates
        /// </summary>
        /// <param name="cp">parameters of the crystal</param>
        /// <param name="sp">parameters of the spiral</param>
        /// <param name="inputFile">name of input file with one cell's atoms</param>
        /// <param name="axis">axis and direction to build structure around</param>
        public static void CreateSpiral(CrystalParameters cp, SpiralParameters sp, string inputFile, string axis)
        {
            CreatedStructure.Instance.Clear();           
            LoaderAndSaver.LoadFile(inputFile);
            CrystalParameters recountedCp = RotatorOfCrystal.RotateCrystalRoundAxis(axis, cp);
            CreatorOfSurface.SetCrystalParams(recountedCp, axis);
            CreatorOfSurface.CreateSurface(recountedCp, 0, sp.wallWidth, sp.depth, axis);

            int repeats = 0; //count how many times the basic cell should repeat in the structure

            if (!CreatorOfSurface.angstroms) //repeats must be counted from the length
            {
                repeats = (int)sp.circumference;
                sp.circumference = sp.circumference * recountedCp.a;
            }
            else
            {
                repeats = (int)Math.Round(sp.circumference / recountedCp.a);
            } 
            CreatorOfSpiral.CreateSpiral(sp.move, sp.climb, sp.circumference, recountedCp.b, repeats);

        }

        /// <summary>
        /// Function that reads input file, set parametres and then recounts pipe structure coordinates
        /// </summary>
        /// <param name="cp">parameters of the crystal</param>
        /// <param name="sp">parameters of the pipe</param>
        /// <param name="inputFile">name of input file with one cell's atoms</param>
        /// <param name="axis">axis and direction to build structure around</param>
        public static void CreatePipe(CrystalParameters cp, CylinderParameters pp, string inputFile, string axis)
        {
            CreatedStructure.Instance.Clear();
            LoaderAndSaver.LoadFile(inputFile);
            CrystalParameters recountedCp = RotatorOfCrystal.RotateCrystalRoundAxis(axis, cp);
            CreatorOfSurface.SetCrystalParams(recountedCp, axis);
            CreatorOfSurface.CreateSurface(recountedCp, pp.circumference, pp.wallWidth, pp.depth, axis);
            double circ = (CreatorOfSurface.repeatX) * recountedCp.a;
            double height = (CreatorOfSurface.repeatY) * recountedCp.c;
            CreatorOfCylinder.CreateCylinder(circ, height);
        }


        /// <summary>
        /// Function that reads input file, set parametres and then recounts plane structure coordinates
        /// </summary>
        /// <param name="cp">parameters of the crystal</param>
        /// <param name="sp">parameters of the pipe</param>
        /// <param name="inputFile">name of input file with one cell's atoms</param>
        /// <param name="axis">axis and direction to build structure around</param>
        public static void CreatePlane(CrystalParameters cp, PlanarParameters pp, string inputFile, string axis)
        {
            CreatedStructure.Instance.Clear();
            LoaderAndSaver.LoadFile(inputFile);
            CrystalParameters recountedCp = RotatorOfCrystal.RotateCrystalRoundAxis(axis, cp);
            CreatorOfSurface.SetCrystalParams(recountedCp, axis);
            CreatorOfSurface.CreateSurface(recountedCp, pp.width, pp.heigth, pp.depth, axis);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CreatorWindow());
        }
    }
}