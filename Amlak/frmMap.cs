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


namespace Amlak
{
    public partial class frmMap : Form
    {
        public frmMap()
        {
            InitializeComponent();
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //کش فایلهای سازی ذخیره محل تنظیم
            string location = "E:\\Map\\gmap\\";
            gMap1.CacheLocation = location;
            //انتخاب نوع نقشه
            gMap1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //  نقشه در نمایش برای محل تنظیم
            gMap1.SetPositionByKeywords("shiraz");
            gMap1.Position = new PointLatLng(29.6057002815175, 52.5352478027344);
            //ماوس چپ دکمه از استفاده با نقشه کردن درگ و پیمیایش تنظیم//
            gMap1.DragButton = MouseButtons.Left;
            //   نقشه در اولیه زوم میزان تنظیم//
            gMap1.Zoom = 12;
            //  زوم میزان حداکثر تنظیم//
            gMap1.MaxZoom = 24;
            //   نقشه روی گذاری علامت قابلیت کردن فعال//
            gMap1.MarkersEnabled = true;
            gMap1.ContextMenuStrip = contextMenuStrip1;
        }
        double _lat, _lng;
        GMapMarker _marker;

        private void gMap1_MouseClick(object sender, MouseEventArgs e)
        {
            _lat = gMap1.FromLocalToLatLng(e.X, e.Y).Lat;
            _lng = gMap1.FromLocalToLatLng(e.X - 16, e.Y).Lng;
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _marker.Overlay.Markers.Remove(_marker);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void gMap1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            _marker = item;
        }

        private void علامتگذاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gMap1.Position = new PointLatLng(_lat, _lng);
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(_lat, _lng),
            GMarkerGoogleType.green);
            marker.Tag = new PointLatLng(_lat, _lng);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = _lat.ToString() + "--" + _lng.ToString();
            markersOverlay.Markers.Add(marker);
            gMap1.Overlays.Add(markersOverlay);
        }
    }
}
