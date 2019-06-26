using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class CircularProgressIndicatorPage : BaseGalleryPage
    {
        EcoreTimelineAnimator _animator;

        public override string Name => "Circular ProgressIndicator Gallery";

        public override void Run(Window window)
        {
            Conformant conformant = new Conformant(window);
            conformant.Show();
            Box box = new ColoredBox(window);
            conformant.SetContent(box);
            box.Show();


            MActivityIndicator determinateAI = new MActivityIndicator(window)
            {
                Value = 50,
                AlignmentX = -1,
                AlignmentY = 0.5,
                WeightX = 1,
                WeightY = 1,
            };
            determinateAI.Show();

            MActivityIndicator indeterminateAI = new MActivityIndicator(window)
            {
                Type = MProgressIndicatorType.Indeterminate,
                AlignmentX = -1,
                AlignmentY = 0.5,
                WeightX = 1,
                WeightY = 1,
            };
            indeterminateAI.Show();

            box.PackEnd(determinateAI);
            box.PackEnd(indeterminateAI);

            double max = 1.0;
            double min = 0;
            double unit = 0.1;

            if (_animator==null)
            {
                _animator = new EcoreTimelineAnimator(1.0, ()=> 
                {
                    var val = determinateAI.Value + unit;
                    if (val <= max)
                        determinateAI.Value = val;
                });

                _animator.Finished += (s, e) =>
                {
                    determinateAI.Value = min;
                    _animator.Start();
                };
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
