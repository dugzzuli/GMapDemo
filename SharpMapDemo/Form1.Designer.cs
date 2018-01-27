namespace SharpMapDemo
{
    partial class Form1
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
            this.picMap = new SharpMap.Forms.MapImage();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // picMap
            // 
            this.picMap.ActiveTool = SharpMap.Forms.MapImage.Tools.None;
            this.picMap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picMap.FineZoomFactor = 10D;
            this.picMap.Location = new System.Drawing.Point(72, 25);
            this.picMap.Name = "picMap";
            this.picMap.PanOnClick = false;
            this.picMap.QueryLayerIndex = 0;
            this.picMap.Size = new System.Drawing.Size(503, 336);
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            this.picMap.WheelZoomMagnitude = 2D;
            this.picMap.ZoomOnDblClick = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 429);
            this.Controls.Add(this.picMap);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpMap.Forms.MapImage picMap;
    }
}

