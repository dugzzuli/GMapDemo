using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System.IO;

namespace GMapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bing混合地图  
            gMap.MapProvider = GMapProviders.BingHybridMap;

            //离线模式  
            gMap.Manager.Mode = AccessMode.CacheOnly;
            String mapPath = @"F:\\DataExp.gmdb";
            if (File.Exists(mapPath))
            {
                MessageBox.Show("文件存在");
            }
            GMap.NET.GMaps.Instance.ImportFromGMDB(mapPath);

            //地图中心位置  
            gMap.SetPositionByKeywords("beijing, china");
            gMap.Position = new PointLatLng(39.185422, 112.252810);  //中心点的纬度，经度       

            //不显示中心十字点  
            gMap.ShowCenter = false;
            //左键拖拽地图  
            gMap.DragButton = MouseButtons.Left;
            gMap.MinZoom = 2;   //最小缩放  
            gMap.MaxZoom = 18;  //最大缩放  
            gMap.Zoom = 6;      //当前缩放 
                                //地图由三层组成。最上层:GMapMarker，中间层:GMapOverlay，最底层:GMapControls　  
            GMapOverlay gMapOverlay = new GMapOverlay("markers");

            //起点水滴标记
            PointLatLng start = new PointLatLng(40.187163, 116.18927);  //路径起点  
            GMapMarker gMapMarker = new GMarkerGoogle(start, GMarkerGoogleType.green);
            gMapOverlay.Markers.Add(gMapMarker);                      //向图层中添加标记   
            gMap.Overlays.Add(gMapOverlay);                           //向控件中添加图层    

            //终点水滴标记  
            PointLatLng end = new PointLatLng(38.807905, 111.623768);   //路径终点  
            gMapMarker = new GMarkerGoogle(end, GMarkerGoogleType.green);
            gMapOverlay.Markers.Add(gMapMarker);                      //向图层中添加标记    
            gMap.Overlays.Add(gMapOverlay);
            //根据起止点start、end和当前的zoom查找路径  
            MapRoute route = GMap.NET.MapProviders.BingHybridMapProvider.Instance.GetRoute(start, end, false, false, (int)gMap.Zoom);
            if (route != null)
            {
                //将路转换成线   
                GMapRoute r = new GMapRoute(route.Points, route.Name);
                gMapOverlay.Routes.Add(r);           //向图层中添加道路  
                gMap.Overlays.Add(gMapOverlay);      //向控件中添加图层     
                r.Stroke.Width = 3;                  //路径宽度  
                r.Stroke.Color = Color.Red;          //路径颜色  
            }

        }
    }
}
