namespace GMapDemo_2
{
    partial class addPointRoute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startPoint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endpoint = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.start2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btncolor = new System.Windows.Forms.Button();
            this.start_show = new System.Windows.Forms.Label();
            this.end_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "地点:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "初始地点:";
            // 
            // startPoint
            // 
            this.startPoint.AutoSize = true;
            this.startPoint.Location = new System.Drawing.Point(13, 92);
            this.startPoint.Name = "startPoint";
            this.startPoint.Size = new System.Drawing.Size(11, 12);
            this.startPoint.TabIndex = 3;
            this.startPoint.Text = "0";
            this.startPoint.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "初始地点:";
            // 
            // endpoint
            // 
            this.endpoint.AutoSize = true;
            this.endpoint.Location = new System.Drawing.Point(13, 134);
            this.endpoint.Name = "endpoint";
            this.endpoint.Size = new System.Drawing.Size(11, 12);
            this.endpoint.TabIndex = 3;
            this.endpoint.Text = "0";
            this.endpoint.Visible = false;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(293, 169);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(238, 87);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 5;
            this.start.Text = "选择";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // start2
            // 
            this.start2.Location = new System.Drawing.Point(238, 123);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(75, 23);
            this.start2.TabIndex = 5;
            this.start2.Text = "选择";
            this.start2.UseVisualStyleBackColor = true;
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "路线颜色:";
            // 
            // btncolor
            // 
            this.btncolor.BackColor = System.Drawing.Color.Red;
            this.btncolor.ForeColor = System.Drawing.Color.Red;
            this.btncolor.Location = new System.Drawing.Point(97, 169);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(75, 23);
            this.btncolor.TabIndex = 7;
            this.btncolor.UseVisualStyleBackColor = false;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // start_show
            // 
            this.start_show.AutoSize = true;
            this.start_show.Location = new System.Drawing.Point(95, 92);
            this.start_show.Name = "start_show";
            this.start_show.Size = new System.Drawing.Size(11, 12);
            this.start_show.TabIndex = 8;
            this.start_show.Text = "0";
            // 
            // end_show
            // 
            this.end_show.AutoSize = true;
            this.end_show.Location = new System.Drawing.Point(96, 134);
            this.end_show.Name = "end_show";
            this.end_show.Size = new System.Drawing.Size(11, 12);
            this.end_show.TabIndex = 8;
            this.end_show.Text = "0";
            // 
            // addPointRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 204);
            this.Controls.Add(this.end_show);
            this.Controls.Add(this.start_show);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.endpoint);
            this.Controls.Add(this.startPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addPointRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addPointRoute";
            this.Load += new System.EventHandler(this.addPointRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label startPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label endpoint;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button start2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Label start_show;
        private System.Windows.Forms.Label end_show;
    }
}