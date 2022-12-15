using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using BusinessEntity;
using BusinessLogicLayer;

namespace Amlak
{
    public partial class frmShowLocation : Form
    {
        public frmShowLocation()
        {
            InitializeComponent();
        }
        public static double X;
        public static double Y;
        private void frmShowLocation_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //کش فایلهای سازی ذخیره محل تنظیم
            string location = "C:\\Map\\gmap\\";
            gMap1.CacheLocation = location;
            //انتخاب نوع نقشه
            gMap1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //  نقشه در نمایش برای محل تنظیم
            //gMap1.SetPositionByKeywords("shiraz");
            //gMap1.Position = new PointLatLng(29.6057002815175, 52.5352478027344);
            //ماوس چپ دکمه از استفاده با نقشه کردن درگ و پیمیایش تنظیم//
            gMap1.DragButton = MouseButtons.Left;
            //   نقشه در اولیه زوم میزان تنظیم//
            gMap1.Zoom = 18;
            //  زوم میزان حداکثر تنظیم//
            gMap1.MaxZoom = 24;
            //   نقشه روی گذاری علامت قابلیت کردن فعال//
            gMap1.MarkersEnabled = true;
            
            ////////
            gMap1.Position = new PointLatLng(X, Y);
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(X, Y),
            GMarkerGoogleType.green);
            marker.Tag = new PointLatLng(X, Y);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = X.ToString() + "--" + Y.ToString();
            markersOverlay.Markers.Add(marker);
            gMap1.Overlays.Add(markersOverlay);
        }
    }
}
