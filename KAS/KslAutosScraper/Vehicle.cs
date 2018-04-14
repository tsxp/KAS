using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KAS.KslAutosScraper
{
    public class KslVehicleInfo
    {
        //KSL Ad General Info
        long? listNo;
        int? cost;
        bool? isDealer;
        string postDate;
        string location;
        string contactName;
        string contactNumber;
        string contactCell;


        //Vehicle Info
        KslImage img;
        short? year;
        string make;
        string model;
        string trim;
        string body;
        int? mileage;
        string vin;
        string extColor;
        string transmission;
        string intColor;
        string liters;
        string cylinders;
        string driveType;

        public long? ListNo { get => listNo; set => listNo = value; }
        public int? Cost { get => cost; set => cost = value; }
        public bool? IsDealer { get => isDealer; set => isDealer = value; }
        public string PostDate { get => postDate; set => postDate = value; }
        public string Location { get => location; set => location = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string ContactCell { get => contactCell; set => contactCell = value; }
        public KslImage Img { get => img; set => img = value; }
        public short? Year { get => year; set => year = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Trim { get => trim; set => trim = value; }
        public string Body { get => body; set => body = value; }
        public int? Mileage { get => mileage; set => mileage = value; }
        public string Vin { get => vin; set => vin = value; }
        public string ExtColor { get => extColor; set => extColor = value; }
        public string Transmission { get => transmission; set => transmission = value; }
        public string IntColor { get => intColor; set => intColor = value; }
        public string Liters { get => liters; set => liters = value; }
        public string Cylinders { get => cylinders; set => cylinders = value; }
        public string DriveType { get => driveType; set => driveType = value; }
    }
}
