using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class AAATestPage : BaseGalleryPage
    {
        public override string Name => "AAATest";

        public override void Run(Window window)
        {
            Conformant conformant = new Conformant(window);
            conformant.Show();
            Box box = new ColoredBox(window);
            box.BackgroundColor = Color.White;
            conformant.SetContent(box);
            box.Show();

            box.IsHorizontal = true;

            box.SetPadding(20, 20);

            for(int i = 0; i<10; i++)
            {
                var label = new Label(window)
                {
                    AlignmentX = -1,
                    AlignmentY = -1,
                    WeightX = 1,
                    WeightY = 1,
                    BackgroundColor = new Color(255, 255, 10 + 20*i)
                };
                label.Show();
                box.PackEnd(label);
            }           

        }
    }
}
