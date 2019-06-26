using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class CheckboxPage : BaseGalleryPage
    {
        public override string Name => "Checkbox Gallery";

        public override void Run(Window window)
        {
            Conformant conformant = new Conformant(window);
            conformant.Show();
            Box box = new ColoredBox(window);
            conformant.SetContent(box);
            box.Show();

            Box horizontalBox = new ColoredBox(window)
            {
                IsHorizontal = true,
                WeightY = 1,
                WeightX = 1,
                AlignmentX = -1,
                AlignmentY = -1
            };
            horizontalBox.Show();

            var check = new MCheckBox(window)
            {
                WeightY = 1,
                WeightX = 1,
                AlignmentY = 0.9,
                AlignmentX = 0.9
            };
            horizontalBox.PackEnd(check);
            check.Show();

            var check2 = new MCheckBox(window)
            {
                IsEnabled = true,
                Color = Color.FromHex("#E30425"),
                WeightY = 1,
                WeightX = 1,
                AlignmentY = 0.9,
                AlignmentX = 0.1
            };
            horizontalBox.PackEnd(check2);
            check2.Show();

            Box horizontalBox2 = new ColoredBox(window)
            {
                IsHorizontal = true,
                WeightY = 1,
                WeightX = 1,
                AlignmentX = -1,
                AlignmentY = -1
            };
            horizontalBox2.Show();

            var check3 = new MCheckBox(window)
            {
                IsEnabled = false,
                IsChecked = false,
                WeightY = 1,
                WeightX = 1,
                AlignmentY = 0.1,
                AlignmentX = 0.9
            };
            horizontalBox2.PackEnd(check3);
            check3.Show();

            var check4 = new MCheckBox(window)
            {
                IsEnabled = false,
                IsChecked = true,
                Color = Color.FromHex("#E30425"),
                WeightY = 1,
                WeightX = 1,
                AlignmentY = 0.1,
                AlignmentX = 0.1
            };
            horizontalBox2.PackEnd(check4);
            check4.Show();

            box.PackEnd(horizontalBox);
            box.PackEnd(horizontalBox2);
        }
    }
}
