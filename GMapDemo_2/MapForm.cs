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

        public MapForm()
        {
            InitializeComponent();

            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("ditu.google.cn");
            }
            catch
            {
                mapControl.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.", "GMap.NET Demo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            mapControl.CacheLocation = Environment.CurrentDirectory + "\\GMapCache\\"; //缓存位置
            mapControl.MapProvider = GMapProviders.GoogleChinaMap; //google china 地图
            mapControl.MinZoom = 2;  //最小比例
            mapControl.MaxZoom = 24; //最大比例
            mapControl.Zoom = 10;     //当前比例
            mapControl.ShowCenter = false; //不显示中心十字点
            mapControl.DragButton = System.Windows.Forms.MouseButtons.Left; //左键拖拽地图

            var point=MapControl.MousePosition;
            
             
            mapControl.Position = new PointLatLng(45.74740199642105, 126.69570922851562);

            mapControl.Overlays.Add(markersOverlay);

            //mapControl.MouseClick += new MouseEventHandler(mapControl_MouseClick);
        }

        void mapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                PointLatLng point = mapControl.FromLocalToLatLng(e.X, e.Y);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green);
                markersOverlay.Markers.Add(marker);
            }
        }

        private void mapControl_MouseMove(object sender, MouseEventArgs e)
        {
            var point = MapControl.MousePosition;
            
            latText.Text = e.X.ToString()+"    "+point.X;
            lngText.Text = e.Y.ToString()+"    "+point.Y;
        }

        private void CreatePoint_Click(object sender, EventArgs e)
        {
           
               
          
        }
    }
}