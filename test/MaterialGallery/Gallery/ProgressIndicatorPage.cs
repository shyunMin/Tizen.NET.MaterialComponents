using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class ProgressIndicatorPage : BaseGalleryPage
    {
        EcoreTimelineAnimator _animator;

        public override string Name => "ProgressIndicator Gallery";

        public override void Run(Window window)
        {
            Conformant conformant = new Conformant(window);
            conformant.Show();
            Box box = new ColoredBox(window);
            conformant.SetContent(box);
            box.Show();


            MProgressIndicator determinatePI = new MProgressIndicator(window)
            {
                Value = 0,
                MinimumWidth = 200,
                AlignmentY = 0.5,
                WeightX = 1,
                WeightY = 1
            };
            determinatePI.Show();

            MProgressIndicator indeterminatePI = new MProgressIndicator(window)
            {
                Type = MProgressIndicatorType.Indeterminate,
                MinimumWidth = 200,
                AlignmentY = 0.5,
                WeightX = 1,
                WeightY = 1,
            };
            indeterminatePI.Show();

            MProgressIndicator disabledPI = new MProgressIndicator(window)
            {
                MinimumWidth = 200,
                AlignmentY = 0.5,
                WeightX = 1,
                WeightY = 1,
                IsEnabled = false,
            };
            disabledPI.Show();

            box.PackEnd(determinatePI);
            box.PackEnd(indeterminatePI);
            box.PackEnd(disabledPI);

            double max = 1.0;
            double min = 0;
            double unit = 0.1;

            if (_animator==null)
            {
                _animator = new EcoreTimelineAnimator(1.0, ()=> 
                {
                    var val = determinatePI.Value + unit;
                    if (val <= max)
                        determinatePI.Value = val;
                });

            }

            _animator.Start();
        }

        public override void TearDown()
        {
            base.TearDown();
            _animator.Stop();
        }
    }
}
