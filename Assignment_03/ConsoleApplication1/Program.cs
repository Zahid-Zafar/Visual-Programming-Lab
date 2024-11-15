using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void CreateGPSFile(string fileName)
        {
            // Improved data with proper date format and realistic speed
            DateTime dateTime = DateTime.UtcNow; // Use UTC for consistent time zone
            double xCoordinate = 65.8973342;
            double yCoordinate = 72.3452346;
            int speed = 55; // Realistic speed
            int numberOfSatellites = 8;
            string imagePath = @"\images\1.jpg"; // Replace with actual image path if applicable

            try
            {
                using (XmlWriter writer = XmlWriter.Create(fileName, new XmlWriterSettings { Indent = true }))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("GPS_Log");


                    writer.WriteStartElement("Position");
                    writer.WriteAttributeString("DateTime", dateTime.ToString("yyyy-MM-dd HH:mm:ss")); // Use ISO 8601 format
                    writer.WriteElementString("x", xCoordinate.ToString());
                    writer.WriteElementString("y", yCoordinate.ToString());

                    writer.WriteStartElement("SatteliteInfo");
                    writer.WriteElementString("Speed", speed.ToString());
                    writer.WriteElementString("NoSatt", numberOfSatellites.ToString());
                    writer.WriteEndElement();

                    writer.WriteEndElement(); // Position

                    writer.WriteStartElement("Image");
                    writer.WriteAttributeString("Resolution", "1024x800");
                    writer.WriteElementString("Path", imagePath);
                    writer.WriteEndElement();

                    writer.WriteEndElement(); // GPS_Log
                    writer.WriteEndDocument();
                }

                Console.WriteLine("GPS data successfully written to '{0}'.", fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating GPS file: {0}", ex.Message);
            }
        }

        static void ReadGPSData(string fileName)
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)

                        {
                            switch (reader.Name)
                            {
                                case
     "GPS_Log":
                                    Console.WriteLine("----- GPS Log -----");
                                    break;
                                case "Position":
                                    Console.WriteLine("** Position **");
                                    break;
                                case "SatteliteInfo":
                                    Console.WriteLine("** Satellite Info **");
                                    break;
                                case "Image":
                                    Console.WriteLine("** Image **");
                                    break;
                                case "DateTime":
                                    Console.Write("  Date/Time: ");
                                    reader.Read(); // Move to the value
                                    Console.WriteLine(reader.Value);
                                    break;
                                case "x":
                                    Console.Write("  X-Coordinate: ");
                                    reader.Read(); // Move to the value
                                    Console.WriteLine(reader.Value);
                                    break;
                                case "y":
                                    Console.Write("  Y-Coordinate: ");
                                    reader.Read(); // Move to the value
                                    Console.WriteLine(reader.Value);
                                    break;
                                case "Speed":
                                    Console.Write("  Speed: ");
                                    reader.Read(); // Move to the value
                                    Console.WriteLine(reader.Value);
                                    break;
                                case "NoSatt":
                                    Console.Write("  Number of Satellites: ");
                                    reader.Read(); // Move to the value
                                    Console.WriteLine(reader.Value);
                                    break;
                                case "Path":
                                    Console.Write("  Image Path: ");
                                    reader.Read(); // Move to the value
                                    Console.WriteLine(reader.Value);
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading GPS file: {0}", ex.Message);
            }
        }

        static void Main(string[] args)
        {
            string filename = "GPS.xml";
            // Function Call to create file and store data
            CreateGPSFile(filename);
            // Function Call to get data from file and display on screen
            ReadGPSData(filename);
            Console.ReadKey();
        }
    }
}
