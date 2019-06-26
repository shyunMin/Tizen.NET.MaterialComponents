using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class ButtonPage : BaseGalleryPage
    {
        public override string Name => "Button Gallery";

        public override void Run(Window window)
        {
            Conformant conformant = new Conformant(window);
            conformant.Show();
            Box box = new ColoredBox(window);
            conformant.SetContent(box);
            box.Show();

            var button = new MButton(window)
            {
                Text= "Button",
                MinimumWidth = 200,
                WeightY = 1,
                AlignmentY = 0.5
            };
            box.PackEnd(button);
            button.Show();

            var button2 = new MButton(window)
            {
                IsEnabled = false,
                Text = "Disabled",
                MinimumWidth = 200,
                WeightY = 1,
                AlignmentY = 0.5
            };
            box.PackEnd(button2);
            button2.Show();

            var button3 = new MButton(window)
            {
                IsEnabled = true,
                Text = "Custom Color",
                BackgroundColor = Color.FromHex("#03A9F4"),
                MinimumWidth = 200,
                WeightY = 1,
                AlignmentY = 0.5
            };
            box.PackEnd(button3);
            button3.Show();

        }
    }
}
