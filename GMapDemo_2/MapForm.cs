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
        private GMapOverlay objects; //放置marker的图层
        private GMapOverlay routes;
        private GMapOverlay polygons = new GMapOverlay("polygon"); //放置polygon的图层
        private GMapPolygon drawingPolygon = null; //正在画的polygon
        private List<PointLatLng> drawingPoints = new List<PointLatLng>(); //多边形的点集

        public static Dictionary<string, PointLatLng> dict = new Dictionary<string, PointLatLng>();
        public static Dictionary<string, string> dictPlace = new Dictionary<string, string>();
        private static int count = 1;
        private GMapPolygon currentPolygon;

        private bool isLeftButtonDown = false;
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




            //mapControl.Position = new PointLatLng(45.74740199642105, 126.69570922851562);
            mapControl.SetPositionByKeywords("china,kunming");//设置初始中心为china harbin


            this.routes = new GMapOverlay("routes");
            this.mapControl.Overlays.Add(this.routes);
            this.objects = new GMapOverlay("objects");
            this.mapControl.Overlays.Add(this.objects);
            this.mapControl.Overlays.Add(this.polygons);
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

            addPoint add = new addPoint();
            add.ShowDialog();
            PointLatLng point = mapControl.FromLocalToLatLng(Convert.ToInt32(latText.Text), Convert.ToInt32(lngText.Text));


            

            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green);
            marker.ToolTipText = add.text;
            marker.ToolTipMode = MarkerTooltipMode.Always;
            markersOverlay.Markers.Add(marker);
            dict.Add(Convert.ToString(count), point);
            dictPlace.Add(Convert.ToString(count), add.text);
            count += 1;
            add.Dispose();
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
            DrawrouteBetweenTowPoint(pointLatLng_S, pointLatLng_E, add.c);
            add.Dispose();

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

        private void 保存地图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "PNG (*.png)|*.png";
                    dialog.FileName = "GMap.NET image";
                    Image image = this.mapControl.ToImage();
                    if (image != null)
                    {
                        using (image)
                        {
                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                string fileName = dialog.FileName;
                                if (!fileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                                {
                                    fileName += ".png";
                                }
                                image.Save(fileName);
                                MessageBox.Show("图片已保存： " + dialog.FileName, "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("图片保存失败： " + exception.Message, "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mapControl.Zoom += 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mapControl.Zoom -= 1;

        }

        private void MapForm_SizeChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(panel1.Location.ToString());
            //panel1.Location = new Point(mapControl.Width - 80,10);
        }

        private void select_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂时无法使用。。。。。");
            return;

            if (this.txtAddress.Text.Length == 0)
            {
                this.txtAddress.Focus();
                MessageBox.Show("请输入查询的地址");
            }

            string search = string.Format("{0},{1}", this.txtCity.Text, this.txtAddress.Text);
            GeoCoderStatusCode code = this.mapControl.SetPositionByKeywords(search);

            if (code != GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                MessageBox.Show("地址没有找到：'" + this.txtAddress.Text + "', 原因：" + code.ToString(), "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.objects.Markers.Clear();
            AddLocation(this.txtAddress.Text);
        }

        private void AddLocation(string place)
        {

        }

        private void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isLeftButtonDown = true;

                if (checkBoxDrawPolygon.Checked)
                {
                    drawingPoints.Add(mapControl.FromLocalToLatLng(e.X, e.Y));
                    if (drawingPolygon == null)
                    {
                        
                        drawingPolygon = new GMapPolygon(drawingPoints, "my polygon");
                        drawingPolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                        drawingPolygon.Stroke = new Pen(Color.Blue, 2);
                        drawingPolygon.IsHitTestVisible = true;
                        polygons.Polygons.Add(drawingPolygon);
                    }
                    else
                    {
                        drawingPolygon.Points.Clear();
                        drawingPolygon.Points.AddRange(drawingPoints);
                        if (polygons.Polygons.Count == 0)
                        {
                            polygons.Polygons.Add(drawingPolygon);
                        }
                        else
                        {
                            mapControl.UpdatePolygonLocalPosition(drawingPolygon);
                        }
                    }
                    mapControl.Refresh();
                }
                else if (drawYuan.Checked)
                {
                    GMapMarkerCircle
                }
            }
        }

        private void mapControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (checkBoxDrawPolygon.Checked && drawingPolygon != null)
            {
                polygons.Polygons.Add(drawingPolygon);
                drawingPolygon = null;
                drawingPoints.Clear();
            }
        }

        private void mapControl_OnPolygonLeave(GMapPolygon item)
        {
            currentPolygon = null;
            item.Stroke.Color = Color.MidnightBlue;
        }

        private void mapControl_MouseEnter(object sender, EventArgs e)
        {

        }

        private void mapControl_OnPolygonEnter(GMapPolygon item)
        {
            currentPolygon = item;
            item.Stroke.Color = Color.Red;
        }
    }
}