using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data;

namespace Fleet_Manager
{
    /// <summary>
    /// Class for the Vehicle object containing its attributes.
    ///  Registration Number, Make, Model, Fuel Type, Category, Latitude, Longitude
    /// </summary>
    public class ObjVehicle
    {
        //Declaring the attributes of a Vehicle
        public string? RegistrationNumber { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? FuelType { get; set; }
        public string? Category { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }

        //constructor used to create a new object of the class vehicle.
        public ObjVehicle(string registrationNumber, string make, string model, string fuelType, string category, double lat, double lng)
        {
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;
            FuelType = fuelType;
            Category = category;
            Lat = lat;
            Lng = lng;
        }
    }

    /// <summary>
    /// Class for the Customer object containing its attributes.
    ///  Name
    /// </summary>
    public class ObjCustomer
    {
        //Declaring the attributes of a Customer
        public string? Name { get; set; }
        public string? Type { get; set; }

        //constructor used to create a new object of the class Customer.
        public ObjCustomer(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }





    public partial class FleetManager : Form
    {
        public FleetManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GMaps.net implementation. Builder for initializing the map and its starting parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FleetManager_Load(object sender, EventArgs e)
        {
            //Configuring map controller to access map service
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //setting map type as Google maps others available e.g bing
            gMapControl1.Position = new GMap.NET.PointLatLng(50.39946444099402, -4.133717229736622); //sets starting position on load
            gMapControl1.Zoom = 12; // setting start up zoom
        }

        /// <summary>
        /// A function to create a marker with specific locations and correct icon based of the Vehicle class's category
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns>Marker with positions and icon based on vehicle type</returns>
        private GMarkerGoogle CreateVehicleMarker(ObjVehicle vehicle, double latitude, double longitude)
        {
            //declaring storage location of Specific Icons
            string SmallCar = "D:/VS Projects/Hire Car Fleet Tracker/Media/car3.png";
            string EstateCar = "D:/VS Projects/Hire Car Fleet Tracker/Media/sedan3.png";
            string Van = "D:/VS Projects/Hire Car Fleet Tracker/Media/truck3.png";

            GMarkerGoogle marker; 

            //If else Statements to Declare which icon should be displayed based of the Vehicle.Catogory Attribute
            if (vehicle.Category == "Small Car")
            {
                //Create new marker with location and Icon choice
                marker = new GMarkerGoogle(new GMap.NET.PointLatLng(latitude, longitude), new Bitmap(SmallCar));
            }
            else if (vehicle.Category == "Estate Car")
            {
                //Create new marker with location and Icon choice
                marker = new GMarkerGoogle(new GMap.NET.PointLatLng(latitude, longitude), new Bitmap(EstateCar));
            }
            else if (vehicle.Category == "Van")
            {
                //Create new marker with location and Icon choice
                marker = new GMarkerGoogle(new GMap.NET.PointLatLng(latitude, longitude), new Bitmap(Van));
            }
            else
            {
                // Default marker if no specific category match
                marker = new GMarkerGoogle(new GMap.NET.PointLatLng(latitude, longitude), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_small);
            }
            //Creating mouse hover info box
            marker.ToolTipText = GetTooltipText(vehicle);

            return marker;
        }

        /// <summary>
        /// Function to create GMaps built in pop-up tool-tips containing all the information regarding the vehicle and the customer
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns>String for a tool tip with vehicle/customer details</returns>
        private string GetTooltipText(ObjVehicle vehicle)
        {
            //Mouse Hover Details Formatting 
            return $"Vehicle Details\n------------------------\nReg #: {vehicle.RegistrationNumber}\nMake: {vehicle.Make}\nModel: {vehicle.Model}\nFuelType: {vehicle.FuelType}\nCategory: {vehicle.Category}\n\nClient Name: John";
        }

        //Setting Default Style for Information pop-up box     
        private void SetMarkerToolTipStyle(GMapMarker marker, Font font, Brush foreground, Brush background, Pen border, Size textPadding)
        {
            //Setting the Style of Pop-up box
            marker.ToolTip.Font = font;
            marker.ToolTip.Foreground = foreground;
            marker.ToolTip.Fill = background;
            marker.ToolTip.Stroke = border;
            marker.ToolTip.TextPadding = textPadding;
        }
    }
}

