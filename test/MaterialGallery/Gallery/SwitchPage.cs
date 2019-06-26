using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class SwitchPage : BaseGalleryPage
    {
        public override string Name => "Switch Gallery";

        public override void Run(Window window)
        {
            Conformant conformant = new Conformant(window);
            conformant.Show();
            Box box = new ColoredBox(window);
            conformant.SetContent(box);
            box.Show();


            var switch1 = new MSwitch(window)
            {
                WeightY = 1,
                AlignmentY = 0.5
            };
            box.PackEnd(switch1);
            switch1.Show();

            var switch2 = new MSwitch(window)
            {
                WeightY = 1,
                AlignmentY = 0.5
            };
            box.PackEnd(switch2);
            switch2.Show();

            var switch3 = new MSwitch(window)
            {
                IsEnabled = false,
                IsChecked = true,
                Text = "Disabled",
                WeightY = 1,
                AlignmentY = 0.5
            };
            box.PackEnd(switch3);
            switch3.Show();

            var switch4 = new MSwitch(window)
            {
                IsEnabled = true,
                Text = "Custom Color",
                Color = Color.FromHex("#E30425"),
                WeightY = 1,
                AlignmentY = 0.5
            };
            box.PackEnd(switch4);
            switch4.Show();
        }
    }
}
