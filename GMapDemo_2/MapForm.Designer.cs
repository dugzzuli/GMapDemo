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
            this.新建路线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.保存地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mapControl = new GMapDemo_2.MapControl();
            this.checkBoxDrawPolygon = new System.Windows.Forms.RadioButton();
            this.drawYuan = new System.Windows.Forms.RadioButton();
            this.statusWin.SuspendLayout();
            this.GMapMean.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusWin
            // 
            this.statusWin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lat,
            this.latText,
            this.lng,
            this.lngText});
            this.statusWin.Location = new System.Drawing.Point(0, 551);
            this.statusWin.Name = "statusWin";
            this.statusWin.Size = new System.Drawing.Size(883, 22);
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
            this.CreatePoint,
            this.新建路线ToolStripMenuItem,
            this.保存地图ToolStripMenuItem});
            this.GMapMean.Name = "GMapMean";
            this.GMapMean.Size = new System.Drawing.Size(125, 70);
            // 
            // CreatePoint
            // 
            this.CreatePoint.Name = "CreatePoint";
            this.CreatePoint.Size = new System.Drawing.Size(124, 22);
            this.CreatePoint.Text = "新建地点";
            this.CreatePoint.Click += new System.EventHandler(this.CreatePoint_Click);
            // 
            // 新建路线ToolStripMenuItem
            // 
            this.新建路线ToolStripMenuItem.Name = "新建路线ToolStripMenuItem";
            this.新建路线ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建路线ToolStripMenuItem.Text = "新建路线";
            this.新建路线ToolStripMenuItem.Click += new System.EventHandler(this.新建路线ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 48);
            this.panel1.TabIndex = 2;
            // 
            // 保存地图ToolStripMenuItem
            // 
            this.保存地图ToolStripMenuItem.Name = "保存地图ToolStripMenuItem";
            this.保存地图ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存地图ToolStripMenuItem.Text = "保存地图";
            this.保存地图ToolStripMenuItem.Click += new System.EventHandler(this.保存地图ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(93, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.drawYuan);
            this.panel2.Controls.Add(this.checkBoxDrawPolygon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.select);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(733, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 551);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "地址:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(47, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 21);
            this.txtAddress.TabIndex = 4;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(97, 139);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(49, 20);
            this.select.TabIndex = 5;
            this.select.Text = "查找";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(47, 76);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 21);
            this.txtCity.TabIndex = 6;
            this.txtCity.Text = "昆明";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "城市:";
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
            this.mapControl.Size = new System.Drawing.Size(883, 573);
            this.mapControl.TabIndex = 0;
            this.mapControl.Zoom = 0D;
            this.mapControl.OnPolygonEnter += new GMap.NET.WindowsForms.PolygonEnter(this.mapControl_OnPolygonEnter);
            this.mapControl.OnPolygonLeave += new GMap.NET.WindowsForms.PolygonLeave(this.mapControl_OnPolygonLeave);
            this.mapControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseDoubleClick);
            this.mapControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseDown);
            this.mapControl.MouseEnter += new System.EventHandler(this.mapControl_MouseEnter);
            this.mapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseMove);
            // 
            // checkBoxDrawPolygon
            // 
            this.checkBoxDrawPolygon.AutoSize = true;
            this.checkBoxDrawPolygon.Location = new System.Drawing.Point(12, 179);
            this.checkBoxDrawPolygon.Name = "checkBoxDrawPolygon";
            this.checkBoxDrawPolygon.Size = new System.Drawing.Size(59, 16);
            this.checkBoxDrawPolygon.TabIndex = 8;
            this.checkBoxDrawPolygon.TabStop = true;
            this.checkBoxDrawPolygon.Text = "多边形";
            this.checkBoxDrawPolygon.UseVisualStyleBackColor = true;
            // 
            // drawYuan
            // 
            this.drawYuan.AutoSize = true;
            this.drawYuan.Location = new System.Drawing.Point(82, 179);
            this.drawYuan.Name = "drawYuan";
            this.drawYuan.Size = new System.Drawing.Size(47, 16);
            this.drawYuan.TabIndex = 8;
            this.drawYuan.TabStop = true;
            this.drawYuan.Text = "圆形";
            this.drawYuan.UseVisualStyleBackColor = true;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusWin);
            this.Controls.Add(this.mapControl);
            this.Name = "MapForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.MapForm_SizeChanged);
            this.statusWin.ResumeLayout(false);
            this.statusWin.PerformLayout();
            this.GMapMean.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem 新建路线ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 保存地图ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.RadioButton checkBoxDrawPolygon;
        private System.Windows.Forms.RadioButton drawYuan;
    }
}

