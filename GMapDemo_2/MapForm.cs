using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMapDemo_2
{
    public partial class MapForm : Form
    {
        private GMapOverlay markersOverlay = new GMapOverlay("markers"); //放置marker的图层
        public static Dictionary<string, PointLatLng> dict = new Dictionary<string, PointLatLng>();
        public static Dictionary<string, string> dictPlace = new Dictionary<string, string>();
        private static int count = 1;
        public MapForm()
        {
            InitializeComponent();

            //try
            //{
            //    System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("ditu.google.cn");
            //}
            //catch
            //{
            //    mapControl.Manager.Mode = AccessMode.CacheOnly;
            //    MessageBox.Show("No internet connection avaible, going to CacheOnly mode.", "GMap.NET Demo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            mapControl.CacheLocation = Environment.CurrentDirectory + "\\GMapCache\\"; //缓存位置
            mapControl.MapProvider = GMapProviders.OpenStreetMap; //google china 地图
            mapControl.MinZoom = 2;  //最小比例
            mapControl.MaxZoom = 24; //最大比例
            mapControl.Zoom = 15;     //当前比例
            mapControl.ShowCenter = false; //不显示中心十字点
            mapControl.DragButton = System.Windows.Forms.MouseButtons.Left; //左键拖拽地图

            var point = MapControl.MousePosition;


            mapControl.Position = new PointLatLng(45.74740199642105, 126.69570922851562);

            mapControl.Overlays.Add(markersOverlay);


        }



        private void mapControl_MouseMove(object sender, MouseEventArgs e)
        {
            var point = MapControl.MousePosition;

            latText.Text = e.X.ToString();
            lngText.Text = e.Y.ToString();
        }

        private void CreatePoint_Click(object sender, EventArgs e)
        {

            addPoint add=new addPoint();
            add.ShowDialog();
            PointLatLng point = mapControl.FromLocalToLatLng(Convert.ToInt32(latText.Text), Convert.ToInt32(lngText.Text));
            
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green);
            marker.ToolTipText = add.text;
            marker.ToolTipMode = MarkerTooltipMode.Always;
            markersOverlay.Markers.Add(marker);
            dict.Add(Convert.ToString(count), point);
            dictPlace.Add(Convert.ToString(count),add.text);
            count += 1;
        }

        private void DrawrouteBetweenTowPoint(PointLatLng pointLatLng_S, PointLatLng pointLatLng_E)
        {
            RoutingProvider rp = mapControl.MapProvider as RoutingProvider;
            if (rp == null)
            {
                rp = GMapProviders.OpenStreetMap;
            }
            MapRoute route = rp.GetRoute(pointLatLng_S, pointLatLng_E, false, false, (int)mapControl.Zoom);
            if (route != null)
            {
                GMapRoute r = new GMapRoute(route.Points, route.Name);
                markersOverlay.Routes.Add(r);
                 mapControl.ZoomAndCenterRoute(r);
            }
        }

        private void 新建路线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            addPointRoute add = new addPointRoute();
            add.ShowDialog();
            PointLatLng pointLatLng_S = dict[add.start1];
            PointLatLng pointLatLng_E = dict[add.end2];
            DrawrouteBetweenTowPoint(pointLatLng_S, pointLatLng_E,add.c);

        }

        private void DrawrouteBetweenTowPoint(PointLatLng pointLatLng_S, PointLatLng pointLatLng_E, Color c)
        {
            RoutingProvider rp = mapControl.MapProvider as RoutingProvider;
            if (rp == null)
            {
                rp = GMapProviders.OpenStreetMap;
            }
            MapRoute route = rp.GetRoute(pointLatLng_S, pointLatLng_E, false, false, (int)mapControl.Zoom);
            if (route != null)
            {
                GMapRoute r = new GMapRoute(route.Points, route.Name);
                //r.Stroke.Width = 3;                  //路径宽度  
                r.Stroke.Color = c;          //路径颜色  
                markersOverlay.Routes.Add(r);
                mapControl.ZoomAndCenterRoute(r);
            }
        }
    }
}