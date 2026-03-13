using OpenCvSharp.Extensions;
using PITrackerCore;

namespace PiTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void formLog(string text)
        {
            consoleC.AppendText(text);
        }
        Tracker piTracker;
        ImageSequenceSource imageSequenceSource;
        private void startC_Click(object sender, EventArgs e)
        {
            if (piTracker != null)
                return;
            // Create the interface and trigger the algorithm

            if (seqSourceC.Checked)
            {
                if (imageSequenceSource == null)
                {
                    imageSequenceSource = new ImageSequenceSource(imageSourceC.Text);
                    playedC.CheckedChanged += (s, e) =>
                    {
                        imageSequenceSource.AutoIncrement = playedC.Checked;
                    };
                    seekbarC.ValueChanged += (s, e) =>
                    {
                        if (playedC.Checked) return;
                        imageSequenceSource.SetIndex(seekbarC.Value);
                    };
                    imageSequenceSource.OnIndexChanged += (index, min, max) =>
                    {
                        if (!playedC.Checked)
                            return;
                        seekbarC.Invoke(() =>
                        {
                            if (seekbarC.Minimum > min)
                                seekbarC.Minimum = min;
                            if (seekbarC.Maximum < max)
                                seekbarC.Maximum = max;
                            seekbarC.Value = index;
                        });
                    };
                }
                piTracker = new Tracker(imageSequenceSource);
            }
            else
            {
                piTracker = new Tracker(new LiveCameraSource());
            }
            piTracker.OnTrackOutput += PiTracker_OnTrackOutput;
            piTracker.OnDebugFrame += PiTracker_OnDebugFrame;
            piTracker.BeginAsync();
        }

        private void PiTracker_OnDebugFrame(Tracker.DebugFrame frame)
        {// Convert Mat to standard Windows Bitmap
            Bitmap newBitmap = BitmapConverter.ToBitmap(frame.Frame);

            // Marshal to the UI thread
            frameC.Invoke(new Action(() =>
            {
                // CRITICAL: Capture the old image so we can dispose of it
                var oldImage = frameC.BackgroundImage;
                // Assign the new frame
                frameC.BackgroundImage = newBitmap;
                // Dispose the old image to prevent massive GDI+ memory leaks
                oldImage?.Dispose();
                frame.Frame.Dispose();
                frameC.Invalidate();
            }));
        }

        private void PiTracker_OnTrackOutput(Tracker.TrackData output)
        {
        }

        private void frameC_MouseMove(object sender, MouseEventArgs e)
        {
            // get the coordinates on the displayed Mat.
            if (frameC.BackgroundImage == null) return;
            // since the image is set to Zoom, the coordinates of cursor won't match the coordinates of the Mat, we need to convert them.
            var gToM_W = (float)frameC.BackgroundImage.Width / frameC.Width;
            var gToM_H = (float)frameC.BackgroundImage.Height / frameC.Height;
            if (gToM_H > gToM_W)
            {
                // the image is limited by width, so we need to calculate the vertical offset.
                var offset = (frameC.Height - frameC.BackgroundImage.Height / gToM_W) / 2;
                var x = (int)(MousePosition.X * gToM_W);
                var y = (int)((MousePosition.Y - offset) * gToM_W);
                //hoverCoordsC.Text = $"{x} x {y}";
            }
            else
            {
                // the image is limited by height, so we need to calculate the horizontal offset.
                var offset = (frameC.Width - frameC.BackgroundImage.Width / gToM_H) / 2;
                var x = (int)((MousePosition.X - offset) * gToM_H);
                var y = (int)(MousePosition.Y * gToM_H);
                //hoverCoordsC.Text = $"{x} x {y}";
            }
        }
    }
}
