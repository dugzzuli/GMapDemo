using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpMapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SharpMap.Map myMap = new SharpMap.Map(picMap.Size);
            SharpMap.Layers.VectorLayer myLayer = new SharpMap.Layers.VectorLayer("My layer");
            myMap.Layers.Add(myLayer);
            myLayer.DataSource = new SharpMap.Data.Providers.ShapeFile(@"data/cities.shp",true);   //
            myLayer.Style.Fill = new SolidBrush(Color.Green);
            myLayer.Style.Outline = System.Drawing.Pens.Black;
          
            myMap.MaximumZoom = 360;
            // 设置地图最大可视水平经度区域，单位为度

            myMap.BackColor = Color.LightBlue;
            // 设置地图背景颜色
  myMap.Zoom = 360;

            // 设置地图初始可视水平经度区域，360 显示整个世界地图

            myMap.GetMap();
            // 设置初始显示地图中心坐标
            picMap.Image = myMap.GetMap();
        }
    }
}
