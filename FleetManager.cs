using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data;
using System.Xml.Linq;

namespace Fleet_Manager
{
    /// <summary>
    /// Class for the Vehicle object containing its attributes.
    ///  Registration Number, Make, Model, Fuel Type, Category, Latitude, Longitude
    /// </summary>
    public class Vehicle
    {
        //Declaring the attributes of a Vehicle
        public string? RegistrationNumber { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? FuelType { get; set; }
        public string? Category { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }

        //adding company details so that it can be implemented into a list to be used to create a marker.
        public string? Name { get; set; }
        public string? Type { get; set; }

        //constructor used to create a new object of the class vehicle.
        public Vehicle(string registrationNumber, string make, string model, string fuelType, string category, double lat, double lng, string name, string type)
        {
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;
            FuelType = fuelType;
            Category = category;
            Lat = lat;
            Lng = lng;
            //Customer details
            Name = name;
            Type = type;
        }
    }

    /// <summary>
    /// Class for the Customer object containing its attributes.
    ///  Name
    /// </summary>
    public class Customer
    {
        //Declaring the attributes of a Customer
        public string? Name { get; set; }
        public string? Type { get; set; }

        //constructor used to create a new object of the class Customer.
        public Customer(string name, string type)
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

            DisplayAllMarkers(); //function to display markers on the map.
        }

        /// <summary>
        /// A function to create a marker with specific locations and correct icon based of the Vehicle class's category
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns>Marker with positions and icon based on vehicle type</returns>
        private GMarkerGoogle CreateVehicleMarker(Vehicle vehicle, double latitude, double longitude)
        {
            //declaring storage location of Specific Icons
            string SmallCar = "D:/VS Projects/Fleet Manager/Media/car3.png";
            string EstateCar = "D:/VS Projects/Fleet Manager/Media/sedan3.png";
            string Van = "D:/VS Projects/Fleet Manager/Media/truck3.png";

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
        private string GetTooltipText(Vehicle vehicle)
        {
            //Mouse Hover Details Formatting 
            //all details are stored in a list based on the vehicle class... need to add ability to merge 2 classes to create a list of vehicles
            return $"Vehicle Details\n------------------------\nReg #: {vehicle.RegistrationNumber}\nMake: {vehicle.Make}\nModel: {vehicle.Model}\nFuelType: {vehicle.FuelType}\nCategory: {vehicle.Category}\n\nCustomer Details\n------------------------\nCustomer Name: {vehicle.Name}\nOwner Type: {vehicle.Type}";
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
        /// <summary>
        /// Function to Display markers on the map
        /// </summary>
        private void DisplayAllMarkers()
        {

            // Create the font and styling for tool tips
            Font tooltipFont = new Font("Roboto", 11, FontStyle.Regular); //Set Font,Size,Style
            Brush tooltipForeground = Brushes.Black; //set foreground colour/ text colour
            Brush tooltipBackground = Brushes.White; //set background colour
            Pen tooltipBorder = Pens.Black; //set boarder colour
            Size tooltipTextPadding = new Size(10, 10);

            //Creates a list called vehicles that will store all defined vehicles
            List<Vehicle> vehicles = new List<Vehicle>();


            // Add vehicles to the list
            //all details are stored in a list based on the vehicle class... need to add ability to merge 2 classes to create a list of vehicles
            vehicles.Add(new Vehicle("DE34 LMN", "Ford", "Focus", "Petrol", "Small Car", 50.37941922201558, -4.13156834670998,"John West LTD","Business"));
            vehicles.Add(new Vehicle("AB12 XYZ", "Toyota", "Corolla", "Diesel", "Estate Car", 50.38271866313328, -4.142071723899841,"David Tuna", "Personal"));
            vehicles.Add(new Vehicle("FG56 PQR", "Ford", "Transit", "Diesel", "Van", 50.37517072091145, -4.118627957575973,"John West LTD", "Business"));
            vehicles.Add(new Vehicle("GH78 ABC", "Honda", "Civic", "Petrol", "Small Car", 50.38492710376232, -4.135480901453018,"Robert Dean", "Personal"));
            vehicles.Add(new Vehicle("JK90 DEF", "Toyota", "Yaris", "Petrol", "Estate Car", 50.37759356140106, -4.129642309585571,"Adam Snow", "Personal"));

            //Create a new list to store all the markers that need to be created based on the Vehicle object
            List<GMarkerGoogle> markers = new List<GMarkerGoogle>();

            //Adding ability to add markers
            GMapOverlay MarkerOverlay = new GMapOverlay("markers");

            // Create the markers using the CreateVehicleMarker function
            foreach (Vehicle vehicle in vehicles)
            {
                GMarkerGoogle marker = CreateVehicleMarker(vehicle, vehicle.Lat, vehicle.Lng);
                markers.Add(marker);
                MarkerOverlay.Markers.Add(marker);
            }

            foreach (GMarkerGoogle marker in markers)
            {
                SetMarkerToolTipStyle(marker, tooltipFont, tooltipForeground, tooltipBackground, tooltipBorder, tooltipTextPadding);
            }

            //Add the overlay containing the markers to the map
            gMapControl1.Overlays.Add(MarkerOverlay);

            //Bug fix allows the map to update and all the markers to be displayed without this no markers will show unless user scrolls the map.
            gMapControl1.Zoom += 1;
            gMapControl1.Zoom -= 1;

            //Updates map
            gMapControl1.Update();
            gMapControl1.Refresh();
        }
    }
}

