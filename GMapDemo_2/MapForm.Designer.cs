namespace GMapDemo_2
{
    partial class MapForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusWin = new System.Windows.Forms.StatusStrip();
            this.lat = new System.Windows.Forms.ToolStripStatusLabel();
            this.latText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lng = new System.Windows.Forms.ToolStripStatusLabel();
            this.lngText = new System.Windows.Forms.ToolStripStatusLabel();
            this.GMapMean = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreatePoint = new System.Windows.Forms.ToolStripMenuItem();
            this.mapControl = new GMapDemo_2.MapControl();
            this.statusWin.SuspendLayout();
            this.GMapMean.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusWin
            // 
            this.statusWin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lat,
            this.latText,
            this.lng,
            this.lngText});
            this.statusWin.Location = new System.Drawing.Point(0, 373);
            this.statusWin.Name = "statusWin";
            this.statusWin.Size = new System.Drawing.Size(520, 22);
            this.statusWin.TabIndex = 1;
            this.statusWin.Text = "statusStrip1";
            // 
            // lat
            // 
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(22, 17);
            this.lat.Text = "lat";
            // 
            // latText
            // 
            this.latText.Name = "latText";
            this.latText.Size = new System.Drawing.Size(15, 17);
            this.latText.Text = "0";
            // 
            // lng
            // 
            this.lng.Name = "lng";
            this.lng.Size = new System.Drawing.Size(26, 17);
            this.lng.Text = "lng";
            // 
            // lngText
            // 
            this.lngText.Name = "lngText";
            this.lngText.Size = new System.Drawing.Size(15, 17);
            this.lngText.Text = "0";
            // 
            // GMapMean
            // 
            this.GMapMean.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatePoint});
            this.GMapMean.Name = "GMapMean";
            this.GMapMean.Size = new System.Drawing.Size(153, 48);
            // 
            // CreatePoint
            // 
            this.CreatePoint.Name = "CreatePoint";
            this.CreatePoint.Size = new System.Drawing.Size(152, 22);
            this.CreatePoint.Text = "新建地点";
            this.CreatePoint.Click += new System.EventHandler(this.CreatePoint_Click);
            // 
            // mapControl
            // 
            this.mapControl.Bearing = 0F;
            this.mapControl.CanDragMap = true;
            this.mapControl.ContextMenuStrip = this.GMapMean;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControl.GrayScaleMode = false;
            this.mapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControl.LevelsKeepInMemmory = 5;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.MarkersEnabled = true;
            this.mapControl.MaxZoom = 2;
            this.mapControl.MinZoom = 2;
            this.mapControl.MouseWheelZoomEnabled = true;
            this.mapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControl.Name = "mapControl";
            this.mapControl.NegativeMode = false;
            this.mapControl.PolygonsEnabled = true;
            this.mapControl.RetryLoadTile = 0;
            this.mapControl.RoutesEnabled = true;
            this.mapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapControl.ShowTileGridLines = false;
            this.mapControl.Size = new System.Drawing.Size(520, 395);
            this.mapControl.TabIndex = 0;
            this.mapControl.Zoom = 0D;
            this.mapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseMove);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 395);
            this.Controls.Add(this.statusWin);
            this.Controls.Add(this.mapControl);
            this.Name = "MapForm";
            this.Text = "Form1";
            this.statusWin.ResumeLayout(false);
            this.statusWin.PerformLayout();
            this.GMapMean.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl;
        private System.Windows.Forms.StatusStrip statusWin;
        private System.Windows.Forms.ToolStripStatusLabel lat;
        private System.Windows.Forms.ToolStripStatusLabel latText;
        private System.Windows.Forms.ToolStripStatusLabel lng;
        private System.Windows.Forms.ToolStripStatusLabel lngText;
        private System.Windows.Forms.ContextMenuStrip GMapMean;
        private System.Windows.Forms.ToolStripMenuItem CreatePoint;
    }
}

