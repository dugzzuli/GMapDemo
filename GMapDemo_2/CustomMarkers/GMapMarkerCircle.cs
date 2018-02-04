
namespace GMapDemo_2
{
   using System;
   using System.Drawing;
   using System.Runtime.Serialization;
   using GMap.NET;
   using GMap.NET.WindowsForms;

    [Serializable]
    public class GMapMarkerCircle : GMapMarker, ISerializable
    {
        /// <summary>
        /// 距离，单位为米
        /// </summary>
        public int Radius;

        /// <summary>
        /// specifies how the outline is painted
        /// </summary>
        [NonSerialized]
        public Pen Stroke = new Pen(Color.FromArgb(155, Color.MidnightBlue));

        /// <summary>
        /// background color
        /// </summary>
        [NonSerialized]
        public Brush Fill = new SolidBrush(Color.FromArgb(155, Color.AliceBlue));

        /// <summary>
        /// is filled
        /// </summary>
        public bool IsFilled = true;

        public GMapMarkerCircle(PointLatLng p, int _raidus)
           : base(p)
        {
            Radius = _raidus; // 100m
            IsHitTestVisible = false;
        }

        public override void OnRender(Graphics g)
        {
            //将距离转换成像素长度
            int R = (int)((Radius) / Overlay.Control.MapProvider.Projection.GetGroundResolution((int)Overlay.Control.Zoom, Position.Lat)) * 2;

            if (IsFilled)
            {
                g.FillEllipse(Fill, new System.Drawing.Rectangle(LocalPosition.X - R / 2, LocalPosition.Y - R / 2, R, R));
            }
            g.DrawEllipse(Stroke, new System.Drawing.Rectangle(LocalPosition.X - R / 2, LocalPosition.Y - R / 2, R, R));
        }

        public override void Dispose()
        {
            if (Stroke != null)
            {
                Stroke.Dispose();
                Stroke = null;
            }

            if (Fill != null)
            {
                Fill.Dispose();
                Fill = null;
            }

            base.Dispose();
        }



        #region ISerializable Members

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            // TODO: Radius, IsFilled
        }

        protected GMapMarkerCircle(SerializationInfo info, StreamingContext context)
           : base(info, context)
        {
            // TODO: Radius, IsFilled
        }

        #endregion
    }
}
