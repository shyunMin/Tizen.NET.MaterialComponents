using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class RadioButtonPage : BaseGalleryPage
    {
        public override string Name => "Radio Button Gallery";

        public override void Run(Window window)
        {
            Conformant conformant = new Conformant(window);
            conformant.Show();
            Box box = new ColoredBox(window);
            conformant.SetContent(box);
            box.Show();

            var radio = new MRadioButton(window)
            {
                StateValue = 1,
                WeightY = 1,
                AlignmentY = 0.5,
                AlignmentX = 0.5
            };
            box.PackEnd(radio);
            radio.Show();

            var radio2 = new MRadioButton(window)
            {
                StateValue = 4,
                IsEnabled = true,
                Color = Color.FromHex("#E30425"),
                WeightY = 1,
                AlignmentY = 0.5,
                AlignmentX = 0.5
            };
            box.PackEnd(radio2);
            radio.SetGroup(radio2);
            radio2.Show();

            var radio3 = new MRadioButton(window)
            {
                StateValue = 3,
                IsEnabled = false,
                WeightY = 1,
                AlignmentY = 0.5,
                AlignmentX = 0.5
            };
            box.PackEnd(radio3);
            radio3.Show();
        }
    }
}
